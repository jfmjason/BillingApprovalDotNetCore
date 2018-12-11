#pragma checksum "D:\Projects\Approval\Main\BA.UI.WebV2\Views\MasterFile\PatientType.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3d0c6acb4a9ae17667785b55c79884b641299e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MasterFile_PatientType), @"mvc.1.0.view", @"/Views/MasterFile/PatientType.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MasterFile/PatientType.cshtml", typeof(AspNetCore.Views_MasterFile_PatientType))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d0c6acb4a9ae17667785b55c79884b641299e5", @"/Views/MasterFile/PatientType.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8874ec88ee98e7561abd1fa4263f3b4d44392e4", @"/Views/_ViewImports.cshtml")]
    public class Views_MasterFile_PatientType : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 114, true);
            WriteLiteral("<section class=\"content-header\">\r\n    <h1>\r\n        Master File\r\n        <small>Patient Type </small>\r\n    </h1>\r\n");
            EndContext();
            BeginContext(337, 2572, true);
            WriteLiteral(@"</section>
<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""box box-success"" style=""min-height:300px;"">
                <div class=""box-header"">
                    <a id=""newentry"" href=""#"" class=""pull-left"" style=""font-size:18px;text-decoration:underline;"">
                        <i class=""fa fa-pencil-square-o""></i> Create New
                    </a>
                    <i class=""fa fa-pencil pull-right""></i>

                </div>
                <div class=""box-body"">
                    <div class=""form"">
                        <input id=""patienttypeid"" class=""hidden"" />
                        <div class=""form-group"">
                            <label> Description</label>
                            <input id=""description"" class=""form-control"" />
                        </div>

                        <div class=""form-group"">
                            <label> Code </label>
                         ");
            WriteLiteral(@"   <input id=""code"" class=""form-control"" />
                        </div>

                    </div>

                </div>

                <div class=""box-footer"">
                    <button id=""updateentry"" class=""btn btn-success pull-right top-20 "" style=""margin-left:5px;""><i class=""fa fa-save""></i> Update</button>
                    <button id=""deleteentry"" class=""btn btn-danger pull-right top-20 "" style=""margin-left:5px;""><i class=""fa fa-remove""></i> Delete</button>

                    <button id=""saveentry"" class=""btn btn-success pull-right top-20"" style=""margin-left:5px;""> <i class=""fa fa-save""></i> Create</button>
                    <button id=""clearentry"" class=""btn btn-default pull-right top-20""><i class=""fa fa-eraser""></i> Clear</button>

                </div>
            </div>

        </div>
        <div class=""col-md-8"">
            <div class=""box"" style=""min-height:800px;"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Patient");
            WriteLiteral(@" Types</h3>
                </div>
                <div class=""box-body table-responsive "">

                    <table id=""data-items"" class=""table table-hover"">
                        <thead>
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
</section>
<!-- /.content -->


");
            EndContext();
            BeginContext(2985, 179, true);
            WriteLiteral("\r\n<script>\r\n    var requestScript;\r\n\r\n    $(document).ready(function () {\r\n\r\n        requestScript = new PatientType();\r\n\r\n        requestScript.init();\r\n\r\n    })\r\n\r\n</script>\r\n\r\n");
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
