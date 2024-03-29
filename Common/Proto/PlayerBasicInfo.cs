// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerBasicInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerBasicInfo.proto</summary>
  public static partial class PlayerBasicInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerBasicInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerBasicInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQbGF5ZXJCYXNpY0luZm8ucHJvdG8ikgEKD1BsYXllckJhc2ljSW5mbxIQ",
            "CghuaWNrbmFtZRgBIAEoCRINCgVsZXZlbBgCIAEoDRILCgNleHAYAyABKA0S",
            "DwoHc3RhbWluYRgEIAEoDRINCgVtY29pbhgFIAEoDRINCgVoY29pbhgGIAEo",
            "DRINCgVzY29pbhgHIAEoDRITCgt3b3JsZF9sZXZlbBgIIAEoDUIeqgIbRWdn",
            "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerBasicInfo), global::EggLink.DanhengServer.Proto.PlayerBasicInfo.Parser, new[]{ "Nickname", "Level", "Exp", "Stamina", "Mcoin", "Hcoin", "Scoin", "WorldLevel" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerBasicInfo : pb::IMessage<PlayerBasicInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerBasicInfo> _parser = new pb::MessageParser<PlayerBasicInfo>(() => new PlayerBasicInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerBasicInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerBasicInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerBasicInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerBasicInfo(PlayerBasicInfo other) : this() {
      nickname_ = other.nickname_;
      level_ = other.level_;
      exp_ = other.exp_;
      stamina_ = other.stamina_;
      mcoin_ = other.mcoin_;
      hcoin_ = other.hcoin_;
      scoin_ = other.scoin_;
      worldLevel_ = other.worldLevel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerBasicInfo Clone() {
      return new PlayerBasicInfo(this);
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 1;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 2;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 3;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "stamina" field.</summary>
    public const int StaminaFieldNumber = 4;
    private uint stamina_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Stamina {
      get { return stamina_; }
      set {
        stamina_ = value;
      }
    }

    /// <summary>Field number for the "mcoin" field.</summary>
    public const int McoinFieldNumber = 5;
    private uint mcoin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Mcoin {
      get { return mcoin_; }
      set {
        mcoin_ = value;
      }
    }

    /// <summary>Field number for the "hcoin" field.</summary>
    public const int HcoinFieldNumber = 6;
    private uint hcoin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Hcoin {
      get { return hcoin_; }
      set {
        hcoin_ = value;
      }
    }

    /// <summary>Field number for the "scoin" field.</summary>
    public const int ScoinFieldNumber = 7;
    private uint scoin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Scoin {
      get { return scoin_; }
      set {
        scoin_ = value;
      }
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 8;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerBasicInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerBasicInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Nickname != other.Nickname) return false;
      if (Level != other.Level) return false;
      if (Exp != other.Exp) return false;
      if (Stamina != other.Stamina) return false;
      if (Mcoin != other.Mcoin) return false;
      if (Hcoin != other.Hcoin) return false;
      if (Scoin != other.Scoin) return false;
      if (WorldLevel != other.WorldLevel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (Stamina != 0) hash ^= Stamina.GetHashCode();
      if (Mcoin != 0) hash ^= Mcoin.GetHashCode();
      if (Hcoin != 0) hash ^= Hcoin.GetHashCode();
      if (Scoin != 0) hash ^= Scoin.GetHashCode();
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
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
      if (Nickname.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Nickname);
      }
      if (Level != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Level);
      }
      if (Exp != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Exp);
      }
      if (Stamina != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Stamina);
      }
      if (Mcoin != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Mcoin);
      }
      if (Hcoin != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Hcoin);
      }
      if (Scoin != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Scoin);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(WorldLevel);
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
      if (Nickname.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Nickname);
      }
      if (Level != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Level);
      }
      if (Exp != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Exp);
      }
      if (Stamina != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Stamina);
      }
      if (Mcoin != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Mcoin);
      }
      if (Hcoin != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Hcoin);
      }
      if (Scoin != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Scoin);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(WorldLevel);
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
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (Stamina != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Stamina);
      }
      if (Mcoin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Mcoin);
      }
      if (Hcoin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Hcoin);
      }
      if (Scoin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Scoin);
      }
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerBasicInfo other) {
      if (other == null) {
        return;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.Stamina != 0) {
        Stamina = other.Stamina;
      }
      if (other.Mcoin != 0) {
        Mcoin = other.Mcoin;
      }
      if (other.Hcoin != 0) {
        Hcoin = other.Hcoin;
      }
      if (other.Scoin != 0) {
        Scoin = other.Scoin;
      }
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
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
          case 10: {
            Nickname = input.ReadString();
            break;
          }
          case 16: {
            Level = input.ReadUInt32();
            break;
          }
          case 24: {
            Exp = input.ReadUInt32();
            break;
          }
          case 32: {
            Stamina = input.ReadUInt32();
            break;
          }
          case 40: {
            Mcoin = input.ReadUInt32();
            break;
          }
          case 48: {
            Hcoin = input.ReadUInt32();
            break;
          }
          case 56: {
            Scoin = input.ReadUInt32();
            break;
          }
          case 64: {
            WorldLevel = input.ReadUInt32();
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
          case 10: {
            Nickname = input.ReadString();
            break;
          }
          case 16: {
            Level = input.ReadUInt32();
            break;
          }
          case 24: {
            Exp = input.ReadUInt32();
            break;
          }
          case 32: {
            Stamina = input.ReadUInt32();
            break;
          }
          case 40: {
            Mcoin = input.ReadUInt32();
            break;
          }
          case 48: {
            Hcoin = input.ReadUInt32();
            break;
          }
          case 56: {
            Scoin = input.ReadUInt32();
            break;
          }
          case 64: {
            WorldLevel = input.ReadUInt32();
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
