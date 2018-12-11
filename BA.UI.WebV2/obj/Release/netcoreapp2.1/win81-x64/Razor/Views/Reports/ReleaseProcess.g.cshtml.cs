#pragma checksum "D:\Projects\Approval\Main\BA.UI.WebV2\Views\Reports\ReleaseProcess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbb79cb2c01c756e8d84a75cdd4142e320a2586a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_ReleaseProcess), @"mvc.1.0.view", @"/Views/Reports/ReleaseProcess.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reports/ReleaseProcess.cshtml", typeof(AspNetCore.Views_Reports_ReleaseProcess))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbb79cb2c01c756e8d84a75cdd4142e320a2586a", @"/Views/Reports/ReleaseProcess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8874ec88ee98e7561abd1fa4263f3b4d44392e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_ReleaseProcess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1619, true);
            WriteLiteral(@"<section class=""content-header"">
    <h1>
        Reports
        <small>Release Approval Process </small>
    </h1>
</section>
<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""col-md-12"">
                <div class=""box"" style=""display:inherit;"">
                    <div class=""box-header"">
                        <div class=""row"">
                            <div class=""form-group top-35"">
                                <div class=""col-md-4"">
                                    <label class=""col-md-2 top-5"">Date</label>
                                    <div class=""col-md-10"">
                                        <div class=""input-group-sm"">
                                            <span class=""fa fa-calendar form-control-feedback left-feedback""></span>
                                            <input id=""releasedaterange"" class=""form-control input-sm text-bold left-feedback text-blue"" />
           ");
            WriteLiteral(@"                             </div>
                                    </div>

                                </div>

                                <div class=""col-md-4"">
                                    <button id=""btnprocessreport"" class=""btn btn-sm btn-success""><i class="" fa fa-folder-open""></i> Generate Report</button>
                                </div>
                            </div>
                        </div>
                    </div>
                    <hr />
                    <div class=""box-body"">
                        <iframe id=""reportframe""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1619, "\"", 1663, 1);
#line 35 "D:\Projects\Approval\Main\BA.UI.WebV2\Views\Reports\ReleaseProcess.cshtml"
WriteAttributeValue("", 1625, Url.Content("~/reports/printpreview"), 1625, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1664, 381, true);
            WriteLiteral(@" width=""100%"" scrolling=""no"" style=""overflow:hidden;border:0px;"" height=""1400""></iframe>

                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<script>
    var releaseProcess;
    $(document).ready(function () {

        releaseProcess = new ReleaseProcess();
        releaseProcess.init();
    })

</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
