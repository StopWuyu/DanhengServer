// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerReturnInfoQueryScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerReturnInfoQueryScRsp.proto</summary>
  public static partial class PlayerReturnInfoQueryScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerReturnInfoQueryScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerReturnInfoQueryScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBQbGF5ZXJSZXR1cm5JbmZvUXVlcnlTY1JzcC5wcm90bxoWUGxheWVyUmV0",
            "dXJuSW5mby5wcm90byJxChpQbGF5ZXJSZXR1cm5JbmZvUXVlcnlTY1JzcBIP",
            "CgdyZXRjb2RlGAEgASgNEi0KEnBsYXllcl9yZXR1cm5faW5mbxgNIAEoCzIR",
            "LlBsYXllclJldHVybkluZm8SEwoLQ0RIS0pDSFBJQUEYDyABKA1CHqoCG0Vn",
            "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PlayerReturnInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerReturnInfoQueryScRsp), global::EggLink.DanhengServer.Proto.PlayerReturnInfoQueryScRsp.Parser, new[]{ "Retcode", "PlayerReturnInfo", "CDHKJCHPIAA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerReturnInfoQueryScRsp : pb::IMessage<PlayerReturnInfoQueryScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerReturnInfoQueryScRsp> _parser = new pb::MessageParser<PlayerReturnInfoQueryScRsp>(() => new PlayerReturnInfoQueryScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerReturnInfoQueryScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerReturnInfoQueryScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnInfoQueryScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnInfoQueryScRsp(PlayerReturnInfoQueryScRsp other) : this() {
      retcode_ = other.retcode_;
      playerReturnInfo_ = other.playerReturnInfo_ != null ? other.playerReturnInfo_.Clone() : null;
      cDHKJCHPIAA_ = other.cDHKJCHPIAA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnInfoQueryScRsp Clone() {
      return new PlayerReturnInfoQueryScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "player_return_info" field.</summary>
    public const int PlayerReturnInfoFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.PlayerReturnInfo playerReturnInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PlayerReturnInfo PlayerReturnInfo {
      get { return playerReturnInfo_; }
      set {
        playerReturnInfo_ = value;
      }
    }

    /// <summary>Field number for the "CDHKJCHPIAA" field.</summary>
    public const int CDHKJCHPIAAFieldNumber = 15;
    private uint cDHKJCHPIAA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CDHKJCHPIAA {
      get { return cDHKJCHPIAA_; }
      set {
        cDHKJCHPIAA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerReturnInfoQueryScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerReturnInfoQueryScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(PlayerReturnInfo, other.PlayerReturnInfo)) return false;
      if (CDHKJCHPIAA != other.CDHKJCHPIAA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (playerReturnInfo_ != null) hash ^= PlayerReturnInfo.GetHashCode();
      if (CDHKJCHPIAA != 0) hash ^= CDHKJCHPIAA.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      if (playerReturnInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(PlayerReturnInfo);
      }
      if (CDHKJCHPIAA != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CDHKJCHPIAA);
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      if (playerReturnInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(PlayerReturnInfo);
      }
      if (CDHKJCHPIAA != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CDHKJCHPIAA);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (playerReturnInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerReturnInfo);
      }
      if (CDHKJCHPIAA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CDHKJCHPIAA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerReturnInfoQueryScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.playerReturnInfo_ != null) {
        if (playerReturnInfo_ == null) {
          PlayerReturnInfo = new global::EggLink.DanhengServer.Proto.PlayerReturnInfo();
        }
        PlayerReturnInfo.MergeFrom(other.PlayerReturnInfo);
      }
      if (other.CDHKJCHPIAA != 0) {
        CDHKJCHPIAA = other.CDHKJCHPIAA;
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 106: {
            if (playerReturnInfo_ == null) {
              PlayerReturnInfo = new global::EggLink.DanhengServer.Proto.PlayerReturnInfo();
            }
            input.ReadMessage(PlayerReturnInfo);
            break;
          }
          case 120: {
            CDHKJCHPIAA = input.ReadUInt32();
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 106: {
            if (playerReturnInfo_ == null) {
              PlayerReturnInfo = new global::EggLink.DanhengServer.Proto.PlayerReturnInfo();
            }
            input.ReadMessage(PlayerReturnInfo);
            break;
          }
          case 120: {
            CDHKJCHPIAA = input.ReadUInt32();
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
