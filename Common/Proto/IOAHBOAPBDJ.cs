// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IOAHBOAPBDJ.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from IOAHBOAPBDJ.proto</summary>
  public static partial class IOAHBOAPBDJReflection {

    #region Descriptor
    /// <summary>File descriptor for IOAHBOAPBDJ.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IOAHBOAPBDJReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFJT0FIQk9BUEJESi5wcm90bxoYUm9ndWVNaXJhY2xlRWZmZWN0LnByb3Rv",
            "GhFSb2d1ZVN0YXR1cy5wcm90bxoTUm9ndWVCdWZmSW5mby5wcm90byKBAgoL",
            "SU9BSEJPQVBCREoSIgoKcm9ndWVfYnVmZhgFIAEoCzIOLlJvZ3VlQnVmZklu",
            "Zm8SEwoLSEdCTkJMTElFRU8YAyABKA0SEwoLS0pNTkxPSE9IQ0kYCyABKA0S",
            "KAoLZWZmZWN0X2luZm8YBiABKAsyEy5Sb2d1ZU1pcmFjbGVFZmZlY3QSGwoT",
            "YmFzZV9hdmF0YXJfaWRfbGlzdBgMIAMoDRITCgtKUE1CRUhPRkNNRhgKIAMo",
            "DRIOCgZtYXBfaWQYDyABKA0SHAoGc3RhdHVzGAIgASgOMgwuUm9ndWVTdGF0",
            "dXMSGgoSY3VyX3JlYWNoX3Jvb21fbnVtGAkgASgNQh6qAhtFZ2dMaW5rLkRh",
            "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueMiracleEffectReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueBuffInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.IOAHBOAPBDJ), global::EggLink.DanhengServer.Proto.IOAHBOAPBDJ.Parser, new[]{ "RogueBuff", "HGBNBLLIEEO", "KJMNLOHOHCI", "EffectInfo", "BaseAvatarIdList", "JPMBEHOFCMF", "MapId", "Status", "CurReachRoomNum" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class IOAHBOAPBDJ : pb::IMessage<IOAHBOAPBDJ>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IOAHBOAPBDJ> _parser = new pb::MessageParser<IOAHBOAPBDJ>(() => new IOAHBOAPBDJ());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IOAHBOAPBDJ> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.IOAHBOAPBDJReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IOAHBOAPBDJ() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IOAHBOAPBDJ(IOAHBOAPBDJ other) : this() {
      rogueBuff_ = other.rogueBuff_ != null ? other.rogueBuff_.Clone() : null;
      hGBNBLLIEEO_ = other.hGBNBLLIEEO_;
      kJMNLOHOHCI_ = other.kJMNLOHOHCI_;
      effectInfo_ = other.effectInfo_ != null ? other.effectInfo_.Clone() : null;
      baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
      jPMBEHOFCMF_ = other.jPMBEHOFCMF_.Clone();
      mapId_ = other.mapId_;
      status_ = other.status_;
      curReachRoomNum_ = other.curReachRoomNum_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IOAHBOAPBDJ Clone() {
      return new IOAHBOAPBDJ(this);
    }

    /// <summary>Field number for the "rogue_buff" field.</summary>
    public const int RogueBuffFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.RogueBuffInfo rogueBuff_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueBuffInfo RogueBuff {
      get { return rogueBuff_; }
      set {
        rogueBuff_ = value;
      }
    }

    /// <summary>Field number for the "HGBNBLLIEEO" field.</summary>
    public const int HGBNBLLIEEOFieldNumber = 3;
    private uint hGBNBLLIEEO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HGBNBLLIEEO {
      get { return hGBNBLLIEEO_; }
      set {
        hGBNBLLIEEO_ = value;
      }
    }

    /// <summary>Field number for the "KJMNLOHOHCI" field.</summary>
    public const int KJMNLOHOHCIFieldNumber = 11;
    private uint kJMNLOHOHCI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KJMNLOHOHCI {
      get { return kJMNLOHOHCI_; }
      set {
        kJMNLOHOHCI_ = value;
      }
    }

    /// <summary>Field number for the "effect_info" field.</summary>
    public const int EffectInfoFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.RogueMiracleEffect effectInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueMiracleEffect EffectInfo {
      get { return effectInfo_; }
      set {
        effectInfo_ = value;
      }
    }

    /// <summary>Field number for the "base_avatar_id_list" field.</summary>
    public const int BaseAvatarIdListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_baseAvatarIdList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> baseAvatarIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BaseAvatarIdList {
      get { return baseAvatarIdList_; }
    }

    /// <summary>Field number for the "JPMBEHOFCMF" field.</summary>
    public const int JPMBEHOFCMFFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_jPMBEHOFCMF_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> jPMBEHOFCMF_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> JPMBEHOFCMF {
      get { return jPMBEHOFCMF_; }
    }

    /// <summary>Field number for the "map_id" field.</summary>
    public const int MapIdFieldNumber = 15;
    private uint mapId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MapId {
      get { return mapId_; }
      set {
        mapId_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.RogueStatus status_ = global::EggLink.DanhengServer.Proto.RogueStatus.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "cur_reach_room_num" field.</summary>
    public const int CurReachRoomNumFieldNumber = 9;
    private uint curReachRoomNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurReachRoomNum {
      get { return curReachRoomNum_; }
      set {
        curReachRoomNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as IOAHBOAPBDJ);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IOAHBOAPBDJ other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueBuff, other.RogueBuff)) return false;
      if (HGBNBLLIEEO != other.HGBNBLLIEEO) return false;
      if (KJMNLOHOHCI != other.KJMNLOHOHCI) return false;
      if (!object.Equals(EffectInfo, other.EffectInfo)) return false;
      if(!baseAvatarIdList_.Equals(other.baseAvatarIdList_)) return false;
      if(!jPMBEHOFCMF_.Equals(other.jPMBEHOFCMF_)) return false;
      if (MapId != other.MapId) return false;
      if (Status != other.Status) return false;
      if (CurReachRoomNum != other.CurReachRoomNum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueBuff_ != null) hash ^= RogueBuff.GetHashCode();
      if (HGBNBLLIEEO != 0) hash ^= HGBNBLLIEEO.GetHashCode();
      if (KJMNLOHOHCI != 0) hash ^= KJMNLOHOHCI.GetHashCode();
      if (effectInfo_ != null) hash ^= EffectInfo.GetHashCode();
      hash ^= baseAvatarIdList_.GetHashCode();
      hash ^= jPMBEHOFCMF_.GetHashCode();
      if (MapId != 0) hash ^= MapId.GetHashCode();
      if (Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) hash ^= Status.GetHashCode();
      if (CurReachRoomNum != 0) hash ^= CurReachRoomNum.GetHashCode();
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
      if (Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Status);
      }
      if (HGBNBLLIEEO != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(HGBNBLLIEEO);
      }
      if (rogueBuff_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(RogueBuff);
      }
      if (effectInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(EffectInfo);
      }
      if (CurReachRoomNum != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CurReachRoomNum);
      }
      jPMBEHOFCMF_.WriteTo(output, _repeated_jPMBEHOFCMF_codec);
      if (KJMNLOHOHCI != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(KJMNLOHOHCI);
      }
      baseAvatarIdList_.WriteTo(output, _repeated_baseAvatarIdList_codec);
      if (MapId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MapId);
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
      if (Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Status);
      }
      if (HGBNBLLIEEO != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(HGBNBLLIEEO);
      }
      if (rogueBuff_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(RogueBuff);
      }
      if (effectInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(EffectInfo);
      }
      if (CurReachRoomNum != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CurReachRoomNum);
      }
      jPMBEHOFCMF_.WriteTo(ref output, _repeated_jPMBEHOFCMF_codec);
      if (KJMNLOHOHCI != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(KJMNLOHOHCI);
      }
      baseAvatarIdList_.WriteTo(ref output, _repeated_baseAvatarIdList_codec);
      if (MapId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MapId);
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
      if (rogueBuff_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueBuff);
      }
      if (HGBNBLLIEEO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HGBNBLLIEEO);
      }
      if (KJMNLOHOHCI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KJMNLOHOHCI);
      }
      if (effectInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EffectInfo);
      }
      size += baseAvatarIdList_.CalculateSize(_repeated_baseAvatarIdList_codec);
      size += jPMBEHOFCMF_.CalculateSize(_repeated_jPMBEHOFCMF_codec);
      if (MapId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MapId);
      }
      if (Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (CurReachRoomNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurReachRoomNum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IOAHBOAPBDJ other) {
      if (other == null) {
        return;
      }
      if (other.rogueBuff_ != null) {
        if (rogueBuff_ == null) {
          RogueBuff = new global::EggLink.DanhengServer.Proto.RogueBuffInfo();
        }
        RogueBuff.MergeFrom(other.RogueBuff);
      }
      if (other.HGBNBLLIEEO != 0) {
        HGBNBLLIEEO = other.HGBNBLLIEEO;
      }
      if (other.KJMNLOHOHCI != 0) {
        KJMNLOHOHCI = other.KJMNLOHOHCI;
      }
      if (other.effectInfo_ != null) {
        if (effectInfo_ == null) {
          EffectInfo = new global::EggLink.DanhengServer.Proto.RogueMiracleEffect();
        }
        EffectInfo.MergeFrom(other.EffectInfo);
      }
      baseAvatarIdList_.Add(other.baseAvatarIdList_);
      jPMBEHOFCMF_.Add(other.jPMBEHOFCMF_);
      if (other.MapId != 0) {
        MapId = other.MapId;
      }
      if (other.Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) {
        Status = other.Status;
      }
      if (other.CurReachRoomNum != 0) {
        CurReachRoomNum = other.CurReachRoomNum;
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
            Status = (global::EggLink.DanhengServer.Proto.RogueStatus) input.ReadEnum();
            break;
          }
          case 24: {
            HGBNBLLIEEO = input.ReadUInt32();
            break;
          }
          case 42: {
            if (rogueBuff_ == null) {
              RogueBuff = new global::EggLink.DanhengServer.Proto.RogueBuffInfo();
            }
            input.ReadMessage(RogueBuff);
            break;
          }
          case 50: {
            if (effectInfo_ == null) {
              EffectInfo = new global::EggLink.DanhengServer.Proto.RogueMiracleEffect();
            }
            input.ReadMessage(EffectInfo);
            break;
          }
          case 72: {
            CurReachRoomNum = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            jPMBEHOFCMF_.AddEntriesFrom(input, _repeated_jPMBEHOFCMF_codec);
            break;
          }
          case 88: {
            KJMNLOHOHCI = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            baseAvatarIdList_.AddEntriesFrom(input, _repeated_baseAvatarIdList_codec);
            break;
          }
          case 120: {
            MapId = input.ReadUInt32();
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
            Status = (global::EggLink.DanhengServer.Proto.RogueStatus) input.ReadEnum();
            break;
          }
          case 24: {
            HGBNBLLIEEO = input.ReadUInt32();
            break;
          }
          case 42: {
            if (rogueBuff_ == null) {
              RogueBuff = new global::EggLink.DanhengServer.Proto.RogueBuffInfo();
            }
            input.ReadMessage(RogueBuff);
            break;
          }
          case 50: {
            if (effectInfo_ == null) {
              EffectInfo = new global::EggLink.DanhengServer.Proto.RogueMiracleEffect();
            }
            input.ReadMessage(EffectInfo);
            break;
          }
          case 72: {
            CurReachRoomNum = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            jPMBEHOFCMF_.AddEntriesFrom(ref input, _repeated_jPMBEHOFCMF_codec);
            break;
          }
          case 88: {
            KJMNLOHOHCI = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            baseAvatarIdList_.AddEntriesFrom(ref input, _repeated_baseAvatarIdList_codec);
            break;
          }
          case 120: {
            MapId = input.ReadUInt32();
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