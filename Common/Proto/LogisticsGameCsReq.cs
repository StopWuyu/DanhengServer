// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LogisticsGameCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from LogisticsGameCsReq.proto</summary>
  public static partial class LogisticsGameCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for LogisticsGameCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LogisticsGameCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhMb2dpc3RpY3NHYW1lQ3NSZXEucHJvdG8aEkxvZ2lzdGljc01hcC5wcm90",
            "byJNChJMb2dpc3RpY3NHYW1lQ3NSZXESIgoLQUFBSEZPQk1KTUQYCCADKAsy",
            "DS5Mb2dpc3RpY3NNYXASEwoLSkJPQU1BSkpFSk4YDyABKAhCHqoCG0VnZ0xp",
            "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.LogisticsMapReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.LogisticsGameCsReq), global::EggLink.DanhengServer.Proto.LogisticsGameCsReq.Parser, new[]{ "AAAHFOBMJMD", "JBOAMAJJEJN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LogisticsGameCsReq : pb::IMessage<LogisticsGameCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LogisticsGameCsReq> _parser = new pb::MessageParser<LogisticsGameCsReq>(() => new LogisticsGameCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LogisticsGameCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.LogisticsGameCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogisticsGameCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogisticsGameCsReq(LogisticsGameCsReq other) : this() {
      aAAHFOBMJMD_ = other.aAAHFOBMJMD_.Clone();
      jBOAMAJJEJN_ = other.jBOAMAJJEJN_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogisticsGameCsReq Clone() {
      return new LogisticsGameCsReq(this);
    }

    /// <summary>Field number for the "AAAHFOBMJMD" field.</summary>
    public const int AAAHFOBMJMDFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.LogisticsMap> _repeated_aAAHFOBMJMD_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.LogisticsMap.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LogisticsMap> aAAHFOBMJMD_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LogisticsMap>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LogisticsMap> AAAHFOBMJMD {
      get { return aAAHFOBMJMD_; }
    }

    /// <summary>Field number for the "JBOAMAJJEJN" field.</summary>
    public const int JBOAMAJJEJNFieldNumber = 15;
    private bool jBOAMAJJEJN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool JBOAMAJJEJN {
      get { return jBOAMAJJEJN_; }
      set {
        jBOAMAJJEJN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LogisticsGameCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LogisticsGameCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!aAAHFOBMJMD_.Equals(other.aAAHFOBMJMD_)) return false;
      if (JBOAMAJJEJN != other.JBOAMAJJEJN) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= aAAHFOBMJMD_.GetHashCode();
      if (JBOAMAJJEJN != false) hash ^= JBOAMAJJEJN.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      aAAHFOBMJMD_.WriteTo(output, _repeated_aAAHFOBMJMD_codec);
      if (JBOAMAJJEJN != false) {
        output.WriteRawTag(120);
        output.WriteBool(JBOAMAJJEJN);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      aAAHFOBMJMD_.WriteTo(ref output, _repeated_aAAHFOBMJMD_codec);
      if (JBOAMAJJEJN != false) {
        output.WriteRawTag(120);
        output.WriteBool(JBOAMAJJEJN);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += aAAHFOBMJMD_.CalculateSize(_repeated_aAAHFOBMJMD_codec);
      if (JBOAMAJJEJN != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LogisticsGameCsReq other) {
      if (other == null) {
        return;
      }
      aAAHFOBMJMD_.Add(other.aAAHFOBMJMD_);
      if (other.JBOAMAJJEJN != false) {
        JBOAMAJJEJN = other.JBOAMAJJEJN;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 66: {
            aAAHFOBMJMD_.AddEntriesFrom(input, _repeated_aAAHFOBMJMD_codec);
            break;
          }
          case 120: {
            JBOAMAJJEJN = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 66: {
            aAAHFOBMJMD_.AddEntriesFrom(ref input, _repeated_aAAHFOBMJMD_codec);
            break;
          }
          case 120: {
            JBOAMAJJEJN = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
