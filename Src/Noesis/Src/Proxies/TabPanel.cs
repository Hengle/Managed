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

namespace Noesis
{

public class TabPanel : Panel {
  internal new static TabPanel CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new TabPanel(cPtr, cMemoryOwn);
  }

  internal TabPanel(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(TabPanel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public TabPanel() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if ((object)type.TypeHandle == typeof(TabPanel).TypeHandle) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_TabPanel();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.TabPanel_GetStaticType();
    return ret;
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_TabPanel(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

