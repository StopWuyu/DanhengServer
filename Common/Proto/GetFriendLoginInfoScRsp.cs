// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetFriendLoginInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetFriendLoginInfoScRsp.proto</summary>
  public static partial class GetFriendLoginInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetFriendLoginInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetFriendLoginInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1HZXRGcmllbmRMb2dpbkluZm9TY1JzcC5wcm90byJ+ChdHZXRGcmllbmRM",
            "b2dpbkluZm9TY1JzcBITCgtHTVBGRUpMUEZMRxgLIAMoDRIPCgdyZXRjb2Rl",
            "GAQgASgNEhMKC0tNS05ITk1OQk5JGAggASgIEhMKC0VOSEZJRE9KT0VKGAog",
            "ASgIEhMKC0RLT0dCSFBJRktKGAwgAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetFriendLoginInfoScRsp), global::EggLink.DanhengServer.Proto.GetFriendLoginInfoScRsp.Parser, new[]{ "GMPFEJLPFLG", "Retcode", "KMKNHNMNBNI", "ENHFIDOJOEJ", "DKOGBHPIFKJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetFriendLoginInfoScRsp : pb::IMessage<GetFriendLoginInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetFriendLoginInfoScRsp> _parser = new pb::MessageParser<GetFriendLoginInfoScRsp>(() => new GetFriendLoginInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetFriendLoginInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetFriendLoginInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFriendLoginInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFriendLoginInfoScRsp(GetFriendLoginInfoScRsp other) : this() {
      gMPFEJLPFLG_ = other.gMPFEJLPFLG_.Clone();
      retcode_ = other.retcode_;
      kMKNHNMNBNI_ = other.kMKNHNMNBNI_;
      eNHFIDOJOEJ_ = other.eNHFIDOJOEJ_;
      dKOGBHPIFKJ_ = other.dKOGBHPIFKJ_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFriendLoginInfoScRsp Clone() {
      return new GetFriendLoginInfoScRsp(this);
    }

    /// <summary>Field number for the "GMPFEJLPFLG" field.</summary>
    public const int GMPFEJLPFLGFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_gMPFEJLPFLG_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> gMPFEJLPFLG_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> GMPFEJLPFLG {
      get { return gMPFEJLPFLG_; }
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

    /// <summary>Field number for the "KMKNHNMNBNI" field.</summary>
    public const int KMKNHNMNBNIFieldNumber = 8;
    private bool kMKNHNMNBNI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool KMKNHNMNBNI {
      get { return kMKNHNMNBNI_; }
      set {
        kMKNHNMNBNI_ = value;
      }
    }

    /// <summary>Field number for the "ENHFIDOJOEJ" field.</summary>
    public const int ENHFIDOJOEJFieldNumber = 10;
    private bool eNHFIDOJOEJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ENHFIDOJOEJ {
      get { return eNHFIDOJOEJ_; }
      set {
        eNHFIDOJOEJ_ = value;
      }
    }

    /// <summary>Field number for the "DKOGBHPIFKJ" field.</summary>
    public const int DKOGBHPIFKJFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_dKOGBHPIFKJ_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> dKOGBHPIFKJ_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> DKOGBHPIFKJ {
      get { return dKOGBHPIFKJ_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetFriendLoginInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetFriendLoginInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!gMPFEJLPFLG_.Equals(other.gMPFEJLPFLG_)) return false;
      if (Retcode != other.Retcode) return false;
      if (KMKNHNMNBNI != other.KMKNHNMNBNI) return false;
      if (ENHFIDOJOEJ != other.ENHFIDOJOEJ) return false;
      if(!dKOGBHPIFKJ_.Equals(other.dKOGBHPIFKJ_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= gMPFEJLPFLG_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (KMKNHNMNBNI != false) hash ^= KMKNHNMNBNI.GetHashCode();
      if (ENHFIDOJOEJ != false) hash ^= ENHFIDOJOEJ.GetHashCode();
      hash ^= dKOGBHPIFKJ_.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (KMKNHNMNBNI != false) {
        output.WriteRawTag(64);
        output.WriteBool(KMKNHNMNBNI);
      }
      if (ENHFIDOJOEJ != false) {
        output.WriteRawTag(80);
        output.WriteBool(ENHFIDOJOEJ);
      }
      gMPFEJLPFLG_.WriteTo(output, _repeated_gMPFEJLPFLG_codec);
      dKOGBHPIFKJ_.WriteTo(output, _repeated_dKOGBHPIFKJ_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (KMKNHNMNBNI != false) {
        output.WriteRawTag(64);
        output.WriteBool(KMKNHNMNBNI);
      }
      if (ENHFIDOJOEJ != false) {
        output.WriteRawTag(80);
        output.WriteBool(ENHFIDOJOEJ);
      }
      gMPFEJLPFLG_.WriteTo(ref output, _repeated_gMPFEJLPFLG_codec);
      dKOGBHPIFKJ_.WriteTo(ref output, _repeated_dKOGBHPIFKJ_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += gMPFEJLPFLG_.CalculateSize(_repeated_gMPFEJLPFLG_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (KMKNHNMNBNI != false) {
        size += 1 + 1;
      }
      if (ENHFIDOJOEJ != false) {
        size += 1 + 1;
      }
      size += dKOGBHPIFKJ_.CalculateSize(_repeated_dKOGBHPIFKJ_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetFriendLoginInfoScRsp other) {
      if (other == null) {
        return;
      }
      gMPFEJLPFLG_.Add(other.gMPFEJLPFLG_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.KMKNHNMNBNI != false) {
        KMKNHNMNBNI = other.KMKNHNMNBNI;
      }
      if (other.ENHFIDOJOEJ != false) {
        ENHFIDOJOEJ = other.ENHFIDOJOEJ;
      }
      dKOGBHPIFKJ_.Add(other.dKOGBHPIFKJ_);
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
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 64: {
            KMKNHNMNBNI = input.ReadBool();
            break;
          }
          case 80: {
            ENHFIDOJOEJ = input.ReadBool();
            break;
          }
          case 90:
          case 88: {
            gMPFEJLPFLG_.AddEntriesFrom(input, _repeated_gMPFEJLPFLG_codec);
            break;
          }
          case 98:
          case 96: {
            dKOGBHPIFKJ_.AddEntriesFrom(input, _repeated_dKOGBHPIFKJ_codec);
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
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 64: {
            KMKNHNMNBNI = input.ReadBool();
            break;
          }
          case 80: {
            ENHFIDOJOEJ = input.ReadBool();
            break;
          }
          case 90:
          case 88: {
            gMPFEJLPFLG_.AddEntriesFrom(ref input, _repeated_gMPFEJLPFLG_codec);
            break;
          }
          case 98:
          case 96: {
            dKOGBHPIFKJ_.AddEntriesFrom(ref input, _repeated_dKOGBHPIFKJ_codec);
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
