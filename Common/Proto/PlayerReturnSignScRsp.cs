// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerReturnSignScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerReturnSignScRsp.proto</summary>
  public static partial class PlayerReturnSignScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerReturnSignScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerReturnSignScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtQbGF5ZXJSZXR1cm5TaWduU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnByb3Rv",
            "InIKFVBsYXllclJldHVyblNpZ25TY1JzcBIPCgdyZXRjb2RlGAQgASgNEh4K",
            "C0pBT0ZOT1BIRVBJGAcgAygLMgkuSXRlbUxpc3QSEwoLS0NMSEJKQkROSUIY",
            "AiABKA0SEwoLRUdPTUhPTE5PRUwYBiADKA1CHqoCG0VnZ0xpbmsuRGFuaGVu",
            "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerReturnSignScRsp), global::EggLink.DanhengServer.Proto.PlayerReturnSignScRsp.Parser, new[]{ "Retcode", "JAOFNOPHEPI", "KCLHBJBDNIB", "EGOMHOLNOEL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerReturnSignScRsp : pb::IMessage<PlayerReturnSignScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerReturnSignScRsp> _parser = new pb::MessageParser<PlayerReturnSignScRsp>(() => new PlayerReturnSignScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerReturnSignScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerReturnSignScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnSignScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnSignScRsp(PlayerReturnSignScRsp other) : this() {
      retcode_ = other.retcode_;
      jAOFNOPHEPI_ = other.jAOFNOPHEPI_.Clone();
      kCLHBJBDNIB_ = other.kCLHBJBDNIB_;
      eGOMHOLNOEL_ = other.eGOMHOLNOEL_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReturnSignScRsp Clone() {
      return new PlayerReturnSignScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 4;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "JAOFNOPHEPI" field.</summary>
    public const int JAOFNOPHEPIFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ItemList> _repeated_jAOFNOPHEPI_codec
        = pb::FieldCodec.ForMessage(58, global::EggLink.DanhengServer.Proto.ItemList.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ItemList> jAOFNOPHEPI_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ItemList>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ItemList> JAOFNOPHEPI {
      get { return jAOFNOPHEPI_; }
    }

    /// <summary>Field number for the "KCLHBJBDNIB" field.</summary>
    public const int KCLHBJBDNIBFieldNumber = 2;
    private uint kCLHBJBDNIB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KCLHBJBDNIB {
      get { return kCLHBJBDNIB_; }
      set {
        kCLHBJBDNIB_ = value;
      }
    }

    /// <summary>Field number for the "EGOMHOLNOEL" field.</summary>
    public const int EGOMHOLNOELFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_eGOMHOLNOEL_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> eGOMHOLNOEL_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EGOMHOLNOEL {
      get { return eGOMHOLNOEL_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerReturnSignScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerReturnSignScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if(!jAOFNOPHEPI_.Equals(other.jAOFNOPHEPI_)) return false;
      if (KCLHBJBDNIB != other.KCLHBJBDNIB) return false;
      if(!eGOMHOLNOEL_.Equals(other.eGOMHOLNOEL_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= jAOFNOPHEPI_.GetHashCode();
      if (KCLHBJBDNIB != 0) hash ^= KCLHBJBDNIB.GetHashCode();
      hash ^= eGOMHOLNOEL_.GetHashCode();
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
      if (KCLHBJBDNIB != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(KCLHBJBDNIB);
      }
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      eGOMHOLNOEL_.WriteTo(output, _repeated_eGOMHOLNOEL_codec);
      jAOFNOPHEPI_.WriteTo(output, _repeated_jAOFNOPHEPI_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (KCLHBJBDNIB != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(KCLHBJBDNIB);
      }
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      eGOMHOLNOEL_.WriteTo(ref output, _repeated_eGOMHOLNOEL_codec);
      jAOFNOPHEPI_.WriteTo(ref output, _repeated_jAOFNOPHEPI_codec);
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
      size += jAOFNOPHEPI_.CalculateSize(_repeated_jAOFNOPHEPI_codec);
      if (KCLHBJBDNIB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KCLHBJBDNIB);
      }
      size += eGOMHOLNOEL_.CalculateSize(_repeated_eGOMHOLNOEL_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerReturnSignScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      jAOFNOPHEPI_.Add(other.jAOFNOPHEPI_);
      if (other.KCLHBJBDNIB != 0) {
        KCLHBJBDNIB = other.KCLHBJBDNIB;
      }
      eGOMHOLNOEL_.Add(other.eGOMHOLNOEL_);
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
            KCLHBJBDNIB = input.ReadUInt32();
            break;
          }
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            eGOMHOLNOEL_.AddEntriesFrom(input, _repeated_eGOMHOLNOEL_codec);
            break;
          }
          case 58: {
            jAOFNOPHEPI_.AddEntriesFrom(input, _repeated_jAOFNOPHEPI_codec);
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
            KCLHBJBDNIB = input.ReadUInt32();
            break;
          }
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            eGOMHOLNOEL_.AddEntriesFrom(ref input, _repeated_eGOMHOLNOEL_codec);
            break;
          }
          case 58: {
            jAOFNOPHEPI_.AddEntriesFrom(ref input, _repeated_jAOFNOPHEPI_codec);
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
