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

public class PowerEase : EasingFunctionBase {
  internal new static PowerEase CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new PowerEase(cPtr, cMemoryOwn);
  }

  internal PowerEase(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(PowerEase obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public PowerEase() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_PowerEase();
  }

  public static DependencyProperty PowerProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PowerEase_PowerProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public float Power {
    set {
      NoesisGUI_PINVOKE.PowerEase_Power_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.PowerEase_Power_get(swigCPtr);
      return ret;
    } 
  }

}

}

