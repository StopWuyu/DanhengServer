// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueInfo.proto</summary>
  public static partial class RogueInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9Sb2d1ZUluZm8ucHJvdG8aE1JvZ3VlSW5mb0RhdGEucHJvdG8aFlJvZ3Vl",
            "Q3VycmVudEluZm8ucHJvdG8iZQoJUm9ndWVJbmZvEigKD3JvZ3VlX2luZm9f",
            "ZGF0YRiYCyABKAsyDi5Sb2d1ZUluZm9EYXRhEi4KEnJvZ3VlX2N1cnJlbnRf",
            "aW5mbxjMDCABKAsyES5Sb2d1ZUN1cnJlbnRJbmZvQh6qAhtFZ2dMaW5rLkRh",
            "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueInfoDataReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueCurrentInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueInfo), global::EggLink.DanhengServer.Proto.RogueInfo.Parser, new[]{ "RogueInfoData", "RogueCurrentInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueInfo : pb::IMessage<RogueInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueInfo> _parser = new pb::MessageParser<RogueInfo>(() => new RogueInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueInfo(RogueInfo other) : this() {
      rogueInfoData_ = other.rogueInfoData_ != null ? other.rogueInfoData_.Clone() : null;
      rogueCurrentInfo_ = other.rogueCurrentInfo_ != null ? other.rogueCurrentInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueInfo Clone() {
      return new RogueInfo(this);
    }

    /// <summary>Field number for the "rogue_info_data" field.</summary>
    public const int RogueInfoDataFieldNumber = 1432;
    private global::EggLink.DanhengServer.Proto.RogueInfoData rogueInfoData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueInfoData RogueInfoData {
      get { return rogueInfoData_; }
      set {
        rogueInfoData_ = value;
      }
    }

    /// <summary>Field number for the "rogue_current_info" field.</summary>
    public const int RogueCurrentInfoFieldNumber = 1612;
    private global::EggLink.DanhengServer.Proto.RogueCurrentInfo rogueCurrentInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueCurrentInfo RogueCurrentInfo {
      get { return rogueCurrentInfo_; }
      set {
        rogueCurrentInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueInfoData, other.RogueInfoData)) return false;
      if (!object.Equals(RogueCurrentInfo, other.RogueCurrentInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueInfoData_ != null) hash ^= RogueInfoData.GetHashCode();
      if (rogueCurrentInfo_ != null) hash ^= RogueCurrentInfo.GetHashCode();
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
      if (rogueInfoData_ != null) {
        output.WriteRawTag(194, 89);
        output.WriteMessage(RogueInfoData);
      }
      if (rogueCurrentInfo_ != null) {
        output.WriteRawTag(226, 100);
        output.WriteMessage(RogueCurrentInfo);
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
      if (rogueInfoData_ != null) {
        output.WriteRawTag(194, 89);
        output.WriteMessage(RogueInfoData);
      }
      if (rogueCurrentInfo_ != null) {
        output.WriteRawTag(226, 100);
        output.WriteMessage(RogueCurrentInfo);
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
      if (rogueInfoData_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(RogueInfoData);
      }
      if (rogueCurrentInfo_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(RogueCurrentInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueInfo other) {
      if (other == null) {
        return;
      }
      if (other.rogueInfoData_ != null) {
        if (rogueInfoData_ == null) {
          RogueInfoData = new global::EggLink.DanhengServer.Proto.RogueInfoData();
        }
        RogueInfoData.MergeFrom(other.RogueInfoData);
      }
      if (other.rogueCurrentInfo_ != null) {
        if (rogueCurrentInfo_ == null) {
          RogueCurrentInfo = new global::EggLink.DanhengServer.Proto.RogueCurrentInfo();
        }
        RogueCurrentInfo.MergeFrom(other.RogueCurrentInfo);
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
          case 11458: {
            if (rogueInfoData_ == null) {
              RogueInfoData = new global::EggLink.DanhengServer.Proto.RogueInfoData();
            }
            input.ReadMessage(RogueInfoData);
            break;
          }
          case 12898: {
            if (rogueCurrentInfo_ == null) {
              RogueCurrentInfo = new global::EggLink.DanhengServer.Proto.RogueCurrentInfo();
            }
            input.ReadMessage(RogueCurrentInfo);
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
          case 11458: {
            if (rogueInfoData_ == null) {
              RogueInfoData = new global::EggLink.DanhengServer.Proto.RogueInfoData();
            }
            input.ReadMessage(RogueInfoData);
            break;
          }
          case 12898: {
            if (rogueCurrentInfo_ == null) {
              RogueCurrentInfo = new global::EggLink.DanhengServer.Proto.RogueCurrentInfo();
            }
            input.ReadMessage(RogueCurrentInfo);
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