#pragma checksum "C:\Users\Youcode\Desktop\Les briefs\Application-web-reservation-en-ligne\AppReservation\AppReservation\Views\Reservation\History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60c952483ca637de41aa68fc5ddd1941dae8ba23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_History), @"mvc.1.0.view", @"/Views/Reservation/History.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Youcode\Desktop\Les briefs\Application-web-reservation-en-ligne\AppReservation\AppReservation\Views\_ViewImports.cshtml"
using AppReservation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Youcode\Desktop\Les briefs\Application-web-reservation-en-ligne\AppReservation\AppReservation\Views\_ViewImports.cshtml"
using AppReservation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60c952483ca637de41aa68fc5ddd1941dae8ba23", @"/Views/Reservation/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3abc0244c2e76f85c560934579ce03deb7921df", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppReservation.Models.Reservation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<table id=\"mytable\" class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\Youcode\Desktop\Les briefs\Application-web-reservation-en-ligne\AppReservation\AppReservation\Views\Reservation\History.cshtml"
           Write(Html.DisplayNameFor(model => model.Student.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\Youcode\Desktop\Les briefs\Application-web-reservation-en-ligne\AppReservation\AppReservation\Views\Reservation\History.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\Youcode\Desktop\Les briefs\Application-web-reservation-en-ligne\AppReservation\AppReservation\Views\Reservation\History.cshtml"
           Write(Html.DisplayNameFor(model => model.Reserv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\Youcode\Desktop\Les briefs\Application-web-reservation-en-ligne\AppReservation\AppReservation\Views\Reservation\History.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\Youcode\Desktop\Les briefs\Application-web-reservation-en-ligne\AppReservation\AppReservation\Views\Reservation\History.cshtml"
           Write(Html.DisplayNameFor(model => model.Cause));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\Youcode\Desktop\Les briefs\Application-web-reservation-en-ligne\AppReservation\AppReservation\Views\Reservation\History.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Youcode\Desktop\Les briefs\Application-web-reservation-en-ligne\AppReservation\AppReservation\Views\Reservation\History.cshtml"
           Write(Html.DisplayFor(modelItem => item.Student.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\Youcode\Desktop\Les briefs\Application-web-reservation-en-ligne\AppReservation\AppReservation\Views\Reservation\History.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\Youcode\Desktop\Les briefs\Application-web-reservation-en-ligne\AppReservation\AppReservation\Views\Reservation\History.cshtml"
           Write(Html.DisplayFor(modelItem => item.Reserv.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n\r\n");
            WriteLiteral("\r\n                ");
#nullable restore
#line 53 "C:\Users\Youcode\Desktop\Les briefs\Application-web-reservation-en-ligne\AppReservation\AppReservation\Views\Reservation\History.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status, "w-25"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\Youcode\Desktop\Les briefs\Application-web-reservation-en-ligne\AppReservation\AppReservation\Views\Reservation\History.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cause));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 61 "C:\Users\Youcode\Desktop\Les briefs\Application-web-reservation-en-ligne\AppReservation\AppReservation\Views\Reservation\History.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<script>\r\n\r\n    let changeDate = () => {\r\n        this.parentElement.submit();\r\n    }\r\n\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppReservation.Models.Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
