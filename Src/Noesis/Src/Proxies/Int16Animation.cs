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

public class Int16Animation : BaseAnimation {
  internal new static Int16Animation CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Int16Animation(cPtr, cMemoryOwn);
  }

  internal Int16Animation(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Int16Animation obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public Int16Animation() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_Int16Animation();
  }

  public static DependencyProperty ByProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Int16Animation_ByProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty FromProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Int16Animation_FromProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ToProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Int16Animation_ToProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Nullable<short> From {
    set {
      NullableInt16 tempvalue = value;
      NoesisGUI_PINVOKE.Int16Animation_From_set(swigCPtr, ref tempvalue);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.Int16Animation_From_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<NullableInt16>(ret);
      }
      else {
        return new Nullable<short>();
      }
    }

  }

  public Nullable<short> To {
    set {
      NullableInt16 tempvalue = value;
      NoesisGUI_PINVOKE.Int16Animation_To_set(swigCPtr, ref tempvalue);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.Int16Animation_To_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<NullableInt16>(ret);
      }
      else {
        return new Nullable<short>();
      }
    }

  }

  public Nullable<short> By {
    set {
      NullableInt16 tempvalue = value;
      NoesisGUI_PINVOKE.Int16Animation_By_set(swigCPtr, ref tempvalue);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.Int16Animation_By_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<NullableInt16>(ret);
      }
      else {
        return new Nullable<short>();
      }
    }

  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.Int16Animation_GetStaticType();
    return ret;
  }

}

}

