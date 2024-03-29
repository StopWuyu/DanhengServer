// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueModifierContent.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueModifierContent.proto</summary>
  public static partial class RogueModifierContentReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueModifierContent.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueModifierContentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpSb2d1ZU1vZGlmaWVyQ29udGVudC5wcm90bxoXUm9ndWVNb2RpZmllclR5",
            "cGUucHJvdG8iaQoUUm9ndWVNb2RpZmllckNvbnRlbnQSEwoLbW9kaWZpZXJf",
            "aWQYAiABKA0SJwoLQVBGQ09KTEFDQlAYCiABKA4yEi5Sb2d1ZU1vZGlmaWVy",
            "VHlwZRITCgtNT0RMR0lFRkJLUBgGIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueModifierTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueModifierContent), global::EggLink.DanhengServer.Proto.RogueModifierContent.Parser, new[]{ "ModifierId", "APFCOJLACBP", "MODLGIEFBKP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueModifierContent : pb::IMessage<RogueModifierContent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueModifierContent> _parser = new pb::MessageParser<RogueModifierContent>(() => new RogueModifierContent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueModifierContent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueModifierContentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueModifierContent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueModifierContent(RogueModifierContent other) : this() {
      modifierId_ = other.modifierId_;
      aPFCOJLACBP_ = other.aPFCOJLACBP_;
      mODLGIEFBKP_ = other.mODLGIEFBKP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueModifierContent Clone() {
      return new RogueModifierContent(this);
    }

    /// <summary>Field number for the "modifier_id" field.</summary>
    public const int ModifierIdFieldNumber = 2;
    private uint modifierId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ModifierId {
      get { return modifierId_; }
      set {
        modifierId_ = value;
      }
    }

    /// <summary>Field number for the "APFCOJLACBP" field.</summary>
    public const int APFCOJLACBPFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.RogueModifierType aPFCOJLACBP_ = global::EggLink.DanhengServer.Proto.RogueModifierType.RogueModifierContentDefinite;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueModifierType APFCOJLACBP {
      get { return aPFCOJLACBP_; }
      set {
        aPFCOJLACBP_ = value;
      }
    }

    /// <summary>Field number for the "MODLGIEFBKP" field.</summary>
    public const int MODLGIEFBKPFieldNumber = 6;
    private uint mODLGIEFBKP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MODLGIEFBKP {
      get { return mODLGIEFBKP_; }
      set {
        mODLGIEFBKP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueModifierContent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueModifierContent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ModifierId != other.ModifierId) return false;
      if (APFCOJLACBP != other.APFCOJLACBP) return false;
      if (MODLGIEFBKP != other.MODLGIEFBKP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ModifierId != 0) hash ^= ModifierId.GetHashCode();
      if (APFCOJLACBP != global::EggLink.DanhengServer.Proto.RogueModifierType.RogueModifierContentDefinite) hash ^= APFCOJLACBP.GetHashCode();
      if (MODLGIEFBKP != 0) hash ^= MODLGIEFBKP.GetHashCode();
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
      if (ModifierId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ModifierId);
      }
      if (MODLGIEFBKP != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MODLGIEFBKP);
      }
      if (APFCOJLACBP != global::EggLink.DanhengServer.Proto.RogueModifierType.RogueModifierContentDefinite) {
        output.WriteRawTag(80);
        output.WriteEnum((int) APFCOJLACBP);
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
      if (ModifierId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ModifierId);
      }
      if (MODLGIEFBKP != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MODLGIEFBKP);
      }
      if (APFCOJLACBP != global::EggLink.DanhengServer.Proto.RogueModifierType.RogueModifierContentDefinite) {
        output.WriteRawTag(80);
        output.WriteEnum((int) APFCOJLACBP);
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
      if (ModifierId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ModifierId);
      }
      if (APFCOJLACBP != global::EggLink.DanhengServer.Proto.RogueModifierType.RogueModifierContentDefinite) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) APFCOJLACBP);
      }
      if (MODLGIEFBKP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MODLGIEFBKP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueModifierContent other) {
      if (other == null) {
        return;
      }
      if (other.ModifierId != 0) {
        ModifierId = other.ModifierId;
      }
      if (other.APFCOJLACBP != global::EggLink.DanhengServer.Proto.RogueModifierType.RogueModifierContentDefinite) {
        APFCOJLACBP = other.APFCOJLACBP;
      }
      if (other.MODLGIEFBKP != 0) {
        MODLGIEFBKP = other.MODLGIEFBKP;
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
            ModifierId = input.ReadUInt32();
            break;
          }
          case 48: {
            MODLGIEFBKP = input.ReadUInt32();
            break;
          }
          case 80: {
            APFCOJLACBP = (global::EggLink.DanhengServer.Proto.RogueModifierType) input.ReadEnum();
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
            ModifierId = input.ReadUInt32();
            break;
          }
          case 48: {
            MODLGIEFBKP = input.ReadUInt32();
            break;
          }
          case 80: {
            APFCOJLACBP = (global::EggLink.DanhengServer.Proto.RogueModifierType) input.ReadEnum();
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
