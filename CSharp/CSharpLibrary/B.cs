//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace LibraryNamespace {

public class B : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal B(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(B obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~B() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          CSharpWrapperPINVOKE.delete_B(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void SetA(A p) {
    CSharpWrapperPINVOKE.B_SetA(swigCPtr, A.getCPtr(p));
    if (CSharpWrapperPINVOKE.SWIGPendingException.Pending) throw CSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string CallA() {
    string ret = CSharpWrapperPINVOKE.B_CallA(swigCPtr);
    if (CSharpWrapperPINVOKE.SWIGPendingException.Pending) throw CSharpWrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public B() : this(CSharpWrapperPINVOKE.new_B(), true) {
  }

}

}
