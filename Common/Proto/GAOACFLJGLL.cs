// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GAOACFLJGLL.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GAOACFLJGLL.proto</summary>
  public static partial class GAOACFLJGLLReflection {

    #region Descriptor
    /// <summary>File descriptor for GAOACFLJGLL.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GAOACFLJGLLReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFHQU9BQ0ZMSkdMTC5wcm90byJZCgtHQU9BQ0ZMSkdMTBIQCghza2lsbF9p",
            "ZBgBIAEoDRITCgtOTEFKT0xGTUhNRBgCIAEoARITCgtLRUdPTkZCRk9LSRgD",
            "IAMoDRIOCgZkYW1hZ2UYBCABKAFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
            "ci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GAOACFLJGLL), global::EggLink.DanhengServer.Proto.GAOACFLJGLL.Parser, new[]{ "SkillId", "NLAJOLFMHMD", "KEGONFBFOKI", "Damage" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GAOACFLJGLL : pb::IMessage<GAOACFLJGLL>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GAOACFLJGLL> _parser = new pb::MessageParser<GAOACFLJGLL>(() => new GAOACFLJGLL());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GAOACFLJGLL> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GAOACFLJGLLReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GAOACFLJGLL() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GAOACFLJGLL(GAOACFLJGLL other) : this() {
      skillId_ = other.skillId_;
      nLAJOLFMHMD_ = other.nLAJOLFMHMD_;
      kEGONFBFOKI_ = other.kEGONFBFOKI_.Clone();
      damage_ = other.damage_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GAOACFLJGLL Clone() {
      return new GAOACFLJGLL(this);
    }

    /// <summary>Field number for the "skill_id" field.</summary>
    public const int SkillIdFieldNumber = 1;
    private uint skillId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillId {
      get { return skillId_; }
      set {
        skillId_ = value;
      }
    }

    /// <summary>Field number for the "NLAJOLFMHMD" field.</summary>
    public const int NLAJOLFMHMDFieldNumber = 2;
    private double nLAJOLFMHMD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double NLAJOLFMHMD {
      get { return nLAJOLFMHMD_; }
      set {
        nLAJOLFMHMD_ = value;
      }
    }

    /// <summary>Field number for the "KEGONFBFOKI" field.</summary>
    public const int KEGONFBFOKIFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_kEGONFBFOKI_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> kEGONFBFOKI_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> KEGONFBFOKI {
      get { return kEGONFBFOKI_; }
    }

    /// <summary>Field number for the "damage" field.</summary>
    public const int DamageFieldNumber = 4;
    private double damage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Damage {
      get { return damage_; }
      set {
        damage_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GAOACFLJGLL);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GAOACFLJGLL other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SkillId != other.SkillId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(NLAJOLFMHMD, other.NLAJOLFMHMD)) return false;
      if(!kEGONFBFOKI_.Equals(other.kEGONFBFOKI_)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Damage, other.Damage)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SkillId != 0) hash ^= SkillId.GetHashCode();
      if (NLAJOLFMHMD != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(NLAJOLFMHMD);
      hash ^= kEGONFBFOKI_.GetHashCode();
      if (Damage != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Damage);
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
      if (SkillId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(SkillId);
      }
      if (NLAJOLFMHMD != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(NLAJOLFMHMD);
      }
      kEGONFBFOKI_.WriteTo(output, _repeated_kEGONFBFOKI_codec);
      if (Damage != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Damage);
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
      if (SkillId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(SkillId);
      }
      if (NLAJOLFMHMD != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(NLAJOLFMHMD);
      }
      kEGONFBFOKI_.WriteTo(ref output, _repeated_kEGONFBFOKI_codec);
      if (Damage != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Damage);
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
      if (SkillId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillId);
      }
      if (NLAJOLFMHMD != 0D) {
        size += 1 + 8;
      }
      size += kEGONFBFOKI_.CalculateSize(_repeated_kEGONFBFOKI_codec);
      if (Damage != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GAOACFLJGLL other) {
      if (other == null) {
        return;
      }
      if (other.SkillId != 0) {
        SkillId = other.SkillId;
      }
      if (other.NLAJOLFMHMD != 0D) {
        NLAJOLFMHMD = other.NLAJOLFMHMD;
      }
      kEGONFBFOKI_.Add(other.kEGONFBFOKI_);
      if (other.Damage != 0D) {
        Damage = other.Damage;
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
            SkillId = input.ReadUInt32();
            break;
          }
          case 17: {
            NLAJOLFMHMD = input.ReadDouble();
            break;
          }
          case 26:
          case 24: {
            kEGONFBFOKI_.AddEntriesFrom(input, _repeated_kEGONFBFOKI_codec);
            break;
          }
          case 33: {
            Damage = input.ReadDouble();
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
            SkillId = input.ReadUInt32();
            break;
          }
          case 17: {
            NLAJOLFMHMD = input.ReadDouble();
            break;
          }
          case 26:
          case 24: {
            kEGONFBFOKI_.AddEntriesFrom(ref input, _repeated_kEGONFBFOKI_codec);
            break;
          }
          case 33: {
            Damage = input.ReadDouble();
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
