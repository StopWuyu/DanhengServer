// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueModifierSelectInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueModifierSelectInfo.proto</summary>
  public static partial class ChessRogueModifierSelectInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueModifierSelectInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueModifierSelectInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJDaGVzc1JvZ3VlTW9kaWZpZXJTZWxlY3RJbmZvLnByb3RvIl0KHENoZXNz",
            "Um9ndWVNb2RpZmllclNlbGVjdEluZm8SEwoLSEpIRE9IT0xHQlAYBiABKA0S",
            "EwoLRk1PTEdQRVBMSkcYCiABKAgSEwoLTkhDSUdJUEFNSUsYASADKA1CHqoC",
            "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueModifierSelectInfo), global::EggLink.DanhengServer.Proto.ChessRogueModifierSelectInfo.Parser, new[]{ "HJHDOHOLGBP", "FMOLGPEPLJG", "NHCIGIPAMIK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueModifierSelectInfo : pb::IMessage<ChessRogueModifierSelectInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueModifierSelectInfo> _parser = new pb::MessageParser<ChessRogueModifierSelectInfo>(() => new ChessRogueModifierSelectInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueModifierSelectInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueModifierSelectInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueModifierSelectInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueModifierSelectInfo(ChessRogueModifierSelectInfo other) : this() {
      hJHDOHOLGBP_ = other.hJHDOHOLGBP_;
      fMOLGPEPLJG_ = other.fMOLGPEPLJG_;
      nHCIGIPAMIK_ = other.nHCIGIPAMIK_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueModifierSelectInfo Clone() {
      return new ChessRogueModifierSelectInfo(this);
    }

    /// <summary>Field number for the "HJHDOHOLGBP" field.</summary>
    public const int HJHDOHOLGBPFieldNumber = 6;
    private uint hJHDOHOLGBP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HJHDOHOLGBP {
      get { return hJHDOHOLGBP_; }
      set {
        hJHDOHOLGBP_ = value;
      }
    }

    /// <summary>Field number for the "FMOLGPEPLJG" field.</summary>
    public const int FMOLGPEPLJGFieldNumber = 10;
    private bool fMOLGPEPLJG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool FMOLGPEPLJG {
      get { return fMOLGPEPLJG_; }
      set {
        fMOLGPEPLJG_ = value;
      }
    }

    /// <summary>Field number for the "NHCIGIPAMIK" field.</summary>
    public const int NHCIGIPAMIKFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_nHCIGIPAMIK_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> nHCIGIPAMIK_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> NHCIGIPAMIK {
      get { return nHCIGIPAMIK_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueModifierSelectInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueModifierSelectInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HJHDOHOLGBP != other.HJHDOHOLGBP) return false;
      if (FMOLGPEPLJG != other.FMOLGPEPLJG) return false;
      if(!nHCIGIPAMIK_.Equals(other.nHCIGIPAMIK_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HJHDOHOLGBP != 0) hash ^= HJHDOHOLGBP.GetHashCode();
      if (FMOLGPEPLJG != false) hash ^= FMOLGPEPLJG.GetHashCode();
      hash ^= nHCIGIPAMIK_.GetHashCode();
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
      nHCIGIPAMIK_.WriteTo(output, _repeated_nHCIGIPAMIK_codec);
      if (HJHDOHOLGBP != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(HJHDOHOLGBP);
      }
      if (FMOLGPEPLJG != false) {
        output.WriteRawTag(80);
        output.WriteBool(FMOLGPEPLJG);
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
      nHCIGIPAMIK_.WriteTo(ref output, _repeated_nHCIGIPAMIK_codec);
      if (HJHDOHOLGBP != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(HJHDOHOLGBP);
      }
      if (FMOLGPEPLJG != false) {
        output.WriteRawTag(80);
        output.WriteBool(FMOLGPEPLJG);
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
      if (HJHDOHOLGBP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HJHDOHOLGBP);
      }
      if (FMOLGPEPLJG != false) {
        size += 1 + 1;
      }
      size += nHCIGIPAMIK_.CalculateSize(_repeated_nHCIGIPAMIK_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueModifierSelectInfo other) {
      if (other == null) {
        return;
      }
      if (other.HJHDOHOLGBP != 0) {
        HJHDOHOLGBP = other.HJHDOHOLGBP;
      }
      if (other.FMOLGPEPLJG != false) {
        FMOLGPEPLJG = other.FMOLGPEPLJG;
      }
      nHCIGIPAMIK_.Add(other.nHCIGIPAMIK_);
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
          case 10:
          case 8: {
            nHCIGIPAMIK_.AddEntriesFrom(input, _repeated_nHCIGIPAMIK_codec);
            break;
          }
          case 48: {
            HJHDOHOLGBP = input.ReadUInt32();
            break;
          }
          case 80: {
            FMOLGPEPLJG = input.ReadBool();
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
          case 10:
          case 8: {
            nHCIGIPAMIK_.AddEntriesFrom(ref input, _repeated_nHCIGIPAMIK_codec);
            break;
          }
          case 48: {
            HJHDOHOLGBP = input.ReadUInt32();
            break;
          }
          case 80: {
            FMOLGPEPLJG = input.ReadBool();
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
