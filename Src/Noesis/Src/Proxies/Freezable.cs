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

public class Freezable : DependencyObject {
  internal new static Freezable CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Freezable(cPtr, cMemoryOwn);
  }

  internal Freezable(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Freezable obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected Freezable() {
  }

  public Freezable Clone() {
    IntPtr cPtr = CloneHelper();
    return (Freezable)Noesis.Extend.GetProxy(cPtr, true);
  }

  public Freezable CloneCurrentValue() {
    IntPtr cPtr = CloneCurrentValueHelper();
    return (Freezable)Noesis.Extend.GetProxy(cPtr, true);
  }

  public Freezable GetAsFrozen() {
    IntPtr cPtr = GetAsFrozenHelper();
    return (Freezable)Noesis.Extend.GetProxy(cPtr, true);
  }

  public Freezable GetCurrentValueAsFrozen() {
    IntPtr cPtr = GetCurrentValueAsFrozenHelper();
    return (Freezable)Noesis.Extend.GetProxy(cPtr, true);
  }

  protected virtual void CloneCommonCore(Freezable source) {
  }

  internal void CallCloneCommonCore(Freezable source) {
    CloneCommonCore(source);
  }

  public void Freeze() {
    NoesisGUI_PINVOKE.Freezable_Freeze(swigCPtr);
  }

  public bool CanSeal() {
    bool ret = NoesisGUI_PINVOKE.Freezable_CanSeal(swigCPtr);
    return ret;
  }

  public bool IsSealed() {
    bool ret = NoesisGUI_PINVOKE.Freezable_IsSealed(swigCPtr);
    return ret;
  }

  public void Seal() {
    NoesisGUI_PINVOKE.Freezable_Seal(swigCPtr);
  }

  public bool CanFreeze {
    get {
      bool ret = NoesisGUI_PINVOKE.Freezable_CanFreeze_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsFrozen {
    get {
      bool ret = NoesisGUI_PINVOKE.Freezable_IsFrozen_get(swigCPtr);
      return ret;
    } 
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.Freezable_GetStaticType();
    return ret;
  }

  private IntPtr CloneHelper() {
    IntPtr ret = NoesisGUI_PINVOKE.Freezable_CloneHelper(swigCPtr);
    return ret;
  }

  private IntPtr CloneCurrentValueHelper() {
    IntPtr ret = NoesisGUI_PINVOKE.Freezable_CloneCurrentValueHelper(swigCPtr);
    return ret;
  }

  private IntPtr GetAsFrozenHelper() {
    IntPtr ret = NoesisGUI_PINVOKE.Freezable_GetAsFrozenHelper(swigCPtr);
    return ret;
  }

  private IntPtr GetCurrentValueAsFrozenHelper() {
    IntPtr ret = NoesisGUI_PINVOKE.Freezable_GetCurrentValueAsFrozenHelper(swigCPtr);
    return ret;
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_Freezable(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

