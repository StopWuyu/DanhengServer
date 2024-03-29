// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UseItemCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from UseItemCsReq.proto</summary>
  public static partial class UseItemCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for UseItemCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJVc2VJdGVtQ3NSZXEucHJvdG8aEEF2YXRhclR5cGUucHJvdG8ipwEKDFVz",
            "ZUl0ZW1Dc1JlcRIkCg91c2VfYXZhdGFyX3R5cGUYDiABKA4yCy5BdmF0YXJU",
            "eXBlEhMKC0tLQURISUFCUElCGAIgASgNEhoKEm9wdGlvbmFsX3Jld2FyZF9p",
            "ZBgPIAEoDRITCgtOTUZCTEtDT0ZNThgHIAEoDRITCgtDS0dEQUhER0RJShgK",
            "IAEoCBIWCg5iYXNlX2F2YXRhcl9pZBgMIAEoDUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AvatarTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.UseItemCsReq), global::EggLink.DanhengServer.Proto.UseItemCsReq.Parser, new[]{ "UseAvatarType", "KKADHIABPIB", "OptionalRewardId", "NMFBLKCOFMN", "CKGDAHDGDIJ", "BaseAvatarId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UseItemCsReq : pb::IMessage<UseItemCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UseItemCsReq> _parser = new pb::MessageParser<UseItemCsReq>(() => new UseItemCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UseItemCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.UseItemCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseItemCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseItemCsReq(UseItemCsReq other) : this() {
      useAvatarType_ = other.useAvatarType_;
      kKADHIABPIB_ = other.kKADHIABPIB_;
      optionalRewardId_ = other.optionalRewardId_;
      nMFBLKCOFMN_ = other.nMFBLKCOFMN_;
      cKGDAHDGDIJ_ = other.cKGDAHDGDIJ_;
      baseAvatarId_ = other.baseAvatarId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseItemCsReq Clone() {
      return new UseItemCsReq(this);
    }

    /// <summary>Field number for the "use_avatar_type" field.</summary>
    public const int UseAvatarTypeFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.AvatarType useAvatarType_ = global::EggLink.DanhengServer.Proto.AvatarType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AvatarType UseAvatarType {
      get { return useAvatarType_; }
      set {
        useAvatarType_ = value;
      }
    }

    /// <summary>Field number for the "KKADHIABPIB" field.</summary>
    public const int KKADHIABPIBFieldNumber = 2;
    private uint kKADHIABPIB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KKADHIABPIB {
      get { return kKADHIABPIB_; }
      set {
        kKADHIABPIB_ = value;
      }
    }

    /// <summary>Field number for the "optional_reward_id" field.</summary>
    public const int OptionalRewardIdFieldNumber = 15;
    private uint optionalRewardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OptionalRewardId {
      get { return optionalRewardId_; }
      set {
        optionalRewardId_ = value;
      }
    }

    /// <summary>Field number for the "NMFBLKCOFMN" field.</summary>
    public const int NMFBLKCOFMNFieldNumber = 7;
    private uint nMFBLKCOFMN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NMFBLKCOFMN {
      get { return nMFBLKCOFMN_; }
      set {
        nMFBLKCOFMN_ = value;
      }
    }

    /// <summary>Field number for the "CKGDAHDGDIJ" field.</summary>
    public const int CKGDAHDGDIJFieldNumber = 10;
    private bool cKGDAHDGDIJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CKGDAHDGDIJ {
      get { return cKGDAHDGDIJ_; }
      set {
        cKGDAHDGDIJ_ = value;
      }
    }

    /// <summary>Field number for the "base_avatar_id" field.</summary>
    public const int BaseAvatarIdFieldNumber = 12;
    private uint baseAvatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BaseAvatarId {
      get { return baseAvatarId_; }
      set {
        baseAvatarId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UseItemCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UseItemCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UseAvatarType != other.UseAvatarType) return false;
      if (KKADHIABPIB != other.KKADHIABPIB) return false;
      if (OptionalRewardId != other.OptionalRewardId) return false;
      if (NMFBLKCOFMN != other.NMFBLKCOFMN) return false;
      if (CKGDAHDGDIJ != other.CKGDAHDGDIJ) return false;
      if (BaseAvatarId != other.BaseAvatarId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (UseAvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) hash ^= UseAvatarType.GetHashCode();
      if (KKADHIABPIB != 0) hash ^= KKADHIABPIB.GetHashCode();
      if (OptionalRewardId != 0) hash ^= OptionalRewardId.GetHashCode();
      if (NMFBLKCOFMN != 0) hash ^= NMFBLKCOFMN.GetHashCode();
      if (CKGDAHDGDIJ != false) hash ^= CKGDAHDGDIJ.GetHashCode();
      if (BaseAvatarId != 0) hash ^= BaseAvatarId.GetHashCode();
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
      if (KKADHIABPIB != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(KKADHIABPIB);
      }
      if (NMFBLKCOFMN != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(NMFBLKCOFMN);
      }
      if (CKGDAHDGDIJ != false) {
        output.WriteRawTag(80);
        output.WriteBool(CKGDAHDGDIJ);
      }
      if (BaseAvatarId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BaseAvatarId);
      }
      if (UseAvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) UseAvatarType);
      }
      if (OptionalRewardId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(OptionalRewardId);
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
      if (KKADHIABPIB != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(KKADHIABPIB);
      }
      if (NMFBLKCOFMN != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(NMFBLKCOFMN);
      }
      if (CKGDAHDGDIJ != false) {
        output.WriteRawTag(80);
        output.WriteBool(CKGDAHDGDIJ);
      }
      if (BaseAvatarId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BaseAvatarId);
      }
      if (UseAvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) UseAvatarType);
      }
      if (OptionalRewardId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(OptionalRewardId);
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
      if (UseAvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UseAvatarType);
      }
      if (KKADHIABPIB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KKADHIABPIB);
      }
      if (OptionalRewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OptionalRewardId);
      }
      if (NMFBLKCOFMN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NMFBLKCOFMN);
      }
      if (CKGDAHDGDIJ != false) {
        size += 1 + 1;
      }
      if (BaseAvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BaseAvatarId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UseItemCsReq other) {
      if (other == null) {
        return;
      }
      if (other.UseAvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        UseAvatarType = other.UseAvatarType;
      }
      if (other.KKADHIABPIB != 0) {
        KKADHIABPIB = other.KKADHIABPIB;
      }
      if (other.OptionalRewardId != 0) {
        OptionalRewardId = other.OptionalRewardId;
      }
      if (other.NMFBLKCOFMN != 0) {
        NMFBLKCOFMN = other.NMFBLKCOFMN;
      }
      if (other.CKGDAHDGDIJ != false) {
        CKGDAHDGDIJ = other.CKGDAHDGDIJ;
      }
      if (other.BaseAvatarId != 0) {
        BaseAvatarId = other.BaseAvatarId;
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
          case 16: {
            KKADHIABPIB = input.ReadUInt32();
            break;
          }
          case 56: {
            NMFBLKCOFMN = input.ReadUInt32();
            break;
          }
          case 80: {
            CKGDAHDGDIJ = input.ReadBool();
            break;
          }
          case 96: {
            BaseAvatarId = input.ReadUInt32();
            break;
          }
          case 112: {
            UseAvatarType = (global::EggLink.DanhengServer.Proto.AvatarType) input.ReadEnum();
            break;
          }
          case 120: {
            OptionalRewardId = input.ReadUInt32();
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
          case 16: {
            KKADHIABPIB = input.ReadUInt32();
            break;
          }
          case 56: {
            NMFBLKCOFMN = input.ReadUInt32();
            break;
          }
          case 80: {
            CKGDAHDGDIJ = input.ReadBool();
            break;
          }
          case 96: {
            BaseAvatarId = input.ReadUInt32();
            break;
          }
          case 112: {
            UseAvatarType = (global::EggLink.DanhengServer.Proto.AvatarType) input.ReadEnum();
            break;
          }
          case 120: {
            OptionalRewardId = input.ReadUInt32();
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
