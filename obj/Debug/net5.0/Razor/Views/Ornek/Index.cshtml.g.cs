#pragma checksum "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc605d2f8b21e2fe9f5736e6030682a6b2613f40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ornek_Index), @"mvc.1.0.view", @"/Views/Ornek/Index.cshtml")]
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
#line 1 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\_ViewImports.cshtml"
using MyAspNetCoreApp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\_ViewImports.cshtml"
using MyAspNetCoreApp.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
using MyAspNetCoreApp.Web.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc605d2f8b21e2fe9f5736e6030682a6b2613f40", @"/Views/Ornek/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3db5664a1893df5b233ee00dcf6406dd1f670d91", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Ornek_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product2>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
 foreach (var item in Model)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<p>");
#nullable restore
#line 10 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 10 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
                 Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p> \r\n");
#nullable restore
#line 11 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Ornek Controller, Index sayfası</h1>\r\n\r\n<div>Günün tarihi : ");
#nullable restore
#line 16 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
               Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div\r\n>\r\n");
#nullable restore
#line 18 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
   
    var datetime = DateTime.Now.ToShortDateString();
	var message = "merhaba";


#line default
#line hidden
#nullable disable
            WriteLiteral("\t");
            WriteLiteral(" bugünün tarihi : ");
#nullable restore
#line 22 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
                   Write(datetime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t<div>mesaj : ");
#nullable restore
#line 23 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
            Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
 if (1==1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<p>doğru</p>\r\n");
#nullable restore
#line 30 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
}else if (DateTime.IsLeapYear(DateTime.Now.Year)){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<p>artık yıl</p>\r\n");
#nullable restore
#line 32 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
 }
 else{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<p>yanlış</p>\r\n");
#nullable restore
#line 35 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
 for (int i = 0; i < 10; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<p>");
#nullable restore
#line 39 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 40 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
 foreach (var item in Enumerable.Range(1,10).ToList())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<p>");
#nullable restore
#line 44 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
  Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 45 "C:\Users\LENOVO\source\repos\MyAspNetCoreApp\MyAspNetCoreApp.Web\Views\Ornek\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product2>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
