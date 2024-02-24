// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RefreshTriggerByClientScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RefreshTriggerByClientScRsp.proto</summary>
  public static partial class RefreshTriggerByClientScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for RefreshTriggerByClientScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RefreshTriggerByClientScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFSZWZyZXNoVHJpZ2dlckJ5Q2xpZW50U2NSc3AucHJvdG8ieAobUmVmcmVz",
            "aFRyaWdnZXJCeUNsaWVudFNjUnNwEhkKEXRyaWdnZXJfZW50aXR5X2lkGAUg",
            "ASgNEhQKDHRyaWdnZXJfbmFtZRgJIAEoCRIXCg9yZWZyZXNoX3RyaWdnZXIY",
            "CyABKAgSDwoHcmV0Y29kZRgGIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
            "dmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RefreshTriggerByClientScRsp), global::EggLink.DanhengServer.Proto.RefreshTriggerByClientScRsp.Parser, new[]{ "TriggerEntityId", "TriggerName", "RefreshTrigger", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RefreshTriggerByClientScRsp : pb::IMessage<RefreshTriggerByClientScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RefreshTriggerByClientScRsp> _parser = new pb::MessageParser<RefreshTriggerByClientScRsp>(() => new RefreshTriggerByClientScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RefreshTriggerByClientScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RefreshTriggerByClientScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RefreshTriggerByClientScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RefreshTriggerByClientScRsp(RefreshTriggerByClientScRsp other) : this() {
      triggerEntityId_ = other.triggerEntityId_;
      triggerName_ = other.triggerName_;
      refreshTrigger_ = other.refreshTrigger_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RefreshTriggerByClientScRsp Clone() {
      return new RefreshTriggerByClientScRsp(this);
    }

    /// <summary>Field number for the "trigger_entity_id" field.</summary>
    public const int TriggerEntityIdFieldNumber = 5;
    private uint triggerEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TriggerEntityId {
      get { return triggerEntityId_; }
      set {
        triggerEntityId_ = value;
      }
    }

    /// <summary>Field number for the "trigger_name" field.</summary>
    public const int TriggerNameFieldNumber = 9;
    private string triggerName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TriggerName {
      get { return triggerName_; }
      set {
        triggerName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "refresh_trigger" field.</summary>
    public const int RefreshTriggerFieldNumber = 11;
    private bool refreshTrigger_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool RefreshTrigger {
      get { return refreshTrigger_; }
      set {
        refreshTrigger_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 6;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RefreshTriggerByClientScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RefreshTriggerByClientScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TriggerEntityId != other.TriggerEntityId) return false;
      if (TriggerName != other.TriggerName) return false;
      if (RefreshTrigger != other.RefreshTrigger) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TriggerEntityId != 0) hash ^= TriggerEntityId.GetHashCode();
      if (TriggerName.Length != 0) hash ^= TriggerName.GetHashCode();
      if (RefreshTrigger != false) hash ^= RefreshTrigger.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (TriggerEntityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(TriggerEntityId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      if (TriggerName.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(TriggerName);
      }
      if (RefreshTrigger != false) {
        output.WriteRawTag(88);
        output.WriteBool(RefreshTrigger);
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
      if (TriggerEntityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(TriggerEntityId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      if (TriggerName.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(TriggerName);
      }
      if (RefreshTrigger != false) {
        output.WriteRawTag(88);
        output.WriteBool(RefreshTrigger);
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
      if (TriggerEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TriggerEntityId);
      }
      if (TriggerName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TriggerName);
      }
      if (RefreshTrigger != false) {
        size += 1 + 1;
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RefreshTriggerByClientScRsp other) {
      if (other == null) {
        return;
      }
      if (other.TriggerEntityId != 0) {
        TriggerEntityId = other.TriggerEntityId;
      }
      if (other.TriggerName.Length != 0) {
        TriggerName = other.TriggerName;
      }
      if (other.RefreshTrigger != false) {
        RefreshTrigger = other.RefreshTrigger;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
            TriggerEntityId = input.ReadUInt32();
            break;
          }
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 74: {
            TriggerName = input.ReadString();
            break;
          }
          case 88: {
            RefreshTrigger = input.ReadBool();
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
            TriggerEntityId = input.ReadUInt32();
            break;
          }
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 74: {
            TriggerName = input.ReadString();
            break;
          }
          case 88: {
            RefreshTrigger = input.ReadBool();
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