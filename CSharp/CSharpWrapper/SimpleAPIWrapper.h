/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.7
 *
 * This file is not intended to be easily readable and contains a number of
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG
 * interface file instead.
 * ----------------------------------------------------------------------------- */

#ifndef SWIG_CSharpWrapper_WRAP_H_
#define SWIG_CSharpWrapper_WRAP_H_

class SwigDirector_A : public A, public Swig::Director {

public:
    SwigDirector_A();
    virtual void SetName(std::string const &n);
    virtual std::string SayHello();
    virtual ~SwigDirector_A();

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)(char *);
    typedef char * (SWIGSTDCALL* SWIG_Callback1_t)();
    void swig_connect_director(SWIG_Callback0_t callbackSetName, SWIG_Callback1_t callbackSayHello);

private:
    SWIG_Callback0_t swig_callbackSetName;
    SWIG_Callback1_t swig_callbackSayHello;
    void swig_init_callbacks();
};


#endif
