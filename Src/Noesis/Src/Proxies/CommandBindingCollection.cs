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

public class CommandBindingCollection : UICollection<CommandBinding> {
  internal new static CommandBindingCollection CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new CommandBindingCollection(cPtr, cMemoryOwn);
  }

  internal CommandBindingCollection(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(CommandBindingCollection obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.CommandBindingCollection_GetStaticType();
    return ret;
  }

  public CommandBindingCollection() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_CommandBindingCollection();
  }

}

}

