// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerReturnTakePointRewardScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerReturnTakePointRewardScRsp.proto</summary>
  public static partial class PlayerReturnTakePointRewardScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerReturnTakePointRewardScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerReturnTakePointRewardScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZQbGF5ZXJSZXR1cm5UYWtlUG9pbnRSZXdhcmRTY1JzcC5wcm90bxoOSXRl",
            "bUxpc3QucHJvdG8ifQogUGxheWVyUmV0dXJuVGFrZVBvaW50UmV3YXJkU2NS",
            "c3ASHgoLR0dMQkVGS0xES0EYBSABKAsyCS5JdGVtTGlzdBIPCgdyZXRjb2Rl",
            "GAogASgNEhMKC0RJR0xKTE1FTEZGGAQgASgNEhMKC0hMTEZCR0xPSElQGA0g",
            "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerReturnTakePointRewardScRsp), global::EggLink.DanhengServer.Proto.PlayerReturnTakePointRewardScRsp.Parser, new[]{ "GGLBEFKLDKA", "Retcode", "DIGLJLMELFF", "HLLFBGLOHIP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerReturnTakePointRewardScRsp : pb::IMessage<PlayerReturnTakePointRewardScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerReturnTakePointRewardScRsp> _parser = new pb::MessageParser<PlayerReturnTakePointRewardScRsp>(() => new PlayerReturnTakePointRewardScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerReturnTakePointRewardScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerReturnTakePointRewardScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnTakePointRewardScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnTakePointRewardScRsp(PlayerReturnTakePointRewardScRsp other) : this() {
      gGLBEFKLDKA_ = other.gGLBEFKLDKA_ != null ? other.gGLBEFKLDKA_.Clone() : null;
      retcode_ = other.retcode_;
      dIGLJLMELFF_ = other.dIGLJLMELFF_;
      hLLFBGLOHIP_ = other.hLLFBGLOHIP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnTakePointRewardScRsp Clone() {
      return new PlayerReturnTakePointRewardScRsp(this);
    }

    /// <summary>Field number for the "GGLBEFKLDKA" field.</summary>
    public const int GGLBEFKLDKAFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.ItemList gGLBEFKLDKA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList GGLBEFKLDKA {
      get { return gGLBEFKLDKA_; }
      set {
        gGLBEFKLDKA_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 10;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "DIGLJLMELFF" field.</summary>
    public const int DIGLJLMELFFFieldNumber = 4;
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
    public const int HLLFBGLOHIPFieldNumber = 13;
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
      return Equals(other as PlayerReturnTakePointRewardScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerReturnTakePointRewardScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GGLBEFKLDKA, other.GGLBEFKLDKA)) return false;
      if (Retcode != other.Retcode) return false;
      if (DIGLJLMELFF != other.DIGLJLMELFF) return false;
      if (HLLFBGLOHIP != other.HLLFBGLOHIP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (gGLBEFKLDKA_ != null) hash ^= GGLBEFKLDKA.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
        output.WriteRawTag(32);
        output.WriteUInt32(DIGLJLMELFF);
      }
      if (gGLBEFKLDKA_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(GGLBEFKLDKA);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (HLLFBGLOHIP != 0) {
        output.WriteRawTag(104);
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
        output.WriteRawTag(32);
        output.WriteUInt32(DIGLJLMELFF);
      }
      if (gGLBEFKLDKA_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(GGLBEFKLDKA);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (HLLFBGLOHIP != 0) {
        output.WriteRawTag(104);
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
      if (gGLBEFKLDKA_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GGLBEFKLDKA);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
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
    public void MergeFrom(PlayerReturnTakePointRewardScRsp other) {
      if (other == null) {
        return;
      }
      if (other.gGLBEFKLDKA_ != null) {
        if (gGLBEFKLDKA_ == null) {
          GGLBEFKLDKA = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        GGLBEFKLDKA.MergeFrom(other.GGLBEFKLDKA);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 32: {
            DIGLJLMELFF = input.ReadUInt32();
            break;
          }
          case 42: {
            if (gGLBEFKLDKA_ == null) {
              GGLBEFKLDKA = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(GGLBEFKLDKA);
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 104: {
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
          case 32: {
            DIGLJLMELFF = input.ReadUInt32();
            break;
          }
          case 42: {
            if (gGLBEFKLDKA_ == null) {
              GGLBEFKLDKA = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(GGLBEFKLDKA);
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 104: {
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
