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

public class SplineSizeKeyFrame : SizeKeyFrame {
  internal new static SplineSizeKeyFrame CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new SplineSizeKeyFrame(cPtr, cMemoryOwn);
  }

  internal SplineSizeKeyFrame(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(SplineSizeKeyFrame obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public static DependencyProperty KeySplineProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.SplineSizeKeyFrame_KeySplineProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public KeySpline KeySpline {
    set {
      NoesisGUI_PINVOKE.SplineSizeKeyFrame_KeySpline_set(swigCPtr, KeySpline.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.SplineSizeKeyFrame_KeySpline_get(swigCPtr);
      return (KeySpline)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public SplineSizeKeyFrame() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_SplineSizeKeyFrame();
  }

}

}

