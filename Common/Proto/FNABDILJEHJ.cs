// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FNABDILJEHJ.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FNABDILJEHJ.proto</summary>
  public static partial class FNABDILJEHJReflection {

    #region Descriptor
    /// <summary>File descriptor for FNABDILJEHJ.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FNABDILJEHJReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFGTkFCRElMSkVISi5wcm90bxoUTG9naXN0aWNzU2NvcmUucHJvdG8aEURD",
            "SUVCSUJNS1BNLnByb3RvGhJMb2dpc3RpY3NNYXAucHJvdG8ijwEKC0ZOQUJE",
            "SUxKRUhKEhMKC0JPRUxFT0JKQ05EGAcgAygNEiQKC05EQk5CUE1NUElIGAog",
            "AygLMg8uTG9naXN0aWNzU2NvcmUSIgoLRUJGT0JNQVBKT04YAyADKAsyDS5M",
            "b2dpc3RpY3NNYXASIQoLRUhPSkJLS1BFSkwYASADKAsyDC5EQ0lFQklCTUtQ",
            "TUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.LogisticsScoreReflection.Descriptor, global::EggLink.DanhengServer.Proto.DCIEBIBMKPMReflection.Descriptor, global::EggLink.DanhengServer.Proto.LogisticsMapReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FNABDILJEHJ), global::EggLink.DanhengServer.Proto.FNABDILJEHJ.Parser, new[]{ "BOELEOBJCND", "NDBNBPMMPIH", "EBFOBMAPJON", "EHOJBKKPEJL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FNABDILJEHJ : pb::IMessage<FNABDILJEHJ>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FNABDILJEHJ> _parser = new pb::MessageParser<FNABDILJEHJ>(() => new FNABDILJEHJ());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FNABDILJEHJ> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FNABDILJEHJReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FNABDILJEHJ() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FNABDILJEHJ(FNABDILJEHJ other) : this() {
      bOELEOBJCND_ = other.bOELEOBJCND_.Clone();
      nDBNBPMMPIH_ = other.nDBNBPMMPIH_.Clone();
      eBFOBMAPJON_ = other.eBFOBMAPJON_.Clone();
      eHOJBKKPEJL_ = other.eHOJBKKPEJL_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FNABDILJEHJ Clone() {
      return new FNABDILJEHJ(this);
    }

    /// <summary>Field number for the "BOELEOBJCND" field.</summary>
    public const int BOELEOBJCNDFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_bOELEOBJCND_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> bOELEOBJCND_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BOELEOBJCND {
      get { return bOELEOBJCND_; }
    }

    /// <summary>Field number for the "NDBNBPMMPIH" field.</summary>
    public const int NDBNBPMMPIHFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.LogisticsScore> _repeated_nDBNBPMMPIH_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.LogisticsScore.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LogisticsScore> nDBNBPMMPIH_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LogisticsScore>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LogisticsScore> NDBNBPMMPIH {
      get { return nDBNBPMMPIH_; }
    }

    /// <summary>Field number for the "EBFOBMAPJON" field.</summary>
    public const int EBFOBMAPJONFieldNumber = 3;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.LogisticsMap> _repeated_eBFOBMAPJON_codec
        = pb::FieldCodec.ForMessage(26, global::EggLink.DanhengServer.Proto.LogisticsMap.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LogisticsMap> eBFOBMAPJON_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LogisticsMap>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LogisticsMap> EBFOBMAPJON {
      get { return eBFOBMAPJON_; }
    }

    /// <summary>Field number for the "EHOJBKKPEJL" field.</summary>
    public const int EHOJBKKPEJLFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.DCIEBIBMKPM> _repeated_eHOJBKKPEJL_codec
        = pb::FieldCodec.ForMessage(10, global::EggLink.DanhengServer.Proto.DCIEBIBMKPM.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DCIEBIBMKPM> eHOJBKKPEJL_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DCIEBIBMKPM>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DCIEBIBMKPM> EHOJBKKPEJL {
      get { return eHOJBKKPEJL_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FNABDILJEHJ);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FNABDILJEHJ other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!bOELEOBJCND_.Equals(other.bOELEOBJCND_)) return false;
      if(!nDBNBPMMPIH_.Equals(other.nDBNBPMMPIH_)) return false;
      if(!eBFOBMAPJON_.Equals(other.eBFOBMAPJON_)) return false;
      if(!eHOJBKKPEJL_.Equals(other.eHOJBKKPEJL_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= bOELEOBJCND_.GetHashCode();
      hash ^= nDBNBPMMPIH_.GetHashCode();
      hash ^= eBFOBMAPJON_.GetHashCode();
      hash ^= eHOJBKKPEJL_.GetHashCode();
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
      eHOJBKKPEJL_.WriteTo(output, _repeated_eHOJBKKPEJL_codec);
      eBFOBMAPJON_.WriteTo(output, _repeated_eBFOBMAPJON_codec);
      bOELEOBJCND_.WriteTo(output, _repeated_bOELEOBJCND_codec);
      nDBNBPMMPIH_.WriteTo(output, _repeated_nDBNBPMMPIH_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      eHOJBKKPEJL_.WriteTo(ref output, _repeated_eHOJBKKPEJL_codec);
      eBFOBMAPJON_.WriteTo(ref output, _repeated_eBFOBMAPJON_codec);
      bOELEOBJCND_.WriteTo(ref output, _repeated_bOELEOBJCND_codec);
      nDBNBPMMPIH_.WriteTo(ref output, _repeated_nDBNBPMMPIH_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += bOELEOBJCND_.CalculateSize(_repeated_bOELEOBJCND_codec);
      size += nDBNBPMMPIH_.CalculateSize(_repeated_nDBNBPMMPIH_codec);
      size += eBFOBMAPJON_.CalculateSize(_repeated_eBFOBMAPJON_codec);
      size += eHOJBKKPEJL_.CalculateSize(_repeated_eHOJBKKPEJL_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FNABDILJEHJ other) {
      if (other == null) {
        return;
      }
      bOELEOBJCND_.Add(other.bOELEOBJCND_);
      nDBNBPMMPIH_.Add(other.nDBNBPMMPIH_);
      eBFOBMAPJON_.Add(other.eBFOBMAPJON_);
      eHOJBKKPEJL_.Add(other.eHOJBKKPEJL_);
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
            eHOJBKKPEJL_.AddEntriesFrom(input, _repeated_eHOJBKKPEJL_codec);
            break;
          }
          case 26: {
            eBFOBMAPJON_.AddEntriesFrom(input, _repeated_eBFOBMAPJON_codec);
            break;
          }
          case 58:
          case 56: {
            bOELEOBJCND_.AddEntriesFrom(input, _repeated_bOELEOBJCND_codec);
            break;
          }
          case 82: {
            nDBNBPMMPIH_.AddEntriesFrom(input, _repeated_nDBNBPMMPIH_codec);
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
            eHOJBKKPEJL_.AddEntriesFrom(ref input, _repeated_eHOJBKKPEJL_codec);
            break;
          }
          case 26: {
            eBFOBMAPJON_.AddEntriesFrom(ref input, _repeated_eBFOBMAPJON_codec);
            break;
          }
          case 58:
          case 56: {
            bOELEOBJCND_.AddEntriesFrom(ref input, _repeated_bOELEOBJCND_codec);
            break;
          }
          case 82: {
            nDBNBPMMPIH_.AddEntriesFrom(ref input, _repeated_nDBNBPMMPIH_codec);
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
