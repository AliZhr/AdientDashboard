#pragma checksum "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "848c937eec95a1e30d400b6a5e52e249914e13f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Visu_Index), @"mvc.1.0.view", @"/Views/Visu/Index.cshtml")]
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
#line 1 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\_ViewImports.cshtml"
using Adient_DashBoard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\_ViewImports.cshtml"
using Adient_DashBoard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"848c937eec95a1e30d400b6a5e52e249914e13f7", @"/Views/Visu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"997e00e534afdcd42ae45499061545fb6b76e7a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Visu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml"
  
	ViewData["Title"] = "Menu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<h1 class=\"text-center\">");
#nullable restore
#line 4 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml"
                       Write(ViewBag.homepage.FTranslation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-md-auto\">\r\n");
#nullable restore
#line 8 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml"
             if (@ViewBag.CurrentUserId == null)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"card text-center border-dark w-75\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h5 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml"
                                          Write(ViewBag.login.FTranslation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t\t\t\t\t<p class=\"card-text\">");
#nullable restore
#line 13 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml"
                                        Write(ViewBag.login_mess.FTranslation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t");
#nullable restore
#line 14 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml"
                   Write(Html.ActionLink((string) @ViewBag.login.FTranslation, "Connexion", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 17 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\t</div>\r\n\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-sm-6\">\r\n");
#nullable restore
#line 23 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml"
             if (@ViewBag.CurrentUserId != null)
			{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"card text-center border-dark\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h5 class=\"card-title\">");
#nullable restore
#line 28 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml"
                                          Write(ViewBag.Navbar1.FTranslation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t\t\t\t\t");
#nullable restore
#line 29 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml"
                   Write(Html.ActionLink((string) @ViewBag.headcount_prod.FTranslation, "ListeTagesreport", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 32 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\t\t<div class=\"col-sm-6\">\r\n");
#nullable restore
#line 35 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml"
             if (@ViewBag.CurrentUserId != null)
			{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"card text-center border-dark\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h5 class=\"card-title\" >");
#nullable restore
#line 40 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml"
                                           Write(ViewBag.statusITsys.FTranslation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t\t\t\t\t");
#nullable restore
#line 41 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml"
                   Write(Html.ActionLink((string) @ViewBag.see.FTranslation, "ListeTagesreport", new { }, new { @class = "btn btn-success disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 44 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\t</div>\r\n\t<br />\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-sm-6\">\r\n");
#nullable restore
#line 50 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml"
             if (@ViewBag.CurrentUserId != null)
			{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"card text-center border-dark\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h5 class=\"card-title\">");
#nullable restore
#line 55 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml"
                                          Write(ViewBag.efficiency.FTranslation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t\t\t\t\t");
#nullable restore
#line 56 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml"
                   Write(Html.ActionLink((string) @ViewBag.see.FTranslation, "ListeTagesreport", new { }, new { @class = "btn btn-success disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 59 "C:\Users\Alith\Desktop\to send STAGE\to send\VisualStudio Projects\Adient-DashBoard\Adient-DashBoard\Views\Visu\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\t\t\r\n\t</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
