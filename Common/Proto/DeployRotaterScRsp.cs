// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DeployRotaterScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DeployRotaterScRsp.proto</summary>
  public static partial class DeployRotaterScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for DeployRotaterScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DeployRotaterScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhEZXBsb3lSb3RhdGVyU2NSc3AucHJvdG8aEUVDS05GSENESkZILnByb3Rv",
            "GhFPTkJKRkpBTktIQS5wcm90byJrChJEZXBsb3lSb3RhdGVyU2NSc3ASIQoL",
            "T0VLSEFGQUxPRkIYByABKAsyDC5FQ0tORkhDREpGSBIPCgdyZXRjb2RlGAMg",
            "ASgNEiEKC1BCS0ZHSk5BQk1DGAkgASgLMgwuT05CSkZKQU5LSEFCHqoCG0Vn",
            "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ECKNFHCDJFHReflection.Descriptor, global::EggLink.DanhengServer.Proto.ONBJFJANKHAReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DeployRotaterScRsp), global::EggLink.DanhengServer.Proto.DeployRotaterScRsp.Parser, new[]{ "OEKHAFALOFB", "Retcode", "PBKFGJNABMC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DeployRotaterScRsp : pb::IMessage<DeployRotaterScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DeployRotaterScRsp> _parser = new pb::MessageParser<DeployRotaterScRsp>(() => new DeployRotaterScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DeployRotaterScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DeployRotaterScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeployRotaterScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeployRotaterScRsp(DeployRotaterScRsp other) : this() {
      oEKHAFALOFB_ = other.oEKHAFALOFB_ != null ? other.oEKHAFALOFB_.Clone() : null;
      retcode_ = other.retcode_;
      pBKFGJNABMC_ = other.pBKFGJNABMC_ != null ? other.pBKFGJNABMC_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeployRotaterScRsp Clone() {
      return new DeployRotaterScRsp(this);
    }

    /// <summary>Field number for the "OEKHAFALOFB" field.</summary>
    public const int OEKHAFALOFBFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.ECKNFHCDJFH oEKHAFALOFB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ECKNFHCDJFH OEKHAFALOFB {
      get { return oEKHAFALOFB_; }
      set {
        oEKHAFALOFB_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 3;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "PBKFGJNABMC" field.</summary>
    public const int PBKFGJNABMCFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.ONBJFJANKHA pBKFGJNABMC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ONBJFJANKHA PBKFGJNABMC {
      get { return pBKFGJNABMC_; }
      set {
        pBKFGJNABMC_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DeployRotaterScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DeployRotaterScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(OEKHAFALOFB, other.OEKHAFALOFB)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(PBKFGJNABMC, other.PBKFGJNABMC)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (oEKHAFALOFB_ != null) hash ^= OEKHAFALOFB.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (pBKFGJNABMC_ != null) hash ^= PBKFGJNABMC.GetHashCode();
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
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (oEKHAFALOFB_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(OEKHAFALOFB);
      }
      if (pBKFGJNABMC_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(PBKFGJNABMC);
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
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (oEKHAFALOFB_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(OEKHAFALOFB);
      }
      if (pBKFGJNABMC_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(PBKFGJNABMC);
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
      if (oEKHAFALOFB_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OEKHAFALOFB);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (pBKFGJNABMC_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PBKFGJNABMC);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DeployRotaterScRsp other) {
      if (other == null) {
        return;
      }
      if (other.oEKHAFALOFB_ != null) {
        if (oEKHAFALOFB_ == null) {
          OEKHAFALOFB = new global::EggLink.DanhengServer.Proto.ECKNFHCDJFH();
        }
        OEKHAFALOFB.MergeFrom(other.OEKHAFALOFB);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.pBKFGJNABMC_ != null) {
        if (pBKFGJNABMC_ == null) {
          PBKFGJNABMC = new global::EggLink.DanhengServer.Proto.ONBJFJANKHA();
        }
        PBKFGJNABMC.MergeFrom(other.PBKFGJNABMC);
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
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 58: {
            if (oEKHAFALOFB_ == null) {
              OEKHAFALOFB = new global::EggLink.DanhengServer.Proto.ECKNFHCDJFH();
            }
            input.ReadMessage(OEKHAFALOFB);
            break;
          }
          case 74: {
            if (pBKFGJNABMC_ == null) {
              PBKFGJNABMC = new global::EggLink.DanhengServer.Proto.ONBJFJANKHA();
            }
            input.ReadMessage(PBKFGJNABMC);
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
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 58: {
            if (oEKHAFALOFB_ == null) {
              OEKHAFALOFB = new global::EggLink.DanhengServer.Proto.ECKNFHCDJFH();
            }
            input.ReadMessage(OEKHAFALOFB);
            break;
          }
          case 74: {
            if (pBKFGJNABMC_ == null) {
              PBKFGJNABMC = new global::EggLink.DanhengServer.Proto.ONBJFJANKHA();
            }
            input.ReadMessage(PBKFGJNABMC);
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
