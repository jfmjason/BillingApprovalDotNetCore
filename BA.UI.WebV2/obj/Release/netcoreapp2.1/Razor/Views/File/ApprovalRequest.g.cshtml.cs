#pragma checksum "D:\Projects\Approval\Main\BA.UI.WebV2\Views\File\ApprovalRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62b77d0ef87b5fcbe096b2d02962a315ddf8bed4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_File_ApprovalRequest), @"mvc.1.0.view", @"/Views/File/ApprovalRequest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/File/ApprovalRequest.cshtml", typeof(AspNetCore.Views_File_ApprovalRequest))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62b77d0ef87b5fcbe096b2d02962a315ddf8bed4", @"/Views/File/ApprovalRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8874ec88ee98e7561abd1fa4263f3b4d44392e4", @"/Views/_ViewImports.cshtml")]
    public class Views_File_ApprovalRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2552, true);
            WriteLiteral(@"

<section class=""content-header"">
    <h1>
        File
        <small>Billing Approval </small>
    </h1>
</section>
<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""col-md-12"">
                <div class=""box"" style=""display:inherit;"">
                    <div class=""box-header"">
                        <h3 class=""box-title"">Approval Request</h3>
                        <div class=""row"">
                            <div class=""form-group top-35"">
                                <div class=""col-md-4"">
                                    <label class=""col-md-2 top-5"">Date</label>
                                    <div class=""col-md-10"">
                                        <div class=""input-group-sm"">
                                            <span class=""fa fa-calendar form-control-feedback left-feedback""></span>
                                            <input id=""requestdaterange"" class=""form-contr");
            WriteLiteral(@"ol input-sm text-bold left-feedback text-blue"" />
                                        </div>
                                    </div>

                                </div>

                                <div class=""col-md-4"">
                                    <label class=""col-md-2 top-5"">Category</label>
                                    <div class=""col-md-10"">

                                        <select id=""sel2category"" class=""form-control input input-sm""></select>

                                    </div>
                                </div>

                                <div class=""col-md-4"">
                                    <button id=""btnfindrequest"" class=""btn btn-sm btn-success""><i class="" fa fa-search""></i> Find</button>
                                </div>
                            </div>
                        </div>
                    </div>
                    <hr />
                    <div class=""box-body table-responsive"">

          ");
            WriteLiteral(@"              <table id=""data-items"" class=""table table-hover table-striped"">
                            <thead class=""bg-wheat"">
                                <tr></tr>
                            </thead>
                            <tbody>
                                <tr></tr>
                            </tbody>
                        </table>

                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- /.content -->


");
            EndContext();
            BeginContext(2626, 183, true);
            WriteLiteral("\r\n<script>\r\n    var requestScript;\r\n\r\n    $(document).ready(function () {\r\n\r\n        requestScript = new BillingApproval();\r\n\r\n        requestScript.init();\r\n\r\n    })\r\n\r\n</script>\r\n\r\n");
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
