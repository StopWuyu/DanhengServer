// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EFHHIADBIED.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EFHHIADBIED.proto</summary>
  public static partial class EFHHIADBIEDReflection {

    #region Descriptor
    /// <summary>File descriptor for EFHHIADBIED.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EFHHIADBIEDReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFFRkhISUFEQklFRC5wcm90bxoPU3BCYXJJbmZvLnByb3RvInIKC0VGSEhJ",
            "QURCSUVEEhMKC0ZOR0lCRUJLTEpCGAcgASgNEgoKAmhwGAsgASgNEhMKC2F2",
            "YXRhcl90eXBlGAYgASgNEhoKBnNwX2JhchgNIAEoCzIKLlNwQmFySW5mbxIR",
            "CglhdmF0YXJfaWQYDyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.SpBarInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EFHHIADBIED), global::EggLink.DanhengServer.Proto.EFHHIADBIED.Parser, new[]{ "FNGIBEBKLJB", "Hp", "AvatarType", "SpBar", "AvatarId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EFHHIADBIED : pb::IMessage<EFHHIADBIED>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EFHHIADBIED> _parser = new pb::MessageParser<EFHHIADBIED>(() => new EFHHIADBIED());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EFHHIADBIED> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EFHHIADBIEDReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EFHHIADBIED() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EFHHIADBIED(EFHHIADBIED other) : this() {
      fNGIBEBKLJB_ = other.fNGIBEBKLJB_;
      hp_ = other.hp_;
      avatarType_ = other.avatarType_;
      spBar_ = other.spBar_ != null ? other.spBar_.Clone() : null;
      avatarId_ = other.avatarId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EFHHIADBIED Clone() {
      return new EFHHIADBIED(this);
    }

    /// <summary>Field number for the "FNGIBEBKLJB" field.</summary>
    public const int FNGIBEBKLJBFieldNumber = 7;
    private uint fNGIBEBKLJB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FNGIBEBKLJB {
      get { return fNGIBEBKLJB_; }
      set {
        fNGIBEBKLJB_ = value;
      }
    }

    /// <summary>Field number for the "hp" field.</summary>
    public const int HpFieldNumber = 11;
    private uint hp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Hp {
      get { return hp_; }
      set {
        hp_ = value;
      }
    }

    /// <summary>Field number for the "avatar_type" field.</summary>
    public const int AvatarTypeFieldNumber = 6;
    private uint avatarType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarType {
      get { return avatarType_; }
      set {
        avatarType_ = value;
      }
    }

    /// <summary>Field number for the "sp_bar" field.</summary>
    public const int SpBarFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.SpBarInfo spBar_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SpBarInfo SpBar {
      get { return spBar_; }
      set {
        spBar_ = value;
      }
    }

    /// <summary>Field number for the "avatar_id" field.</summary>
    public const int AvatarIdFieldNumber = 15;
    private uint avatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EFHHIADBIED);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EFHHIADBIED other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FNGIBEBKLJB != other.FNGIBEBKLJB) return false;
      if (Hp != other.Hp) return false;
      if (AvatarType != other.AvatarType) return false;
      if (!object.Equals(SpBar, other.SpBar)) return false;
      if (AvatarId != other.AvatarId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FNGIBEBKLJB != 0) hash ^= FNGIBEBKLJB.GetHashCode();
      if (Hp != 0) hash ^= Hp.GetHashCode();
      if (AvatarType != 0) hash ^= AvatarType.GetHashCode();
      if (spBar_ != null) hash ^= SpBar.GetHashCode();
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
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
      if (AvatarType != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(AvatarType);
      }
      if (FNGIBEBKLJB != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(FNGIBEBKLJB);
      }
      if (Hp != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Hp);
      }
      if (spBar_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(SpBar);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(AvatarId);
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
      if (AvatarType != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(AvatarType);
      }
      if (FNGIBEBKLJB != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(FNGIBEBKLJB);
      }
      if (Hp != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Hp);
      }
      if (spBar_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(SpBar);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(AvatarId);
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
      if (FNGIBEBKLJB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FNGIBEBKLJB);
      }
      if (Hp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Hp);
      }
      if (AvatarType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarType);
      }
      if (spBar_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpBar);
      }
      if (AvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EFHHIADBIED other) {
      if (other == null) {
        return;
      }
      if (other.FNGIBEBKLJB != 0) {
        FNGIBEBKLJB = other.FNGIBEBKLJB;
      }
      if (other.Hp != 0) {
        Hp = other.Hp;
      }
      if (other.AvatarType != 0) {
        AvatarType = other.AvatarType;
      }
      if (other.spBar_ != null) {
        if (spBar_ == null) {
          SpBar = new global::EggLink.DanhengServer.Proto.SpBarInfo();
        }
        SpBar.MergeFrom(other.SpBar);
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
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
          case 48: {
            AvatarType = input.ReadUInt32();
            break;
          }
          case 56: {
            FNGIBEBKLJB = input.ReadUInt32();
            break;
          }
          case 88: {
            Hp = input.ReadUInt32();
            break;
          }
          case 106: {
            if (spBar_ == null) {
              SpBar = new global::EggLink.DanhengServer.Proto.SpBarInfo();
            }
            input.ReadMessage(SpBar);
            break;
          }
          case 120: {
            AvatarId = input.ReadUInt32();
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
          case 48: {
            AvatarType = input.ReadUInt32();
            break;
          }
          case 56: {
            FNGIBEBKLJB = input.ReadUInt32();
            break;
          }
          case 88: {
            Hp = input.ReadUInt32();
            break;
          }
          case 106: {
            if (spBar_ == null) {
              SpBar = new global::EggLink.DanhengServer.Proto.SpBarInfo();
            }
            input.ReadMessage(SpBar);
            break;
          }
          case 120: {
            AvatarId = input.ReadUInt32();
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
