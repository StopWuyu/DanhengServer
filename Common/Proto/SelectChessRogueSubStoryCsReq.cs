// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SelectChessRogueSubStoryCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SelectChessRogueSubStoryCsReq.proto</summary>
  public static partial class SelectChessRogueSubStoryCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SelectChessRogueSubStoryCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SelectChessRogueSubStoryCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNTZWxlY3RDaGVzc1JvZ3VlU3ViU3RvcnlDc1JlcS5wcm90byJ5Ch1TZWxl",
            "Y3RDaGVzc1JvZ3VlU3ViU3RvcnlDc1JlcRITCgtNR0FFS1BHSEpFRRgMIAEo",
            "DRIZChFkaWFsb2d1ZV9ldmVudF9pZBgJIAEoDRITCgtHRklOTUZLTERCTBgE",
            "IAEoDRITCgtFT0JCTUdBT01MRRgNIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SelectChessRogueSubStoryCsReq), global::EggLink.DanhengServer.Proto.SelectChessRogueSubStoryCsReq.Parser, new[]{ "MGAEKPGHJEE", "DialogueEventId", "GFINMFKLDBL", "EOBBMGAOMLE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SelectChessRogueSubStoryCsReq : pb::IMessage<SelectChessRogueSubStoryCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SelectChessRogueSubStoryCsReq> _parser = new pb::MessageParser<SelectChessRogueSubStoryCsReq>(() => new SelectChessRogueSubStoryCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SelectChessRogueSubStoryCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SelectChessRogueSubStoryCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SelectChessRogueSubStoryCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SelectChessRogueSubStoryCsReq(SelectChessRogueSubStoryCsReq other) : this() {
      mGAEKPGHJEE_ = other.mGAEKPGHJEE_;
      dialogueEventId_ = other.dialogueEventId_;
      gFINMFKLDBL_ = other.gFINMFKLDBL_;
      eOBBMGAOMLE_ = other.eOBBMGAOMLE_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SelectChessRogueSubStoryCsReq Clone() {
      return new SelectChessRogueSubStoryCsReq(this);
    }

    /// <summary>Field number for the "MGAEKPGHJEE" field.</summary>
    public const int MGAEKPGHJEEFieldNumber = 12;
    private uint mGAEKPGHJEE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MGAEKPGHJEE {
      get { return mGAEKPGHJEE_; }
      set {
        mGAEKPGHJEE_ = value;
      }
    }

    /// <summary>Field number for the "dialogue_event_id" field.</summary>
    public const int DialogueEventIdFieldNumber = 9;
    private uint dialogueEventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DialogueEventId {
      get { return dialogueEventId_; }
      set {
        dialogueEventId_ = value;
      }
    }

    /// <summary>Field number for the "GFINMFKLDBL" field.</summary>
    public const int GFINMFKLDBLFieldNumber = 4;
    private uint gFINMFKLDBL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GFINMFKLDBL {
      get { return gFINMFKLDBL_; }
      set {
        gFINMFKLDBL_ = value;
      }
    }

    /// <summary>Field number for the "EOBBMGAOMLE" field.</summary>
    public const int EOBBMGAOMLEFieldNumber = 13;
    private uint eOBBMGAOMLE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EOBBMGAOMLE {
      get { return eOBBMGAOMLE_; }
      set {
        eOBBMGAOMLE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SelectChessRogueSubStoryCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SelectChessRogueSubStoryCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MGAEKPGHJEE != other.MGAEKPGHJEE) return false;
      if (DialogueEventId != other.DialogueEventId) return false;
      if (GFINMFKLDBL != other.GFINMFKLDBL) return false;
      if (EOBBMGAOMLE != other.EOBBMGAOMLE) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MGAEKPGHJEE != 0) hash ^= MGAEKPGHJEE.GetHashCode();
      if (DialogueEventId != 0) hash ^= DialogueEventId.GetHashCode();
      if (GFINMFKLDBL != 0) hash ^= GFINMFKLDBL.GetHashCode();
      if (EOBBMGAOMLE != 0) hash ^= EOBBMGAOMLE.GetHashCode();
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
      if (GFINMFKLDBL != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GFINMFKLDBL);
      }
      if (DialogueEventId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(DialogueEventId);
      }
      if (MGAEKPGHJEE != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MGAEKPGHJEE);
      }
      if (EOBBMGAOMLE != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EOBBMGAOMLE);
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
      if (GFINMFKLDBL != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GFINMFKLDBL);
      }
      if (DialogueEventId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(DialogueEventId);
      }
      if (MGAEKPGHJEE != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MGAEKPGHJEE);
      }
      if (EOBBMGAOMLE != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EOBBMGAOMLE);
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
      if (MGAEKPGHJEE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MGAEKPGHJEE);
      }
      if (DialogueEventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DialogueEventId);
      }
      if (GFINMFKLDBL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GFINMFKLDBL);
      }
      if (EOBBMGAOMLE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EOBBMGAOMLE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SelectChessRogueSubStoryCsReq other) {
      if (other == null) {
        return;
      }
      if (other.MGAEKPGHJEE != 0) {
        MGAEKPGHJEE = other.MGAEKPGHJEE;
      }
      if (other.DialogueEventId != 0) {
        DialogueEventId = other.DialogueEventId;
      }
      if (other.GFINMFKLDBL != 0) {
        GFINMFKLDBL = other.GFINMFKLDBL;
      }
      if (other.EOBBMGAOMLE != 0) {
        EOBBMGAOMLE = other.EOBBMGAOMLE;
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
            GFINMFKLDBL = input.ReadUInt32();
            break;
          }
          case 72: {
            DialogueEventId = input.ReadUInt32();
            break;
          }
          case 96: {
            MGAEKPGHJEE = input.ReadUInt32();
            break;
          }
          case 104: {
            EOBBMGAOMLE = input.ReadUInt32();
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
            GFINMFKLDBL = input.ReadUInt32();
            break;
          }
          case 72: {
            DialogueEventId = input.ReadUInt32();
            break;
          }
          case 96: {
            MGAEKPGHJEE = input.ReadUInt32();
            break;
          }
          case 104: {
            EOBBMGAOMLE = input.ReadUInt32();
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
