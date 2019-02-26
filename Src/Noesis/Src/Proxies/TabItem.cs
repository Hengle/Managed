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

public class TabItem : HeaderedContentControl {
  internal new static TabItem CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new TabItem(cPtr, cMemoryOwn);
  }

  internal TabItem(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(TabItem obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public TabItem() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if ((object)type.TypeHandle == typeof(TabItem).TypeHandle) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_TabItem();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static DependencyProperty IsSelectedProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TabItem_IsSelectedProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty TabStripPlacementProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TabItem_TabStripPlacementProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool IsSelected {
    set {
      NoesisGUI_PINVOKE.TabItem_IsSelected_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.TabItem_IsSelected_get(swigCPtr);
      return ret;
    } 
  }

  public Dock TabStripPlacement {
    get {
      Dock ret = (Dock)NoesisGUI_PINVOKE.TabItem_TabStripPlacement_get(swigCPtr);
      return ret;
    } 
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.TabItem_GetStaticType();
    return ret;
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_TabItem(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

