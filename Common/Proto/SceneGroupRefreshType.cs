// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGroupRefreshType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SceneGroupRefreshType.proto</summary>
  public static partial class SceneGroupRefreshTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneGroupRefreshType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneGroupRefreshTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtTY2VuZUdyb3VwUmVmcmVzaFR5cGUucHJvdG8qhAEKFVNjZW5lR3JvdXBS",
            "ZWZyZXNoVHlwZRIhCh1TQ0VORV9HUk9VUF9SRUZSRVNIX1RZUEVfTk9ORRAA",
            "EiMKH1NDRU5FX0dST1VQX1JFRlJFU0hfVFlQRV9MT0FERUQQARIjCh9TQ0VO",
            "RV9HUk9VUF9SRUZSRVNIX1RZUEVfVU5MT0FEEAJCHqoCG0VnZ0xpbmsuRGFu",
            "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.SceneGroupRefreshType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum SceneGroupRefreshType {
    [pbr::OriginalName("SCENE_GROUP_REFRESH_TYPE_NONE")] None = 0,
    [pbr::OriginalName("SCENE_GROUP_REFRESH_TYPE_LOADED")] Loaded = 1,
    [pbr::OriginalName("SCENE_GROUP_REFRESH_TYPE_UNLOAD")] Unload = 2,
  }

  #endregion

}

#endregion Designer generated code
