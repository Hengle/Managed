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

public class VisualState : DependencyObject {
  internal new static VisualState CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new VisualState(cPtr, cMemoryOwn);
  }

  internal VisualState(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(VisualState obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public VisualState() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_VisualState();
  }

  public string Name {
    set {
      NoesisGUI_PINVOKE.VisualState_Name_set(swigCPtr, value != null ? value : string.Empty);
    }
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.VisualState_Name_get(swigCPtr);
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  public Storyboard Storyboard {
    set {
      NoesisGUI_PINVOKE.VisualState_Storyboard_set(swigCPtr, Storyboard.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.VisualState_Storyboard_get(swigCPtr);
      return (Storyboard)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

}

}

