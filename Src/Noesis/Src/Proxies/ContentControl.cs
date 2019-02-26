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

public class ContentControl : Control {
  internal new static ContentControl CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ContentControl(cPtr, cMemoryOwn);
  }

  internal ContentControl(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ContentControl obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public override string ToString() {
    return ToStringHelper();
  }

  public ContentControl() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if ((object)type.TypeHandle == typeof(ContentControl).TypeHandle) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_ContentControl();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static DependencyProperty ContentProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContentControl_ContentProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ContentTemplateProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContentControl_ContentTemplateProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ContentTemplateSelectorProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContentControl_ContentTemplateSelectorProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty HasContentProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContentControl_HasContentProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public object Content {
    set {
      NoesisGUI_PINVOKE.ContentControl_Content_set(swigCPtr, Noesis.Extend.GetInstanceHandle(value));
    }
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContentControl_Content_get(swigCPtr);
      return Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public DataTemplate ContentTemplate {
    set {
      NoesisGUI_PINVOKE.ContentControl_ContentTemplate_set(swigCPtr, DataTemplate.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContentControl_ContentTemplate_get(swigCPtr);
      return (DataTemplate)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public DataTemplateSelector ContentTemplateSelector {
    set {
      NoesisGUI_PINVOKE.ContentControl_ContentTemplateSelector_set(swigCPtr, DataTemplateSelector.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ContentControl_ContentTemplateSelector_get(swigCPtr);
      return (DataTemplateSelector)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool HasContent {
    get {
      bool ret = NoesisGUI_PINVOKE.ContentControl_HasContent_get(swigCPtr);
      return ret;
    } 
  }

  private string ToStringHelper() {
    IntPtr strPtr = NoesisGUI_PINVOKE.ContentControl_ToStringHelper(swigCPtr);
    string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
    NoesisGUI_PINVOKE.FreeString(strPtr);
    return str;
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.ContentControl_GetStaticType();
    return ret;
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_ContentControl(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

