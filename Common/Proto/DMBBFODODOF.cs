// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DMBBFODODOF.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DMBBFODODOF.proto</summary>
  public static partial class DMBBFODODOFReflection {

    #region Descriptor
    /// <summary>File descriptor for DMBBFODODOF.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DMBBFODODOFReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFETUJCRk9ET0RPRi5wcm90byI3CgtETUJCRk9ET0RPRhITCgtCQ0tQSEJP",
            "UENDThgGIAEoDRITCgtCTFBJQ0NCQ0tQSxgCIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DMBBFODODOF), global::EggLink.DanhengServer.Proto.DMBBFODODOF.Parser, new[]{ "BCKPHBOPCCN", "BLPICCBCKPK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DMBBFODODOF : pb::IMessage<DMBBFODODOF>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DMBBFODODOF> _parser = new pb::MessageParser<DMBBFODODOF>(() => new DMBBFODODOF());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DMBBFODODOF> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DMBBFODODOFReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DMBBFODODOF() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DMBBFODODOF(DMBBFODODOF other) : this() {
      bCKPHBOPCCN_ = other.bCKPHBOPCCN_;
      bLPICCBCKPK_ = other.bLPICCBCKPK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DMBBFODODOF Clone() {
      return new DMBBFODODOF(this);
    }

    /// <summary>Field number for the "BCKPHBOPCCN" field.</summary>
    public const int BCKPHBOPCCNFieldNumber = 6;
    private uint bCKPHBOPCCN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BCKPHBOPCCN {
      get { return bCKPHBOPCCN_; }
      set {
        bCKPHBOPCCN_ = value;
      }
    }

    /// <summary>Field number for the "BLPICCBCKPK" field.</summary>
    public const int BLPICCBCKPKFieldNumber = 2;
    private uint bLPICCBCKPK_;
    /// <summary>
    /// 4
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BLPICCBCKPK {
      get { return bLPICCBCKPK_; }
      set {
        bLPICCBCKPK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DMBBFODODOF);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DMBBFODODOF other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BCKPHBOPCCN != other.BCKPHBOPCCN) return false;
      if (BLPICCBCKPK != other.BLPICCBCKPK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BCKPHBOPCCN != 0) hash ^= BCKPHBOPCCN.GetHashCode();
      if (BLPICCBCKPK != 0) hash ^= BLPICCBCKPK.GetHashCode();
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
      if (BLPICCBCKPK != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BLPICCBCKPK);
      }
      if (BCKPHBOPCCN != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(BCKPHBOPCCN);
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
      if (BLPICCBCKPK != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BLPICCBCKPK);
      }
      if (BCKPHBOPCCN != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(BCKPHBOPCCN);
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
      if (BCKPHBOPCCN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BCKPHBOPCCN);
      }
      if (BLPICCBCKPK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BLPICCBCKPK);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DMBBFODODOF other) {
      if (other == null) {
        return;
      }
      if (other.BCKPHBOPCCN != 0) {
        BCKPHBOPCCN = other.BCKPHBOPCCN;
      }
      if (other.BLPICCBCKPK != 0) {
        BLPICCBCKPK = other.BLPICCBCKPK;
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
          case 16: {
            BLPICCBCKPK = input.ReadUInt32();
            break;
          }
          case 48: {
            BCKPHBOPCCN = input.ReadUInt32();
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
            BLPICCBCKPK = input.ReadUInt32();
            break;
          }
          case 48: {
            BCKPHBOPCCN = input.ReadUInt32();
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