#pragma checksum "D:\Projects\Approval\Main\BA.UI.WebV2\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d03d0c97a615bf28b843fad9a15447770a1e2c2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Menu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Menu_Default))]
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
#line 1 "D:\Projects\Approval\Main\BA.UI.WebV2\Views\_ViewImports.cshtml"
using BA.UI.WebV2;

#line default
#line hidden
#line 2 "D:\Projects\Approval\Main\BA.UI.WebV2\Views\_ViewImports.cshtml"
using BA.UI.WebV2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d03d0c97a615bf28b843fad9a15447770a1e2c2e", @"/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8874ec88ee98e7561abd1fa4263f3b4d44392e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BA.UI.WebV2.Models.MenuVm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\Approval\Main\BA.UI.WebV2\Views\Shared\Components\Menu\Default.cshtml"
 foreach (var parentmenu in Model)
{
    var icon = "";

    if (parentmenu.Id == 1)
    {
        icon = "fa-file-o";
    }
    else if (parentmenu.Id == 3)
    {
        icon = "fa-folder-open-o";
    }
    else if (parentmenu.Id == 4)
    {
        icon = "fa-gear";
    }
    else
    {
        icon = "fa-list";
    }



#line default
#line hidden
            BeginContext(396, 63, true);
            WriteLiteral("    <li class=\"treeview\">\r\n        <a href=\"#\">\r\n            <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 459, "\"", 475, 2);
            WriteAttributeValue("", 467, "fa", 467, 2, true);
#line 27 "D:\Projects\Approval\Main\BA.UI.WebV2\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue(" ", 469, icon, 470, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(476, 12, true);
            WriteLiteral("></i> <span>");
            EndContext();
            BeginContext(489, 15, false);
#line 27 "D:\Projects\Approval\Main\BA.UI.WebV2\Views\Shared\Components\Menu\Default.cshtml"
                                      Write(parentmenu.Name);

#line default
#line hidden
            EndContext();
            BeginContext(504, 190, true);
            WriteLiteral("</span>\r\n            <span class=\"pull-right-container\">\r\n                <i class=\"fa fa-angle-left pull-right\"></i>\r\n            </span>\r\n        </a>\r\n        <ul class=\"treeview-menu\">\r\n");
            EndContext();
#line 33 "D:\Projects\Approval\Main\BA.UI.WebV2\Views\Shared\Components\Menu\Default.cshtml"
             foreach (var sub in parentmenu.SubMenus)
            {

#line default
#line hidden
            BeginContext(764, 64, true);
            WriteLiteral("                <li>\r\n                    <a href=\"#\" data-url=\"");
            EndContext();
            BeginContext(829, 26, false);
#line 36 "D:\Projects\Approval\Main\BA.UI.WebV2\Views\Shared\Components\Menu\Default.cshtml"
                                     Write(Url.Content(sub.UrlAction));

#line default
#line hidden
            EndContext();
            BeginContext(855, 17, true);
            WriteLiteral("\" data-pagename=\"");
            EndContext();
            BeginContext(873, 8, false);
#line 36 "D:\Projects\Approval\Main\BA.UI.WebV2\Views\Shared\Components\Menu\Default.cshtml"
                                                                                 Write(sub.Name);

#line default
#line hidden
            EndContext();
            BeginContext(881, 104, true);
            WriteLiteral("\" class=\"text-ellipsis\" style=\"width:225px;\">\r\n\r\n                        <i class=\"fa fa-circle-o\"></i> ");
            EndContext();
            BeginContext(986, 8, false);
#line 38 "D:\Projects\Approval\Main\BA.UI.WebV2\Views\Shared\Components\Menu\Default.cshtml"
                                                  Write(sub.Name);

#line default
#line hidden
            EndContext();
            BeginContext(994, 53, true);
            WriteLiteral("\r\n                    </a>\r\n\r\n                </li>\r\n");
            EndContext();
#line 42 "D:\Projects\Approval\Main\BA.UI.WebV2\Views\Shared\Components\Menu\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(1062, 30, true);
            WriteLiteral("\r\n\r\n        </ul>\r\n    </li>\r\n");
            EndContext();
#line 47 "D:\Projects\Approval\Main\BA.UI.WebV2\Views\Shared\Components\Menu\Default.cshtml"

}

#line default
#line hidden
            BeginContext(1097, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BA.UI.WebV2.Models.MenuVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591