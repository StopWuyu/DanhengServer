// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueTalentStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueTalentStatus.proto</summary>
  public static partial class RogueTalentStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueTalentStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueTalentStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdSb2d1ZVRhbGVudFN0YXR1cy5wcm90bypxChFSb2d1ZVRhbGVudFN0YXR1",
            "cxIcChhST0dVRV9UQUxFTlRfU1RBVFVTX0xPQ0sQABIeChpST0dVRV9UQUxF",
            "TlRfU1RBVFVTX1VOTE9DSxABEh4KGlJPR1VFX1RBTEVOVF9TVEFUVVNfRU5B",
            "QkxFEAJCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.RogueTalentStatus), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum RogueTalentStatus {
    [pbr::OriginalName("ROGUE_TALENT_STATUS_LOCK")] Lock = 0,
    [pbr::OriginalName("ROGUE_TALENT_STATUS_UNLOCK")] Unlock = 1,
    [pbr::OriginalName("ROGUE_TALENT_STATUS_ENABLE")] Enable = 2,
  }

  #endregion

}

#endregion Designer generated code
