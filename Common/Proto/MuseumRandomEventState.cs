// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MuseumRandomEventState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MuseumRandomEventState.proto</summary>
  public static partial class MuseumRandomEventStateReflection {

    #region Descriptor
    /// <summary>File descriptor for MuseumRandomEventState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MuseumRandomEventStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxNdXNldW1SYW5kb21FdmVudFN0YXRlLnByb3RvKrEBChZNdXNldW1SYW5k",
            "b21FdmVudFN0YXRlEiIKHk1VU0VVTV9SQU5ET01fRVZFTlRfU1RBVEVfTk9O",
            "RRAAEiMKH01VU0VVTV9SQU5ET01fRVZFTlRfU1RBVEVfU1RBUlQQARIoCiRN",
            "VVNFVU1fUkFORE9NX0VWRU5UX1NUQVRFX1BST0NFU1NJTkcQAhIkCiBNVVNF",
            "VU1fUkFORE9NX0VWRU5UX1NUQVRFX0ZJTklTSBADQh6qAhtFZ2dMaW5rLkRh",
            "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.MuseumRandomEventState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum MuseumRandomEventState {
    [pbr::OriginalName("MUSEUM_RANDOM_EVENT_STATE_NONE")] None = 0,
    [pbr::OriginalName("MUSEUM_RANDOM_EVENT_STATE_START")] Start = 1,
    [pbr::OriginalName("MUSEUM_RANDOM_EVENT_STATE_PROCESSING")] Processing = 2,
    [pbr::OriginalName("MUSEUM_RANDOM_EVENT_STATE_FINISH")] Finish = 3,
  }

  #endregion

}

#endregion Designer generated code
