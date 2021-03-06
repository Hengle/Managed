//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;
using System.IO;

namespace Noesis
{

public class XamlProvider : BaseComponent {
  internal new static XamlProvider CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new XamlProvider(cPtr, cMemoryOwn);
  }

  internal XamlProvider(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(XamlProvider obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected XamlProvider() {
  }

  /// <summary>
  /// Opens xaml file for reading returning a stream.
  /// </summary>
  /// <param name="filename">Path to the xaml file being opened.</param>
  public virtual Stream LoadXaml(string filename) {
    return null;
  }

  /// <summary>
  /// Raises XamlChanged event notifying Noesis that it should reload the specified xaml
  /// </summary>
  protected void RaiseXamlChanged(string uri) {
    Noesis_RaiseXamlChanged(swigCPtr, uri);
  }

  [DllImport(Library.Name)]
  private static extern void Noesis_RaiseXamlChanged(HandleRef provider,
    [MarshalAs(UnmanagedType.LPWStr)]string uri);

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_XamlProvider(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

