// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueMiracleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueMiracleInfo.proto</summary>
  public static partial class RogueMiracleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueMiracleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueMiracleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZSb2d1ZU1pcmFjbGVJbmZvLnByb3RvGhJSb2d1ZU1pcmFjbGUucHJvdG8i",
            "bAoQUm9ndWVNaXJhY2xlSW5mbxIYChB0b3RhbF9zbG90X2NvdW50GAogASgN",
            "EhkKEXVubG9ja19zbG90X2NvdW50GAkgASgNEiMKDG1pcmFjbGVfbGlzdBgO",
            "IAMoCzINLlJvZ3VlTWlyYWNsZUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueMiracleReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueMiracleInfo), global::EggLink.DanhengServer.Proto.RogueMiracleInfo.Parser, new[]{ "TotalSlotCount", "UnlockSlotCount", "MiracleList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueMiracleInfo : pb::IMessage<RogueMiracleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueMiracleInfo> _parser = new pb::MessageParser<RogueMiracleInfo>(() => new RogueMiracleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueMiracleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueMiracleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMiracleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMiracleInfo(RogueMiracleInfo other) : this() {
      totalSlotCount_ = other.totalSlotCount_;
      unlockSlotCount_ = other.unlockSlotCount_;
      miracleList_ = other.miracleList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMiracleInfo Clone() {
      return new RogueMiracleInfo(this);
    }

    /// <summary>Field number for the "total_slot_count" field.</summary>
    public const int TotalSlotCountFieldNumber = 10;
    private uint totalSlotCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalSlotCount {
      get { return totalSlotCount_; }
      set {
        totalSlotCount_ = value;
      }
    }

    /// <summary>Field number for the "unlock_slot_count" field.</summary>
    public const int UnlockSlotCountFieldNumber = 9;
    private uint unlockSlotCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UnlockSlotCount {
      get { return unlockSlotCount_; }
      set {
        unlockSlotCount_ = value;
      }
    }

    /// <summary>Field number for the "miracle_list" field.</summary>
    public const int MiracleListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueMiracle> _repeated_miracleList_codec
        = pb::FieldCodec.ForMessage(114, global::EggLink.DanhengServer.Proto.RogueMiracle.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueMiracle> miracleList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueMiracle>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueMiracle> MiracleList {
      get { return miracleList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueMiracleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueMiracleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TotalSlotCount != other.TotalSlotCount) return false;
      if (UnlockSlotCount != other.UnlockSlotCount) return false;
      if(!miracleList_.Equals(other.miracleList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TotalSlotCount != 0) hash ^= TotalSlotCount.GetHashCode();
      if (UnlockSlotCount != 0) hash ^= UnlockSlotCount.GetHashCode();
      hash ^= miracleList_.GetHashCode();
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
      if (UnlockSlotCount != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(UnlockSlotCount);
      }
      if (TotalSlotCount != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(TotalSlotCount);
      }
      miracleList_.WriteTo(output, _repeated_miracleList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (UnlockSlotCount != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(UnlockSlotCount);
      }
      if (TotalSlotCount != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(TotalSlotCount);
      }
      miracleList_.WriteTo(ref output, _repeated_miracleList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (TotalSlotCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalSlotCount);
      }
      if (UnlockSlotCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UnlockSlotCount);
      }
      size += miracleList_.CalculateSize(_repeated_miracleList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueMiracleInfo other) {
      if (other == null) {
        return;
      }
      if (other.TotalSlotCount != 0) {
        TotalSlotCount = other.TotalSlotCount;
      }
      if (other.UnlockSlotCount != 0) {
        UnlockSlotCount = other.UnlockSlotCount;
      }
      miracleList_.Add(other.miracleList_);
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
          case 72: {
            UnlockSlotCount = input.ReadUInt32();
            break;
          }
          case 80: {
            TotalSlotCount = input.ReadUInt32();
            break;
          }
          case 114: {
            miracleList_.AddEntriesFrom(input, _repeated_miracleList_codec);
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
          case 72: {
            UnlockSlotCount = input.ReadUInt32();
            break;
          }
          case 80: {
            TotalSlotCount = input.ReadUInt32();
            break;
          }
          case 114: {
            miracleList_.AddEntriesFrom(ref input, _repeated_miracleList_codec);
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
