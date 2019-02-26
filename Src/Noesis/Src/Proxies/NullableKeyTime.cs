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

[StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
internal struct NullableKeyTime {

  [MarshalAs(UnmanagedType.U1)]
  private bool _hasValue;
  private KeyTime _value;

  public bool HasValue { get { return this._hasValue; } }

  public KeyTime Value {
    get {
      if (!HasValue) {
        throw new InvalidOperationException("Nullable does not have a value");
      }
      return this._value;
    }
  }

  public NullableKeyTime(KeyTime v) {
    this._hasValue = true;
    this._value = v;
  }

  public static explicit operator KeyTime(NullableKeyTime n) {
    if (!n.HasValue) {
      throw new InvalidOperationException("Nullable does not have a value");
    }
    return n.Value;
  }

  public static implicit operator NullableKeyTime(KeyTime v) {
    return new NullableKeyTime(v);
  }

  public static implicit operator Nullable<KeyTime>(NullableKeyTime n) {
    return n.HasValue ? new Nullable<KeyTime>(n.Value) : new Nullable<KeyTime>();
  }

  public static implicit operator NullableKeyTime(Nullable<KeyTime> n) {
    return n.HasValue ? new NullableKeyTime(n.Value) : new NullableKeyTime();
  }

  public static bool operator==(NullableKeyTime n, KeyTime v) {
    return n.HasValue && n.Value == v;
  }

  public static bool operator!=(NullableKeyTime n, KeyTime v) {
    return !(n == v);
  }

  public static bool operator==(KeyTime v, NullableKeyTime n) {
    return n == v;
  }
  
  public static bool operator!=(KeyTime v, NullableKeyTime n) {
    return n != v;
  }

  public static bool operator==(NullableKeyTime n0, NullableKeyTime n1) {
    return n0.HasValue && n1.HasValue ? n0.Value == n1.Value : n0.HasValue == n1.HasValue;
  }

  public static bool operator!=(NullableKeyTime n0, NullableKeyTime n1) {
    return !(n0 == n1);
  }

  public override bool Equals(System.Object obj) {
    return obj is NullableKeyTime && this == (NullableKeyTime)obj;
  }

  public bool Equals(NullableKeyTime n) {
    return this == n;
  }

  public override int GetHashCode() {
    return HasValue ? Value.GetHashCode() : 0;
  }

}

}

