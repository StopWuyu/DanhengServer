// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerReturnTakePointRewardCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerReturnTakePointRewardCsReq.proto</summary>
  public static partial class PlayerReturnTakePointRewardCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerReturnTakePointRewardCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerReturnTakePointRewardCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZQbGF5ZXJSZXR1cm5UYWtlUG9pbnRSZXdhcmRDc1JlcS5wcm90byJMCiBQ",
            "bGF5ZXJSZXR1cm5UYWtlUG9pbnRSZXdhcmRDc1JlcRITCgtESUdMSkxNRUxG",
            "RhgBIAEoDRITCgtITExGQkdMT0hJUBgKIAEoDUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerReturnTakePointRewardCsReq), global::EggLink.DanhengServer.Proto.PlayerReturnTakePointRewardCsReq.Parser, new[]{ "DIGLJLMELFF", "HLLFBGLOHIP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerReturnTakePointRewardCsReq : pb::IMessage<PlayerReturnTakePointRewardCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerReturnTakePointRewardCsReq> _parser = new pb::MessageParser<PlayerReturnTakePointRewardCsReq>(() => new PlayerReturnTakePointRewardCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerReturnTakePointRewardCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerReturnTakePointRewardCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnTakePointRewardCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnTakePointRewardCsReq(PlayerReturnTakePointRewardCsReq other) : this() {
      dIGLJLMELFF_ = other.dIGLJLMELFF_;
      hLLFBGLOHIP_ = other.hLLFBGLOHIP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnTakePointRewardCsReq Clone() {
      return new PlayerReturnTakePointRewardCsReq(this);
    }

    /// <summary>Field number for the "DIGLJLMELFF" field.</summary>
    public const int DIGLJLMELFFFieldNumber = 1;
    private uint dIGLJLMELFF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DIGLJLMELFF {
      get { return dIGLJLMELFF_; }
      set {
        dIGLJLMELFF_ = value;
      }
    }

    /// <summary>Field number for the "HLLFBGLOHIP" field.</summary>
    public const int HLLFBGLOHIPFieldNumber = 10;
    private uint hLLFBGLOHIP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HLLFBGLOHIP {
      get { return hLLFBGLOHIP_; }
      set {
        hLLFBGLOHIP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerReturnTakePointRewardCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerReturnTakePointRewardCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DIGLJLMELFF != other.DIGLJLMELFF) return false;
      if (HLLFBGLOHIP != other.HLLFBGLOHIP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DIGLJLMELFF != 0) hash ^= DIGLJLMELFF.GetHashCode();
      if (HLLFBGLOHIP != 0) hash ^= HLLFBGLOHIP.GetHashCode();
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
      if (DIGLJLMELFF != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(DIGLJLMELFF);
      }
      if (HLLFBGLOHIP != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(HLLFBGLOHIP);
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
      if (DIGLJLMELFF != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(DIGLJLMELFF);
      }
      if (HLLFBGLOHIP != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(HLLFBGLOHIP);
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
      if (DIGLJLMELFF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DIGLJLMELFF);
      }
      if (HLLFBGLOHIP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HLLFBGLOHIP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerReturnTakePointRewardCsReq other) {
      if (other == null) {
        return;
      }
      if (other.DIGLJLMELFF != 0) {
        DIGLJLMELFF = other.DIGLJLMELFF;
      }
      if (other.HLLFBGLOHIP != 0) {
        HLLFBGLOHIP = other.HLLFBGLOHIP;
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
          case 8: {
            DIGLJLMELFF = input.ReadUInt32();
            break;
          }
          case 80: {
            HLLFBGLOHIP = input.ReadUInt32();
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
          case 8: {
            DIGLJLMELFF = input.ReadUInt32();
            break;
          }
          case 80: {
            HLLFBGLOHIP = input.ReadUInt32();
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
