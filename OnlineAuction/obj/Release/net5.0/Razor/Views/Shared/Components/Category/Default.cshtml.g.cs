#pragma checksum "D:\Aptech\Kì3\Project\OnlinAutionProject\OnlineAuction\Views\Shared\Components\Category\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce42d62d193e013124b06c2f11290b3fecfee901"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Category_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Category/Default.cshtml")]
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
#line 1 "D:\Aptech\Kì3\Project\OnlinAutionProject\OnlineAuction\Views\_ViewImports.cshtml"
using OnlineAuction;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Aptech\Kì3\Project\OnlinAutionProject\OnlineAuction\Views\_ViewImports.cshtml"
using OnlineAuction.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce42d62d193e013124b06c2f11290b3fecfee901", @"/Views/Shared/Components/Category/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36ee72f91feb8c750b5e6458a1b037392121c56c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Category_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineAuction.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"sub-menu\" style=\"width: 100%; display: none;\">\r\n    <div class=\"content\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 6 "D:\Aptech\Kì3\Project\OnlinAutionProject\OnlineAuction\Views\Shared\Components\Category\Default.cshtml"
           foreach (var category in Model)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3\">\r\n                <a href=\"category.html\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 326, "\"", 371, 2);
            WriteAttributeValue("", 332, "image/Category/", 332, 15, true);
#nullable restore
#line 10 "D:\Aptech\Kì3\Project\OnlinAutionProject\OnlineAuction\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 347, category.Category_Image, 347, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                         alt=\"banner4\">\r\n                </a>\r\n                <a href=\"category.html\" class=\"title-submenu\">");
#nullable restore
#line 13 "D:\Aptech\Kì3\Project\OnlinAutionProject\OnlineAuction\Views\Shared\Components\Category\Default.cshtml"
                                                         Write(category.Category_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-12 hover-menu\">\r\n                        <div class=\"menu\">\r\n                            <ul>\r\n");
#nullable restore
#line 18 "D:\Aptech\Kì3\Project\OnlinAutionProject\OnlineAuction\Views\Shared\Components\Category\Default.cshtml"
                                 foreach (var item in category.Sub_Categories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>\r\n                                        <a href=\"category.html \"\r\n                                           class=\"main-menu\">\r\n                                            ");
#nullable restore
#line 23 "D:\Aptech\Kì3\Project\OnlinAutionProject\OnlineAuction\Views\Shared\Components\Category\Default.cshtml"
                                       Write(item.Sub_Category_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n");
#nullable restore
#line 26 "D:\Aptech\Kì3\Project\OnlinAutionProject\OnlineAuction\Views\Shared\Components\Category\Default.cshtml"


                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 36 "D:\Aptech\Kì3\Project\OnlinAutionProject\OnlineAuction\Views\Shared\Components\Category\Default.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineAuction.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
