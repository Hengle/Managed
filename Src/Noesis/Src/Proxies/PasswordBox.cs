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

public class PasswordBox : Control {
  internal new static PasswordBox CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new PasswordBox(cPtr, cMemoryOwn);
  }

  internal PasswordBox(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(PasswordBox obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  #region Events
  public event RoutedEventHandler PasswordChanged {
    add {
      AddHandler(PasswordChangedEvent, value);
    }
    remove {
      RemoveHandler(PasswordChangedEvent, value);
    }
  }

  #endregion

  public PasswordBox() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if ((object)type.TypeHandle == typeof(PasswordBox).TypeHandle) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_PasswordBox();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public void SelectAll() {
    NoesisGUI_PINVOKE.PasswordBox_SelectAll(swigCPtr);
  }

  public void HideCaret() {
    NoesisGUI_PINVOKE.PasswordBox_HideCaret(swigCPtr);
  }

  public static DependencyProperty CaretBrushProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PasswordBox_CaretBrushProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty MaxLengthProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PasswordBox_MaxLengthProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty PasswordCharProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PasswordBox_PasswordCharProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty SelectionBrushProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PasswordBox_SelectionBrushProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty SelectionOpacityProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PasswordBox_SelectionOpacityProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent PasswordChangedEvent {
    set {
      NoesisGUI_PINVOKE.PasswordBox_PasswordChangedEvent_set(RoutedEvent.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PasswordBox_PasswordChangedEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Brush CaretBrush {
    set {
      NoesisGUI_PINVOKE.PasswordBox_CaretBrush_set(swigCPtr, Brush.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PasswordBox_CaretBrush_get(swigCPtr);
      return (Brush)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public int MaxLength {
    set {
      NoesisGUI_PINVOKE.PasswordBox_MaxLength_set(swigCPtr, value);
    } 
    get {
      int ret = NoesisGUI_PINVOKE.PasswordBox_MaxLength_get(swigCPtr);
      return ret;
    } 
  }

  public char PasswordChar {
    set {
      NoesisGUI_PINVOKE.PasswordBox_PasswordChar_set(swigCPtr, value);
    }
    get {
      char ret = (char)NoesisGUI_PINVOKE.PasswordBox_PasswordChar_get(swigCPtr);
      return ret;
    }
  }

  public string Password {
    set {
      NoesisGUI_PINVOKE.PasswordBox_Password_set(swigCPtr, value != null ? value : string.Empty);
    }
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.PasswordBox_Password_get(swigCPtr);
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  public Brush SelectionBrush {
    set {
      NoesisGUI_PINVOKE.PasswordBox_SelectionBrush_set(swigCPtr, Brush.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PasswordBox_SelectionBrush_get(swigCPtr);
      return (Brush)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public float SelectionOpacity {
    set {
      NoesisGUI_PINVOKE.PasswordBox_SelectionOpacity_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.PasswordBox_SelectionOpacity_get(swigCPtr);
      return ret;
    } 
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.PasswordBox_GetStaticType();
    return ret;
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_PasswordBox(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

