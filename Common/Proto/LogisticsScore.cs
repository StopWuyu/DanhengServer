// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LogisticsScore.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from LogisticsScore.proto</summary>
  public static partial class LogisticsScoreReflection {

    #region Descriptor
    /// <summary>File descriptor for LogisticsScore.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LogisticsScoreReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRMb2dpc3RpY3NTY29yZS5wcm90bxoOSXRlbUxpc3QucHJvdG8iowEKDkxv",
            "Z2lzdGljc1Njb3JlEhQKDHVubG9ja19sZXZlbBgBIAEoDRIOCgZtYXBfaWQY",
            "DCABKA0SGQoGcmV3YXJkGAogASgLMgkuSXRlbUxpc3QSFgoObGFzdF9tYXhf",
            "c2NvcmUYAiABKA0SEgoKbGFzdF9sZXZlbBgGIAEoDRIRCgljdXJfc2NvcmUY",
            "DyABKA0SEQoJbWF4X3Njb3JlGA4gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.LogisticsScore), global::EggLink.DanhengServer.Proto.LogisticsScore.Parser, new[]{ "UnlockLevel", "MapId", "Reward", "LastMaxScore", "LastLevel", "CurScore", "MaxScore" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LogisticsScore : pb::IMessage<LogisticsScore>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LogisticsScore> _parser = new pb::MessageParser<LogisticsScore>(() => new LogisticsScore());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LogisticsScore> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.LogisticsScoreReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogisticsScore() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogisticsScore(LogisticsScore other) : this() {
      unlockLevel_ = other.unlockLevel_;
      mapId_ = other.mapId_;
      reward_ = other.reward_ != null ? other.reward_.Clone() : null;
      lastMaxScore_ = other.lastMaxScore_;
      lastLevel_ = other.lastLevel_;
      curScore_ = other.curScore_;
      maxScore_ = other.maxScore_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogisticsScore Clone() {
      return new LogisticsScore(this);
    }

    /// <summary>Field number for the "unlock_level" field.</summary>
    public const int UnlockLevelFieldNumber = 1;
    private uint unlockLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UnlockLevel {
      get { return unlockLevel_; }
      set {
        unlockLevel_ = value;
      }
    }

    /// <summary>Field number for the "map_id" field.</summary>
    public const int MapIdFieldNumber = 12;
    private uint mapId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MapId {
      get { return mapId_; }
      set {
        mapId_ = value;
      }
    }

    /// <summary>Field number for the "reward" field.</summary>
    public const int RewardFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.ItemList reward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Reward {
      get { return reward_; }
      set {
        reward_ = value;
      }
    }

    /// <summary>Field number for the "last_max_score" field.</summary>
    public const int LastMaxScoreFieldNumber = 2;
    private uint lastMaxScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LastMaxScore {
      get { return lastMaxScore_; }
      set {
        lastMaxScore_ = value;
      }
    }

    /// <summary>Field number for the "last_level" field.</summary>
    public const int LastLevelFieldNumber = 6;
    private uint lastLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LastLevel {
      get { return lastLevel_; }
      set {
        lastLevel_ = value;
      }
    }

    /// <summary>Field number for the "cur_score" field.</summary>
    public const int CurScoreFieldNumber = 15;
    private uint curScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurScore {
      get { return curScore_; }
      set {
        curScore_ = value;
      }
    }

    /// <summary>Field number for the "max_score" field.</summary>
    public const int MaxScoreFieldNumber = 14;
    private uint maxScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxScore {
      get { return maxScore_; }
      set {
        maxScore_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LogisticsScore);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LogisticsScore other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UnlockLevel != other.UnlockLevel) return false;
      if (MapId != other.MapId) return false;
      if (!object.Equals(Reward, other.Reward)) return false;
      if (LastMaxScore != other.LastMaxScore) return false;
      if (LastLevel != other.LastLevel) return false;
      if (CurScore != other.CurScore) return false;
      if (MaxScore != other.MaxScore) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (UnlockLevel != 0) hash ^= UnlockLevel.GetHashCode();
      if (MapId != 0) hash ^= MapId.GetHashCode();
      if (reward_ != null) hash ^= Reward.GetHashCode();
      if (LastMaxScore != 0) hash ^= LastMaxScore.GetHashCode();
      if (LastLevel != 0) hash ^= LastLevel.GetHashCode();
      if (CurScore != 0) hash ^= CurScore.GetHashCode();
      if (MaxScore != 0) hash ^= MaxScore.GetHashCode();
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
      if (UnlockLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(UnlockLevel);
      }
      if (LastMaxScore != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LastMaxScore);
      }
      if (LastLevel != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(LastLevel);
      }
      if (reward_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Reward);
      }
      if (MapId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MapId);
      }
      if (MaxScore != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MaxScore);
      }
      if (CurScore != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CurScore);
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
      if (UnlockLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(UnlockLevel);
      }
      if (LastMaxScore != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LastMaxScore);
      }
      if (LastLevel != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(LastLevel);
      }
      if (reward_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Reward);
      }
      if (MapId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MapId);
      }
      if (MaxScore != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MaxScore);
      }
      if (CurScore != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CurScore);
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
      if (UnlockLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UnlockLevel);
      }
      if (MapId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MapId);
      }
      if (reward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reward);
      }
      if (LastMaxScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LastMaxScore);
      }
      if (LastLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LastLevel);
      }
      if (CurScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurScore);
      }
      if (MaxScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxScore);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LogisticsScore other) {
      if (other == null) {
        return;
      }
      if (other.UnlockLevel != 0) {
        UnlockLevel = other.UnlockLevel;
      }
      if (other.MapId != 0) {
        MapId = other.MapId;
      }
      if (other.reward_ != null) {
        if (reward_ == null) {
          Reward = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Reward.MergeFrom(other.Reward);
      }
      if (other.LastMaxScore != 0) {
        LastMaxScore = other.LastMaxScore;
      }
      if (other.LastLevel != 0) {
        LastLevel = other.LastLevel;
      }
      if (other.CurScore != 0) {
        CurScore = other.CurScore;
      }
      if (other.MaxScore != 0) {
        MaxScore = other.MaxScore;
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
            UnlockLevel = input.ReadUInt32();
            break;
          }
          case 16: {
            LastMaxScore = input.ReadUInt32();
            break;
          }
          case 48: {
            LastLevel = input.ReadUInt32();
            break;
          }
          case 82: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 96: {
            MapId = input.ReadUInt32();
            break;
          }
          case 112: {
            MaxScore = input.ReadUInt32();
            break;
          }
          case 120: {
            CurScore = input.ReadUInt32();
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
            UnlockLevel = input.ReadUInt32();
            break;
          }
          case 16: {
            LastMaxScore = input.ReadUInt32();
            break;
          }
          case 48: {
            LastLevel = input.ReadUInt32();
            break;
          }
          case 82: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
            break;
          }
          case 96: {
            MapId = input.ReadUInt32();
            break;
          }
          case 112: {
            MaxScore = input.ReadUInt32();
            break;
          }
          case 120: {
            CurScore = input.ReadUInt32();
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