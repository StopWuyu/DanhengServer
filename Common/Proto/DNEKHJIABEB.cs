// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DNEKHJIABEB.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DNEKHJIABEB.proto</summary>
  public static partial class DNEKHJIABEBReflection {

    #region Descriptor
    /// <summary>File descriptor for DNEKHJIABEB.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DNEKHJIABEBReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFETkVLSEpJQUJFQi5wcm90bxoXTWlzc2lvblN5bmNSZWNvcmQucHJvdG8i",
            "UAoLRE5FS0hKSUFCRUISEwoLQ0FQQ0hFRUJBRE8YAyABKA0SCgoCaWQYBSAB",
            "KA0SIAoEdHlwZRgOIAEoDjISLk1pc3Npb25TeW5jUmVjb3JkQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MissionSyncRecordReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DNEKHJIABEB), global::EggLink.DanhengServer.Proto.DNEKHJIABEB.Parser, new[]{ "CAPCHEEBADO", "Id", "Type" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DNEKHJIABEB : pb::IMessage<DNEKHJIABEB>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DNEKHJIABEB> _parser = new pb::MessageParser<DNEKHJIABEB>(() => new DNEKHJIABEB());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DNEKHJIABEB> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DNEKHJIABEBReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DNEKHJIABEB() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DNEKHJIABEB(DNEKHJIABEB other) : this() {
      cAPCHEEBADO_ = other.cAPCHEEBADO_;
      id_ = other.id_;
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DNEKHJIABEB Clone() {
      return new DNEKHJIABEB(this);
    }

    /// <summary>Field number for the "CAPCHEEBADO" field.</summary>
    public const int CAPCHEEBADOFieldNumber = 3;
    private uint cAPCHEEBADO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CAPCHEEBADO {
      get { return cAPCHEEBADO_; }
      set {
        cAPCHEEBADO_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 5;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.MissionSyncRecord type_ = global::EggLink.DanhengServer.Proto.MissionSyncRecord.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MissionSyncRecord Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DNEKHJIABEB);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DNEKHJIABEB other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CAPCHEEBADO != other.CAPCHEEBADO) return false;
      if (Id != other.Id) return false;
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CAPCHEEBADO != 0) hash ^= CAPCHEEBADO.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Type != global::EggLink.DanhengServer.Proto.MissionSyncRecord.None) hash ^= Type.GetHashCode();
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
      if (CAPCHEEBADO != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CAPCHEEBADO);
      }
      if (Id != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Id);
      }
      if (Type != global::EggLink.DanhengServer.Proto.MissionSyncRecord.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) Type);
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
      if (CAPCHEEBADO != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CAPCHEEBADO);
      }
      if (Id != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Id);
      }
      if (Type != global::EggLink.DanhengServer.Proto.MissionSyncRecord.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) Type);
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
      if (CAPCHEEBADO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CAPCHEEBADO);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (Type != global::EggLink.DanhengServer.Proto.MissionSyncRecord.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DNEKHJIABEB other) {
      if (other == null) {
        return;
      }
      if (other.CAPCHEEBADO != 0) {
        CAPCHEEBADO = other.CAPCHEEBADO;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Type != global::EggLink.DanhengServer.Proto.MissionSyncRecord.None) {
        Type = other.Type;
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
            CAPCHEEBADO = input.ReadUInt32();
            break;
          }
          case 40: {
            Id = input.ReadUInt32();
            break;
          }
          case 112: {
            Type = (global::EggLink.DanhengServer.Proto.MissionSyncRecord) input.ReadEnum();
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
            CAPCHEEBADO = input.ReadUInt32();
            break;
          }
          case 40: {
            Id = input.ReadUInt32();
            break;
          }
          case 112: {
            Type = (global::EggLink.DanhengServer.Proto.MissionSyncRecord) input.ReadEnum();
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
