// Generated by ProtoGen, Version=2.4.1.521, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Simplegame.Message {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class Message {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_netty_Request__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::Simplegame.Message.Request, global::Simplegame.Message.Request.Builder> internal__static_netty_Request__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_netty_Response__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::Simplegame.Message.Response, global::Simplegame.Message.Response.Builder> internal__static_netty_Response__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static Message() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "ChZ0dXRvcmlhbC9tZXNzYWdlLnByb3RvEgVuZXR0eRokZ29vZ2xlL3Byb3Rv" + 
          "YnVmL2NzaGFycF9vcHRpb25zLnByb3RvIigKB1JlcXVlc3QSDwoHY29tbWFu" + 
          "ZBgBIAIoCRIMCgRkYXRhGAIgAigJIikKCFJlc3BvbnNlEg8KB2NvbW1hbmQY" + 
          "ASACKAkSDAoEZGF0YRgCIAIoCUIgwj4dChJTaW1wbGVnYW1lLk1lc3NhZ2US" + 
          "B01lc3NhZ2U=");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_netty_Request__Descriptor = Descriptor.MessageTypes[0];
        internal__static_netty_Request__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Simplegame.Message.Request, global::Simplegame.Message.Request.Builder>(internal__static_netty_Request__Descriptor,
                new string[] { "Command", "Data", });
        internal__static_netty_Response__Descriptor = Descriptor.MessageTypes[1];
        internal__static_netty_Response__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Simplegame.Message.Response, global::Simplegame.Message.Response.Builder>(internal__static_netty_Response__Descriptor,
                new string[] { "Command", "Data", });
        pb::ExtensionRegistry registry = pb::ExtensionRegistry.CreateInstance();
        RegisterAllExtensions(registry);
        global::Google.ProtocolBuffers.DescriptorProtos.CSharpOptions.RegisterAllExtensions(registry);
        return registry;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::Google.ProtocolBuffers.DescriptorProtos.CSharpOptions.Descriptor, 
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Request : pb::GeneratedMessage<Request, Request.Builder> {
    private Request() { }
    private static readonly Request defaultInstance = new Request().MakeReadOnly();
    private static readonly string[] _requestFieldNames = new string[] { "command", "data" };
    private static readonly uint[] _requestFieldTags = new uint[] { 10, 18 };
    public static Request DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override Request DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override Request ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Simplegame.Message.Message.internal__static_netty_Request__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<Request, Request.Builder> InternalFieldAccessors {
      get { return global::Simplegame.Message.Message.internal__static_netty_Request__FieldAccessorTable; }
    }
    
    public const int CommandFieldNumber = 1;
    private bool hasCommand;
    private string command_ = "";
    public bool HasCommand {
      get { return hasCommand; }
    }
    public string Command {
      get { return command_; }
    }
    
    public const int DataFieldNumber = 2;
    private bool hasData;
    private string data_ = "";
    public bool HasData {
      get { return hasData; }
    }
    public string Data {
      get { return data_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasCommand) return false;
        if (!hasData) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _requestFieldNames;
      if (hasCommand) {
        output.WriteString(1, field_names[0], Command);
      }
      if (hasData) {
        output.WriteString(2, field_names[1], Data);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasCommand) {
          size += pb::CodedOutputStream.ComputeStringSize(1, Command);
        }
        if (hasData) {
          size += pb::CodedOutputStream.ComputeStringSize(2, Data);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static Request ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Request ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Request ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Request ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Request ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Request ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Request ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static Request ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static Request ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Request ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private Request MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(Request prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<Request, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(Request cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private Request result;
      
      private Request PrepareBuilder() {
        if (resultIsReadOnly) {
          Request original = result;
          result = new Request();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override Request MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Simplegame.Message.Request.Descriptor; }
      }
      
      public override Request DefaultInstanceForType {
        get { return global::Simplegame.Message.Request.DefaultInstance; }
      }
      
      public override Request BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is Request) {
          return MergeFrom((Request) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(Request other) {
        if (other == global::Simplegame.Message.Request.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasCommand) {
          Command = other.Command;
        }
        if (other.HasData) {
          Data = other.Data;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_requestFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _requestFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              result.hasCommand = input.ReadString(ref result.command_);
              break;
            }
            case 18: {
              result.hasData = input.ReadString(ref result.data_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasCommand {
        get { return result.hasCommand; }
      }
      public string Command {
        get { return result.Command; }
        set { SetCommand(value); }
      }
      public Builder SetCommand(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasCommand = true;
        result.command_ = value;
        return this;
      }
      public Builder ClearCommand() {
        PrepareBuilder();
        result.hasCommand = false;
        result.command_ = "";
        return this;
      }
      
      public bool HasData {
        get { return result.hasData; }
      }
      public string Data {
        get { return result.Data; }
        set { SetData(value); }
      }
      public Builder SetData(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasData = true;
        result.data_ = value;
        return this;
      }
      public Builder ClearData() {
        PrepareBuilder();
        result.hasData = false;
        result.data_ = "";
        return this;
      }
    }
    static Request() {
      object.ReferenceEquals(global::Simplegame.Message.Message.Descriptor, null);
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Response : pb::GeneratedMessage<Response, Response.Builder> {
    private Response() { }
    private static readonly Response defaultInstance = new Response().MakeReadOnly();
    private static readonly string[] _responseFieldNames = new string[] { "command", "data" };
    private static readonly uint[] _responseFieldTags = new uint[] { 10, 18 };
    public static Response DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override Response DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override Response ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Simplegame.Message.Message.internal__static_netty_Response__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<Response, Response.Builder> InternalFieldAccessors {
      get { return global::Simplegame.Message.Message.internal__static_netty_Response__FieldAccessorTable; }
    }
    
    public const int CommandFieldNumber = 1;
    private bool hasCommand;
    private string command_ = "";
    public bool HasCommand {
      get { return hasCommand; }
    }
    public string Command {
      get { return command_; }
    }
    
    public const int DataFieldNumber = 2;
    private bool hasData;
    private string data_ = "";
    public bool HasData {
      get { return hasData; }
    }
    public string Data {
      get { return data_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasCommand) return false;
        if (!hasData) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _responseFieldNames;
      if (hasCommand) {
        output.WriteString(1, field_names[0], Command);
      }
      if (hasData) {
        output.WriteString(2, field_names[1], Data);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasCommand) {
          size += pb::CodedOutputStream.ComputeStringSize(1, Command);
        }
        if (hasData) {
          size += pb::CodedOutputStream.ComputeStringSize(2, Data);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static Response ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Response ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Response ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Response ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Response ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Response ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Response ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static Response ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static Response ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Response ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private Response MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(Response prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<Response, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(Response cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private Response result;
      
      private Response PrepareBuilder() {
        if (resultIsReadOnly) {
          Response original = result;
          result = new Response();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override Response MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Simplegame.Message.Response.Descriptor; }
      }
      
      public override Response DefaultInstanceForType {
        get { return global::Simplegame.Message.Response.DefaultInstance; }
      }
      
      public override Response BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is Response) {
          return MergeFrom((Response) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(Response other) {
        if (other == global::Simplegame.Message.Response.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasCommand) {
          Command = other.Command;
        }
        if (other.HasData) {
          Data = other.Data;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_responseFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _responseFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              result.hasCommand = input.ReadString(ref result.command_);
              break;
            }
            case 18: {
              result.hasData = input.ReadString(ref result.data_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasCommand {
        get { return result.hasCommand; }
      }
      public string Command {
        get { return result.Command; }
        set { SetCommand(value); }
      }
      public Builder SetCommand(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasCommand = true;
        result.command_ = value;
        return this;
      }
      public Builder ClearCommand() {
        PrepareBuilder();
        result.hasCommand = false;
        result.command_ = "";
        return this;
      }
      
      public bool HasData {
        get { return result.hasData; }
      }
      public string Data {
        get { return result.Data; }
        set { SetData(value); }
      }
      public Builder SetData(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasData = true;
        result.data_ = value;
        return this;
      }
      public Builder ClearData() {
        PrepareBuilder();
        result.hasData = false;
        result.data_ = "";
        return this;
      }
    }
    static Response() {
      object.ReferenceEquals(global::Simplegame.Message.Message.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
