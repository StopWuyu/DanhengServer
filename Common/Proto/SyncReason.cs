// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SyncReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SyncReason.proto</summary>
  public static partial class SyncReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for SyncReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SyncReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBTeW5jUmVhc29uLnByb3RvKpQBCgpTeW5jUmVhc29uEhQKEFNZTkNfUkVB",
            "U09OX05PTkUQABIWChJTWU5DX1JFQVNPTl9NUF9BREQQARIfChtTWU5DX1JF",
            "QVNPTl9NUF9BRERfUFJPUF9ISVQQAhIWChJTWU5DX1JFQVNPTl9IUF9BREQQ",
            "AxIfChtTWU5DX1JFQVNPTl9IUF9BRERfUFJPUF9ISVQQBEIeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.SyncReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum SyncReason {
    [pbr::OriginalName("SYNC_REASON_NONE")] None = 0,
    [pbr::OriginalName("SYNC_REASON_MP_ADD")] MpAdd = 1,
    [pbr::OriginalName("SYNC_REASON_MP_ADD_PROP_HIT")] MpAddPropHit = 2,
    [pbr::OriginalName("SYNC_REASON_HP_ADD")] HpAdd = 3,
    [pbr::OriginalName("SYNC_REASON_HP_ADD_PROP_HIT")] HpAddPropHit = 4,
  }

  #endregion

}

#endregion Designer generated code