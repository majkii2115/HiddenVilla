using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenVilla_Server.Helper
{
    public static class IJSRuntimeExtension
    {
        public static async ValueTask ToastrSuccess(this IJSRuntime JsRuntime, string message)
        {
            await JsRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }
        public static async ValueTask ToastrFailure(this IJSRuntime JsRuntime, string message)
        {
            await JsRuntime.InvokeVoidAsync("ShowToastr", "error", message);
        }
        public static async ValueTask SwalSuccess(this IJSRuntime JsRuntime, string message)
        {
            await JsRuntime.InvokeVoidAsync("ShowSwal", "success", message);
        }
        public static async ValueTask SwalFailure(this IJSRuntime JsRuntime, string message)
        {
            await JsRuntime.InvokeVoidAsync("ShowSwal", "error", message);
        }

    }
}
