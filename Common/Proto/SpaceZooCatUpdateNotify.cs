// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SpaceZooCatUpdateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SpaceZooCatUpdateNotify.proto</summary>
  public static partial class SpaceZooCatUpdateNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SpaceZooCatUpdateNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpaceZooCatUpdateNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1TcGFjZVpvb0NhdFVwZGF0ZU5vdGlmeS5wcm90bxoRRkJQQUlLQ0lLSUsu",
            "cHJvdG8iZgoXU3BhY2Vab29DYXRVcGRhdGVOb3RpZnkSEwoLSUJLRU9OR0tD",
            "TkUYByABKAgSEwoLT0RDTUVIRklQR0gYDCABKAgSIQoLTUVGQ0VQTE1OTEIY",
            "DSADKAsyDC5GQlBBSUtDSUtJS0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FBPAIKCIKIKReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SpaceZooCatUpdateNotify), global::EggLink.DanhengServer.Proto.SpaceZooCatUpdateNotify.Parser, new[]{ "IBKEONGKCNE", "ODCMEHFIPGH", "MEFCEPLMNLB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SpaceZooCatUpdateNotify : pb::IMessage<SpaceZooCatUpdateNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SpaceZooCatUpdateNotify> _parser = new pb::MessageParser<SpaceZooCatUpdateNotify>(() => new SpaceZooCatUpdateNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SpaceZooCatUpdateNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SpaceZooCatUpdateNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooCatUpdateNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooCatUpdateNotify(SpaceZooCatUpdateNotify other) : this() {
      iBKEONGKCNE_ = other.iBKEONGKCNE_;
      oDCMEHFIPGH_ = other.oDCMEHFIPGH_;
      mEFCEPLMNLB_ = other.mEFCEPLMNLB_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooCatUpdateNotify Clone() {
      return new SpaceZooCatUpdateNotify(this);
    }

    /// <summary>Field number for the "IBKEONGKCNE" field.</summary>
    public const int IBKEONGKCNEFieldNumber = 7;
    private bool iBKEONGKCNE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IBKEONGKCNE {
      get { return iBKEONGKCNE_; }
      set {
        iBKEONGKCNE_ = value;
      }
    }

    /// <summary>Field number for the "ODCMEHFIPGH" field.</summary>
    public const int ODCMEHFIPGHFieldNumber = 12;
    private bool oDCMEHFIPGH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ODCMEHFIPGH {
      get { return oDCMEHFIPGH_; }
      set {
        oDCMEHFIPGH_ = value;
      }
    }

    /// <summary>Field number for the "MEFCEPLMNLB" field.</summary>
    public const int MEFCEPLMNLBFieldNumber = 13;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.FBPAIKCIKIK> _repeated_mEFCEPLMNLB_codec
        = pb::FieldCodec.ForMessage(106, global::EggLink.DanhengServer.Proto.FBPAIKCIKIK.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FBPAIKCIKIK> mEFCEPLMNLB_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FBPAIKCIKIK>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FBPAIKCIKIK> MEFCEPLMNLB {
      get { return mEFCEPLMNLB_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SpaceZooCatUpdateNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SpaceZooCatUpdateNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IBKEONGKCNE != other.IBKEONGKCNE) return false;
      if (ODCMEHFIPGH != other.ODCMEHFIPGH) return false;
      if(!mEFCEPLMNLB_.Equals(other.mEFCEPLMNLB_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IBKEONGKCNE != false) hash ^= IBKEONGKCNE.GetHashCode();
      if (ODCMEHFIPGH != false) hash ^= ODCMEHFIPGH.GetHashCode();
      hash ^= mEFCEPLMNLB_.GetHashCode();
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
      if (IBKEONGKCNE != false) {
        output.WriteRawTag(56);
        output.WriteBool(IBKEONGKCNE);
      }
      if (ODCMEHFIPGH != false) {
        output.WriteRawTag(96);
        output.WriteBool(ODCMEHFIPGH);
      }
      mEFCEPLMNLB_.WriteTo(output, _repeated_mEFCEPLMNLB_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (IBKEONGKCNE != false) {
        output.WriteRawTag(56);
        output.WriteBool(IBKEONGKCNE);
      }
      if (ODCMEHFIPGH != false) {
        output.WriteRawTag(96);
        output.WriteBool(ODCMEHFIPGH);
      }
      mEFCEPLMNLB_.WriteTo(ref output, _repeated_mEFCEPLMNLB_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (IBKEONGKCNE != false) {
        size += 1 + 1;
      }
      if (ODCMEHFIPGH != false) {
        size += 1 + 1;
      }
      size += mEFCEPLMNLB_.CalculateSize(_repeated_mEFCEPLMNLB_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SpaceZooCatUpdateNotify other) {
      if (other == null) {
        return;
      }
      if (other.IBKEONGKCNE != false) {
        IBKEONGKCNE = other.IBKEONGKCNE;
      }
      if (other.ODCMEHFIPGH != false) {
        ODCMEHFIPGH = other.ODCMEHFIPGH;
      }
      mEFCEPLMNLB_.Add(other.mEFCEPLMNLB_);
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
          case 56: {
            IBKEONGKCNE = input.ReadBool();
            break;
          }
          case 96: {
            ODCMEHFIPGH = input.ReadBool();
            break;
          }
          case 106: {
            mEFCEPLMNLB_.AddEntriesFrom(input, _repeated_mEFCEPLMNLB_codec);
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
          case 56: {
            IBKEONGKCNE = input.ReadBool();
            break;
          }
          case 96: {
            ODCMEHFIPGH = input.ReadBool();
            break;
          }
          case 106: {
            mEFCEPLMNLB_.AddEntriesFrom(ref input, _repeated_mEFCEPLMNLB_codec);
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
