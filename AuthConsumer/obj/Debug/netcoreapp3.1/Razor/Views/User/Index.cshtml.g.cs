#pragma checksum "C:\Users\892781\source\repos\Project\AuthConsumer\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e38cc62bbab3cdb161c6ccdc02f2c97719346bb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\892781\source\repos\Project\AuthConsumer\Views\_ViewImports.cshtml"
using AuthConsumer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\892781\source\repos\Project\AuthConsumer\Views\_ViewImports.cshtml"
using AuthConsumer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\892781\source\repos\Project\AuthConsumer\Views\User\Index.cshtml"
using Microsoft.AspNetCore.Razor.Language.Intermediate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e38cc62bbab3cdb161c6ccdc02f2c97719346bb6", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e471e481fed3889c745f9d0c75b217414a09ad", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\892781\source\repos\Project\AuthConsumer\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container border my-lg-5 "">
    <div class=""row p-5"">
        <div class=""col-12 justify-content-center""><h2>Schedule Meeting</h2></div>
        <div class=""col-12""><p>Schedule the meetings between Doctors and Representatives for next 5 days</p></div>
        <div class=""col-12"">");
#nullable restore
#line 12 "C:\Users\892781\source\repos\Project\AuthConsumer\Views\User\Index.cshtml"
                       Write(Html.ActionLink("Get products","Index1","Product",null,new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
    </div>
</div>
<div class=""container border my-lg-5"">
    <div class=""row p-5"">
        <div class=""col-12 justify-content-center""><h2>Supply Distribution</h2></div>
        <div class=""col-12""><p>Supply Medicines to all Pharmacies equally based on Demand and Stock Availability.</p></div>
        <div class=""col-12"">");
#nullable restore
#line 19 "C:\Users\892781\source\repos\Project\AuthConsumer\Views\User\Index.cshtml"
                       Write(Html.ActionLink("Supply Medicine", "Index", "Demand", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
