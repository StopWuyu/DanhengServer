// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetRollShopInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetRollShopInfoScRsp.proto</summary>
  public static partial class GetRollShopInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetRollShopInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetRollShopInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpHZXRSb2xsU2hvcEluZm9TY1JzcC5wcm90byJmChRHZXRSb2xsU2hvcElu",
            "Zm9TY1JzcBITCgtHTVBLT0VJQkVNRhgPIAEoDRIPCgdyZXRjb2RlGAUgASgN",
            "EhMKC0RMUEJKTVBFQ0ZDGAggAygNEhMKC0JCSklKSU5KQUZLGAQgASgNQh6q",
            "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetRollShopInfoScRsp), global::EggLink.DanhengServer.Proto.GetRollShopInfoScRsp.Parser, new[]{ "GMPKOEIBEMF", "Retcode", "DLPBJMPECFC", "BBJIJINJAFK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetRollShopInfoScRsp : pb::IMessage<GetRollShopInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetRollShopInfoScRsp> _parser = new pb::MessageParser<GetRollShopInfoScRsp>(() => new GetRollShopInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetRollShopInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetRollShopInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetRollShopInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetRollShopInfoScRsp(GetRollShopInfoScRsp other) : this() {
      gMPKOEIBEMF_ = other.gMPKOEIBEMF_;
      retcode_ = other.retcode_;
      dLPBJMPECFC_ = other.dLPBJMPECFC_.Clone();
      bBJIJINJAFK_ = other.bBJIJINJAFK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetRollShopInfoScRsp Clone() {
      return new GetRollShopInfoScRsp(this);
    }

    /// <summary>Field number for the "GMPKOEIBEMF" field.</summary>
    public const int GMPKOEIBEMFFieldNumber = 15;
    private uint gMPKOEIBEMF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GMPKOEIBEMF {
      get { return gMPKOEIBEMF_; }
      set {
        gMPKOEIBEMF_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 5;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "DLPBJMPECFC" field.</summary>
    public const int DLPBJMPECFCFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_dLPBJMPECFC_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> dLPBJMPECFC_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> DLPBJMPECFC {
      get { return dLPBJMPECFC_; }
    }

    /// <summary>Field number for the "BBJIJINJAFK" field.</summary>
    public const int BBJIJINJAFKFieldNumber = 4;
    private uint bBJIJINJAFK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BBJIJINJAFK {
      get { return bBJIJINJAFK_; }
      set {
        bBJIJINJAFK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetRollShopInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetRollShopInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GMPKOEIBEMF != other.GMPKOEIBEMF) return false;
      if (Retcode != other.Retcode) return false;
      if(!dLPBJMPECFC_.Equals(other.dLPBJMPECFC_)) return false;
      if (BBJIJINJAFK != other.BBJIJINJAFK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GMPKOEIBEMF != 0) hash ^= GMPKOEIBEMF.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= dLPBJMPECFC_.GetHashCode();
      if (BBJIJINJAFK != 0) hash ^= BBJIJINJAFK.GetHashCode();
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
      if (BBJIJINJAFK != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(BBJIJINJAFK);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      dLPBJMPECFC_.WriteTo(output, _repeated_dLPBJMPECFC_codec);
      if (GMPKOEIBEMF != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(GMPKOEIBEMF);
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
      if (BBJIJINJAFK != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(BBJIJINJAFK);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      dLPBJMPECFC_.WriteTo(ref output, _repeated_dLPBJMPECFC_codec);
      if (GMPKOEIBEMF != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(GMPKOEIBEMF);
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
      if (GMPKOEIBEMF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GMPKOEIBEMF);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += dLPBJMPECFC_.CalculateSize(_repeated_dLPBJMPECFC_codec);
      if (BBJIJINJAFK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BBJIJINJAFK);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetRollShopInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.GMPKOEIBEMF != 0) {
        GMPKOEIBEMF = other.GMPKOEIBEMF;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      dLPBJMPECFC_.Add(other.dLPBJMPECFC_);
      if (other.BBJIJINJAFK != 0) {
        BBJIJINJAFK = other.BBJIJINJAFK;
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
          case 32: {
            BBJIJINJAFK = input.ReadUInt32();
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            dLPBJMPECFC_.AddEntriesFrom(input, _repeated_dLPBJMPECFC_codec);
            break;
          }
          case 120: {
            GMPKOEIBEMF = input.ReadUInt32();
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
            BBJIJINJAFK = input.ReadUInt32();
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            dLPBJMPECFC_.AddEntriesFrom(ref input, _repeated_dLPBJMPECFC_codec);
            break;
          }
          case 120: {
            GMPKOEIBEMF = input.ReadUInt32();
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
