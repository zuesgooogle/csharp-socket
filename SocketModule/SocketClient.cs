using System;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;

using System.Collections.Generic;
using System.Collections;

using System.Text;

using Google.ProtocolBuffers;
using Simplegame.Message;


namespace SocketModule
{
	public class StateObject {

		public TcpClient workSocket = null;

		public const int BufferSize = 4096;

		public byte[] buffer = new byte[BufferSize];

		public byte[] cache;
	}

	class SocketClient
	{

		public const int PORT = 8001;
		public const string HOST = "127.0.0.1";

		private TcpClient client;
		private NetworkStream networkStream;
		private bool connected = false;

		public static void Main (string[] args)
		{
			SocketClient clazz = new SocketClient ();
			clazz.start ();

			Thread.Sleep (3000);
			Request.Builder builder = Request.CreateBuilder ();
			builder.SetCommand ("110");
			builder.SetData ("1231231232131");
			
			Request request = builder.BuildPartial ();	

			clazz.sendMessage (request);
			clazz.sendMessage (request);

			Thread.Sleep (30000);
		}

		public void start() 
		{
			Console.WriteLine ("正在连接服务器...");
			try
			{
				client = new TcpClient ();
				client.SendTimeout = 10000; //10s
				client.NoDelay = true;

				client.BeginConnect (IPAddress.Parse (HOST), PORT, new AsyncCallback (onConnect), client);
		

			}catch(Exception e) 
			{
				Console.WriteLine("连接服务器失败. {0}", e.Message);
			}

		}
		
		public void sendMessage(Request request)
		{
			if (connected) 
			{
				byte[] message;
				using(MemoryStream stream = new MemoryStream())
				{
					request.WriteTo(stream);
					message = stream.ToArray();
				}

				MemoryStream temp = new MemoryStream();
				CodedOutputStream os = CodedOutputStream.CreateInstance(temp);
				os.WriteRawVarint32((uint)message.Length);
				os.WriteRawBytes(message);
				os.Flush();

				byte[] data = temp.ToArray();
				client.GetStream().Write(data, 0, data.Length);
			}
		}

		public void onConnect(IAsyncResult result)
		{
			try
			{
				this.connected = true;

				TcpClient client = (TcpClient) result.AsyncState;	
				client.EndConnect(result);

				Console.WriteLine("连接服务器成功!");


				StateObject state = new StateObject();
				state.workSocket = client;

				networkStream = client.GetStream ();
				networkStream.BeginRead(state.buffer, 0, StateObject.BufferSize, new AsyncCallback(onRead), state);


			}catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		public void onRead(IAsyncResult result)
		{
			Console.WriteLine ("接收数据...");

			StateObject state = (StateObject) result.AsyncState;
			TcpClient client = state.workSocket;

			int length = client.GetStream ().EndRead (result);
			if (length < 1) 
			{
				return;
			}

			//decoder message
			CodedInputStream cis = CodedInputStream.CreateInstance (state.buffer);
			int msgLength = (int)cis.ReadRawVarint32();
			byte[] body = cis.ReadRawBytes (msgLength);

			Response response = Response.ParseFrom (body);
			this.dispatcher (response);

			networkStream.BeginRead(state.buffer, 0, StateObject.BufferSize, new AsyncCallback(onRead), state);

		}

		public void dispatcher(Response response)
		{
			Console.WriteLine ("client receive message: {0}", response.ToString ());

			//分发协议，具体业务逻辑进行处理
		}
	}
}
