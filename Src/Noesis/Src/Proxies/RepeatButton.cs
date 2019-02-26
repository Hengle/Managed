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

public class RepeatButton : ButtonBase {
  internal new static RepeatButton CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new RepeatButton(cPtr, cMemoryOwn);
  }

  internal RepeatButton(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(RepeatButton obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public RepeatButton() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if ((object)type.TypeHandle == typeof(RepeatButton).TypeHandle) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_RepeatButton();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static DependencyProperty DelayProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.RepeatButton_DelayProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IntervalProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.RepeatButton_IntervalProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public int Delay {
    set {
      NoesisGUI_PINVOKE.RepeatButton_Delay_set(swigCPtr, value);
    } 
    get {
      int ret = NoesisGUI_PINVOKE.RepeatButton_Delay_get(swigCPtr);
      return ret;
    } 
  }

  public int Interval {
    set {
      NoesisGUI_PINVOKE.RepeatButton_Interval_set(swigCPtr, value);
    } 
    get {
      int ret = NoesisGUI_PINVOKE.RepeatButton_Interval_get(swigCPtr);
      return ret;
    } 
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.RepeatButton_GetStaticType();
    return ret;
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_RepeatButton(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

