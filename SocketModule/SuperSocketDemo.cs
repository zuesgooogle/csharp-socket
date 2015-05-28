using System;
using System.Net;
using System.IO;

using System.Threading;

using Google.ProtocolBuffers;
using Simplegame.Message;

using SuperSocket.ClientEngine;

namespace SocketModule
{
	public class SuperSocketDemo
	{

		public static DataEventArgs buffer = new DataEventArgs(); 

		public static int count = 0;

		public static void Main (string[] args)
		{
			 
			buffer.Data = new byte[8192]; //8 KB


			IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8001);

			AsyncTcpSession client = new AsyncTcpSession (endPoint);
			client.Connected += OnConnected;
			client.DataReceived += OnDataReceive;

			client.Connect ();

			Request.Builder builder = Request.CreateBuilder ();
			builder.SetCommand ("110");
			builder.SetData ("1231231232131");
			
			Request request = builder.BuildPartial ();	
			
			sendMessage (client, request);


			Thread.Sleep (30000);
		}

		public static void OnConnected(Object sender, EventArgs e)
		{
			Console.WriteLine ("connect to server finish.");
		}

		public static void OnDataReceive(Object sender, DataEventArgs e) 
		{
			Console.WriteLine ("buff length: {0}, offset: {1}", e.Length, e.Offset);
			if( e.Length <= 0 )
			{
				return;
			}
			Array.Copy (e.Data, 0, buffer.Data, buffer.Length, e.Length);
			buffer.Length += e.Length;

			Console.WriteLine ("cache buff length: {0}, offset: {1}", buffer.Length, buffer.Offset);


			CodedInputStream stream = CodedInputStream.CreateInstance (buffer.Data);
			while ( !stream.IsAtEnd ) 
			{
				int markReadIndex = (int)stream.Position;

				//data length
				int varint32 = (int)stream.ReadRawVarint32();
				if( varint32 <= (buffer.Length - (int)stream.Position) )
				{
					try
					{
						byte[] body = stream.ReadRawBytes (varint32);
						
						Response response = Response.ParseFrom (body);
						
						Console.WriteLine("Response: " + response.ToString() + ", count: " + (++count));
					}catch(Exception exception)
					{
						Console.WriteLine(exception.Message);
					}
				} 
				else 
				{

					byte[] dest = new byte[8192];
					int remainSize = buffer.Length - markReadIndex;
					Array.Copy(buffer.Data, markReadIndex, dest, 0, remainSize);

					/**
					 * 缓存未处理完的字节 
					 */
					buffer.Data = dest;
					buffer.Offset = 0;
					buffer.Length = remainSize;
					break;
				}
			}
		}

		public static void sendMessage(AsyncTcpSession client, Request request)
		{
			using(MemoryStream stream = new MemoryStream())
			{
				CodedOutputStream os = CodedOutputStream.CreateInstance(stream);
				os.WriteMessageNoTag(request);
				os.Flush();

				byte[] data = stream.ToArray();
				client.Send ( new ArraySegment<byte>(data) );
			}
		}
	}
}

