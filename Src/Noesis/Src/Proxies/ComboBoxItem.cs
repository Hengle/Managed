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

public class ComboBoxItem : ListBoxItem {
  internal new static ComboBoxItem CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ComboBoxItem(cPtr, cMemoryOwn);
  }

  internal ComboBoxItem(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ComboBoxItem obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public ComboBoxItem() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if ((object)type.TypeHandle == typeof(ComboBoxItem).TypeHandle) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_ComboBoxItem();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static DependencyProperty IsHighlightedProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ComboBoxItem_IsHighlightedProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool IsHighlighted {
    get {
      bool ret = NoesisGUI_PINVOKE.ComboBoxItem_IsHighlighted_get(swigCPtr);
      return ret;
    } 
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.ComboBoxItem_GetStaticType();
    return ret;
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_ComboBoxItem(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

