//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Cef3
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Cef3.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefBrowserHost : IDisposable
    {
        internal static CefBrowserHost FromNative(cef_browser_host_t* ptr)
        {
            return new CefBrowserHost(ptr);
        }
        
        internal static CefBrowserHost FromNativeOrNull(cef_browser_host_t* ptr)
        {
            if (ptr == null) return null;
            return new CefBrowserHost(ptr);
        }
        
        private cef_browser_host_t* _self;
        
        private CefBrowserHost(cef_browser_host_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefBrowserHost()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
            GC.SuppressFinalize(this);
        }
        
        internal int AddRef()
        {
            return cef_browser_host_t.add_ref(_self);
        }
        
        internal int Release()
        {
            return cef_browser_host_t.release(_self);
        }
        
        internal int RefCt
        {
            get { return cef_browser_host_t.get_refct(_self); }
        }
        
        internal cef_browser_host_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
