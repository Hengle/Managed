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

public class HeaderedContentControl : ContentControl {
  internal new static HeaderedContentControl CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new HeaderedContentControl(cPtr, cMemoryOwn);
  }

  internal HeaderedContentControl(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(HeaderedContentControl obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public HeaderedContentControl() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if ((object)type.TypeHandle == typeof(HeaderedContentControl).TypeHandle) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_HeaderedContentControl();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static DependencyProperty HasHeaderProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.HeaderedContentControl_HasHeaderProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty HeaderProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.HeaderedContentControl_HeaderProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty HeaderTemplateProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.HeaderedContentControl_HeaderTemplateProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty HeaderTemplateSelectorProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.HeaderedContentControl_HeaderTemplateSelectorProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool HasHeader {
    get {
      bool ret = NoesisGUI_PINVOKE.HeaderedContentControl_HasHeader_get(swigCPtr);
      return ret;
    } 
  }

  public object Header {
    set {
      NoesisGUI_PINVOKE.HeaderedContentControl_Header_set(swigCPtr, Noesis.Extend.GetInstanceHandle(value));
    }
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.HeaderedContentControl_Header_get(swigCPtr);
      return Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public DataTemplate HeaderTemplate {
    set {
      NoesisGUI_PINVOKE.HeaderedContentControl_HeaderTemplate_set(swigCPtr, DataTemplate.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.HeaderedContentControl_HeaderTemplate_get(swigCPtr);
      return (DataTemplate)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public DataTemplateSelector HeaderTemplateSelector {
    set {
      NoesisGUI_PINVOKE.HeaderedContentControl_HeaderTemplateSelector_set(swigCPtr, DataTemplateSelector.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.HeaderedContentControl_HeaderTemplateSelector_get(swigCPtr);
      return (DataTemplateSelector)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.HeaderedContentControl_GetStaticType();
    return ret;
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_HeaderedContentControl(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

