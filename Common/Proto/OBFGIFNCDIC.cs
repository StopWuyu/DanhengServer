// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OBFGIFNCDIC.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from OBFGIFNCDIC.proto</summary>
  public static partial class OBFGIFNCDICReflection {

    #region Descriptor
    /// <summary>File descriptor for OBFGIFNCDIC.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OBFGIFNCDICReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFPQkZHSUZOQ0RJQy5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIm0KC09C",
            "RkdJRk5DRElDEhMKC0pNR0tGUEhQR0ZQGAogASgIEiAKCWNvc3RfZGF0YRgD",
            "IAEoCzINLkl0ZW1Db3N0RGF0YRISCgptaXJhY2xlX2lkGAggASgNEhMKC0FH",
            "Qk1HRExGQkZJGAUgASgIQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemCostDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.OBFGIFNCDIC), global::EggLink.DanhengServer.Proto.OBFGIFNCDIC.Parser, new[]{ "JMGKFPHPGFP", "CostData", "MiracleId", "AGBMGDLFBFI" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class OBFGIFNCDIC : pb::IMessage<OBFGIFNCDIC>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OBFGIFNCDIC> _parser = new pb::MessageParser<OBFGIFNCDIC>(() => new OBFGIFNCDIC());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OBFGIFNCDIC> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.OBFGIFNCDICReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OBFGIFNCDIC() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OBFGIFNCDIC(OBFGIFNCDIC other) : this() {
      jMGKFPHPGFP_ = other.jMGKFPHPGFP_;
      costData_ = other.costData_ != null ? other.costData_.Clone() : null;
      miracleId_ = other.miracleId_;
      aGBMGDLFBFI_ = other.aGBMGDLFBFI_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OBFGIFNCDIC Clone() {
      return new OBFGIFNCDIC(this);
    }

    /// <summary>Field number for the "JMGKFPHPGFP" field.</summary>
    public const int JMGKFPHPGFPFieldNumber = 10;
    private bool jMGKFPHPGFP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool JMGKFPHPGFP {
      get { return jMGKFPHPGFP_; }
      set {
        jMGKFPHPGFP_ = value;
      }
    }

    /// <summary>Field number for the "cost_data" field.</summary>
    public const int CostDataFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.ItemCostData costData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostData CostData {
      get { return costData_; }
      set {
        costData_ = value;
      }
    }

    /// <summary>Field number for the "miracle_id" field.</summary>
    public const int MiracleIdFieldNumber = 8;
    private uint miracleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MiracleId {
      get { return miracleId_; }
      set {
        miracleId_ = value;
      }
    }

    /// <summary>Field number for the "AGBMGDLFBFI" field.</summary>
    public const int AGBMGDLFBFIFieldNumber = 5;
    private bool aGBMGDLFBFI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool AGBMGDLFBFI {
      get { return aGBMGDLFBFI_; }
      set {
        aGBMGDLFBFI_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OBFGIFNCDIC);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OBFGIFNCDIC other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JMGKFPHPGFP != other.JMGKFPHPGFP) return false;
      if (!object.Equals(CostData, other.CostData)) return false;
      if (MiracleId != other.MiracleId) return false;
      if (AGBMGDLFBFI != other.AGBMGDLFBFI) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (JMGKFPHPGFP != false) hash ^= JMGKFPHPGFP.GetHashCode();
      if (costData_ != null) hash ^= CostData.GetHashCode();
      if (MiracleId != 0) hash ^= MiracleId.GetHashCode();
      if (AGBMGDLFBFI != false) hash ^= AGBMGDLFBFI.GetHashCode();
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
      if (costData_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CostData);
      }
      if (AGBMGDLFBFI != false) {
        output.WriteRawTag(40);
        output.WriteBool(AGBMGDLFBFI);
      }
      if (MiracleId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(MiracleId);
      }
      if (JMGKFPHPGFP != false) {
        output.WriteRawTag(80);
        output.WriteBool(JMGKFPHPGFP);
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
      if (costData_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CostData);
      }
      if (AGBMGDLFBFI != false) {
        output.WriteRawTag(40);
        output.WriteBool(AGBMGDLFBFI);
      }
      if (MiracleId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(MiracleId);
      }
      if (JMGKFPHPGFP != false) {
        output.WriteRawTag(80);
        output.WriteBool(JMGKFPHPGFP);
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
      if (JMGKFPHPGFP != false) {
        size += 1 + 1;
      }
      if (costData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CostData);
      }
      if (MiracleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MiracleId);
      }
      if (AGBMGDLFBFI != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OBFGIFNCDIC other) {
      if (other == null) {
        return;
      }
      if (other.JMGKFPHPGFP != false) {
        JMGKFPHPGFP = other.JMGKFPHPGFP;
      }
      if (other.costData_ != null) {
        if (costData_ == null) {
          CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
        }
        CostData.MergeFrom(other.CostData);
      }
      if (other.MiracleId != 0) {
        MiracleId = other.MiracleId;
      }
      if (other.AGBMGDLFBFI != false) {
        AGBMGDLFBFI = other.AGBMGDLFBFI;
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
          case 26: {
            if (costData_ == null) {
              CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(CostData);
            break;
          }
          case 40: {
            AGBMGDLFBFI = input.ReadBool();
            break;
          }
          case 64: {
            MiracleId = input.ReadUInt32();
            break;
          }
          case 80: {
            JMGKFPHPGFP = input.ReadBool();
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
          case 26: {
            if (costData_ == null) {
              CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(CostData);
            break;
          }
          case 40: {
            AGBMGDLFBFI = input.ReadBool();
            break;
          }
          case 64: {
            MiracleId = input.ReadUInt32();
            break;
          }
          case 80: {
            JMGKFPHPGFP = input.ReadBool();
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
