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

public class ToggleButton : ButtonBase {
  internal new static ToggleButton CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ToggleButton(cPtr, cMemoryOwn);
  }

  internal ToggleButton(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ToggleButton obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  #region Events
  public event RoutedEventHandler Checked {
    add {
      AddHandler(CheckedEvent, value);
    }
    remove {
      RemoveHandler(CheckedEvent, value);
    }
  }

  public event RoutedEventHandler Indeterminate {
    add {
      AddHandler(IndeterminateEvent, value);
    }
    remove {
      RemoveHandler(IndeterminateEvent, value);
    }
  }

  public event RoutedEventHandler Unchecked {
    add {
      AddHandler(UncheckedEvent, value);
    }
    remove {
      RemoveHandler(UncheckedEvent, value);
    }
  }

  #endregion

  public ToggleButton() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if ((object)type.TypeHandle == typeof(ToggleButton).TypeHandle) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_ToggleButton();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static DependencyProperty IsCheckedProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToggleButton_IsCheckedProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsThreeStateProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToggleButton_IsThreeStateProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent CheckedEvent {
    set {
      NoesisGUI_PINVOKE.ToggleButton_CheckedEvent_set(RoutedEvent.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToggleButton_CheckedEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent IndeterminateEvent {
    set {
      NoesisGUI_PINVOKE.ToggleButton_IndeterminateEvent_set(RoutedEvent.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToggleButton_IndeterminateEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent UncheckedEvent {
    set {
      NoesisGUI_PINVOKE.ToggleButton_UncheckedEvent_set(RoutedEvent.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToggleButton_UncheckedEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Nullable<bool> IsChecked {
    set {
      NullableBool tempvalue = value;
      NoesisGUI_PINVOKE.ToggleButton_IsChecked_set(swigCPtr, ref tempvalue);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.ToggleButton_IsChecked_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<NullableBool>(ret);
      }
      else {
        return new Nullable<bool>();
      }
    }

  }

  public bool IsThreeState {
    set {
      NoesisGUI_PINVOKE.ToggleButton_IsThreeState_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.ToggleButton_IsThreeState_get(swigCPtr);
      return ret;
    } 
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.ToggleButton_GetStaticType();
    return ret;
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_ToggleButton(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

