// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PunkLordDataChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PunkLordDataChangeNotify.proto</summary>
  public static partial class PunkLordDataChangeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PunkLordDataChangeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PunkLordDataChangeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5QdW5rTG9yZERhdGFDaGFuZ2VOb3RpZnkucHJvdG8iWQoYUHVua0xvcmRE",
            "YXRhQ2hhbmdlTm90aWZ5EhMKC0pLTEJDREtJSERFGAogASgNEhMKC0tBSkNF",
            "TVBMR1BLGAggASgNEhMKC0ZCTU5LTE9JTUFPGAUgASgNQh6qAhtFZ2dMaW5r",
            "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PunkLordDataChangeNotify), global::EggLink.DanhengServer.Proto.PunkLordDataChangeNotify.Parser, new[]{ "JKLBCDKIHDE", "KAJCEMPLGPK", "FBMNKLOIMAO" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PunkLordDataChangeNotify : pb::IMessage<PunkLordDataChangeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PunkLordDataChangeNotify> _parser = new pb::MessageParser<PunkLordDataChangeNotify>(() => new PunkLordDataChangeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PunkLordDataChangeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PunkLordDataChangeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PunkLordDataChangeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PunkLordDataChangeNotify(PunkLordDataChangeNotify other) : this() {
      jKLBCDKIHDE_ = other.jKLBCDKIHDE_;
      kAJCEMPLGPK_ = other.kAJCEMPLGPK_;
      fBMNKLOIMAO_ = other.fBMNKLOIMAO_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PunkLordDataChangeNotify Clone() {
      return new PunkLordDataChangeNotify(this);
    }

    /// <summary>Field number for the "JKLBCDKIHDE" field.</summary>
    public const int JKLBCDKIHDEFieldNumber = 10;
    private uint jKLBCDKIHDE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JKLBCDKIHDE {
      get { return jKLBCDKIHDE_; }
      set {
        jKLBCDKIHDE_ = value;
      }
    }

    /// <summary>Field number for the "KAJCEMPLGPK" field.</summary>
    public const int KAJCEMPLGPKFieldNumber = 8;
    private uint kAJCEMPLGPK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KAJCEMPLGPK {
      get { return kAJCEMPLGPK_; }
      set {
        kAJCEMPLGPK_ = value;
      }
    }

    /// <summary>Field number for the "FBMNKLOIMAO" field.</summary>
    public const int FBMNKLOIMAOFieldNumber = 5;
    private uint fBMNKLOIMAO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FBMNKLOIMAO {
      get { return fBMNKLOIMAO_; }
      set {
        fBMNKLOIMAO_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PunkLordDataChangeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PunkLordDataChangeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JKLBCDKIHDE != other.JKLBCDKIHDE) return false;
      if (KAJCEMPLGPK != other.KAJCEMPLGPK) return false;
      if (FBMNKLOIMAO != other.FBMNKLOIMAO) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (JKLBCDKIHDE != 0) hash ^= JKLBCDKIHDE.GetHashCode();
      if (KAJCEMPLGPK != 0) hash ^= KAJCEMPLGPK.GetHashCode();
      if (FBMNKLOIMAO != 0) hash ^= FBMNKLOIMAO.GetHashCode();
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
      if (FBMNKLOIMAO != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FBMNKLOIMAO);
      }
      if (KAJCEMPLGPK != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(KAJCEMPLGPK);
      }
      if (JKLBCDKIHDE != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(JKLBCDKIHDE);
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
      if (FBMNKLOIMAO != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FBMNKLOIMAO);
      }
      if (KAJCEMPLGPK != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(KAJCEMPLGPK);
      }
      if (JKLBCDKIHDE != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(JKLBCDKIHDE);
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
      if (JKLBCDKIHDE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JKLBCDKIHDE);
      }
      if (KAJCEMPLGPK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KAJCEMPLGPK);
      }
      if (FBMNKLOIMAO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FBMNKLOIMAO);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PunkLordDataChangeNotify other) {
      if (other == null) {
        return;
      }
      if (other.JKLBCDKIHDE != 0) {
        JKLBCDKIHDE = other.JKLBCDKIHDE;
      }
      if (other.KAJCEMPLGPK != 0) {
        KAJCEMPLGPK = other.KAJCEMPLGPK;
      }
      if (other.FBMNKLOIMAO != 0) {
        FBMNKLOIMAO = other.FBMNKLOIMAO;
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
          case 40: {
            FBMNKLOIMAO = input.ReadUInt32();
            break;
          }
          case 64: {
            KAJCEMPLGPK = input.ReadUInt32();
            break;
          }
          case 80: {
            JKLBCDKIHDE = input.ReadUInt32();
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
          case 40: {
            FBMNKLOIMAO = input.ReadUInt32();
            break;
          }
          case 64: {
            KAJCEMPLGPK = input.ReadUInt32();
            break;
          }
          case 80: {
            JKLBCDKIHDE = input.ReadUInt32();
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
