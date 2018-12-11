#pragma checksum "D:\Projects\Approval\Main\BA.UI.WebV2\Views\File\ApprovalRequestCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf5a2fc50002c59a7b019babe8f206b722bb5f60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_File_ApprovalRequestCreate), @"mvc.1.0.view", @"/Views/File/ApprovalRequestCreate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/File/ApprovalRequestCreate.cshtml", typeof(AspNetCore.Views_File_ApprovalRequestCreate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf5a2fc50002c59a7b019babe8f206b722bb5f60", @"/Views/File/ApprovalRequestCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8874ec88ee98e7561abd1fa4263f3b4d44392e4", @"/Views/_ViewImports.cshtml")]
    public class Views_File_ApprovalRequestCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 425, true);
            WriteLiteral(@"



<section class=""content-header"">
    <h1>
        File
        <small>Create Approval Request</small>
    </h1>

    <ol class=""breadcrumb"">
        <li> <a id=""backtolist"" href=""#"" class=""pull-right text-blue"" style=""font-size:15px;""> <i class=""fa fa-th-list""></i> Request List</a></li>
    </ol>


</section>
<!-- Main content -->
<section class=""content"">
    <input class=""hidden"" id=""currentuserid""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 425, "\"", 455, 1);
#line 19 "D:\Projects\Approval\Main\BA.UI.WebV2\Views\File\ApprovalRequestCreate.cshtml"
WriteAttributeValue("", 433, ViewBag.CurrentUserId, 433, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(456, 15319, true);
            WriteLiteral(@" />
    <div class=""row"">

        <div class=""col-md-12"">
            <div class=""bs-stepper"">
                <div class=""bs-stepper-header"" role=""tablist"">
                    <!-- your steps here -->
                    <div class=""step"" data-target=""#info-part"">
                        <button type=""button"" class=""btn btn-link step-trigger"" role=""tab"" aria-controls=""info-part"" id=""info-part-trigger"">
                            <span class=""bs-stepper-circle"">1</span>
                            <span class=""bs-stepper-label"">Patient Information</span>
                        </button>
                    </div>
                    <div class=""line""></div>
                    <div class=""step"" data-target=""#test-part"">
                        <button type=""button"" class=""btn btn-link step-trigger"" role=""tab"" aria-controls=""test-part"" id=""test-part-trigger"">
                            <span class=""bs-stepper-circle"">2</span>
                            <span class=""bs-stepper-label"">Test");
            WriteLiteral(@" & Procedures</span>
                        </button>
                    </div>

                    <div class=""line""></div>
                    <div class=""step"" data-target=""#complete-part"">
                        <button type=""button"" class=""btn btn-link step-trigger"" role=""tab"" aria-controls=""complete-part"" id=""complete-part-trigger"">
                            <span class=""bs-stepper-circle"">3</span>
                            <span class=""bs-stepper-label"">Complete</span>
                        </button>
                    </div>
                </div>
                <div class=""bs-stepper-content"">
                    <!-- your steps content here -->
                    <div id=""info-part"" class=""content"" role=""tabpanel"" aria-labelledby=""info-part-trigger"" style=""background-color:white !important; border: 1px solid #dedddd;"">
                        <div class=""row"">
                                    <div class=""form-group"">
                                        <div class");
            WriteLiteral(@"=""col-md-12"">
                                            <button class=""btn btn-sm btn-primary pull-right"" style=""width:100px;"" onclick=""approvalrequestcreateScript.ProceedToItem()"">Next <i class=""glyphicon glyphicon-circle-arrow-right""></i> </button>
                                            <button class=""btn btn-sm btn-primary pull-left"" style=""width:100px;"" onclick=""stepper.previous()"" disabled><i class=""glyphicon glyphicon-circle-arrow-left""></i> Previous</button>
                                        </div>
                                    </div>
                          
                                    <div class=""form-group"">
                                        <div class=""col-md-3 top-15"">
                                            <label>Request Type</label>
                                            <select id=""approvalrequesttypeid"" class=""form-control input-sm""></select>
                                        </div>

                                        <div cla");
            WriteLiteral(@"ss=""col-md-3 top-15"">
                                            <label>Patient Type</label>
                                            <select id=""patienttypeid"" class=""form-control input-sm""></select>
                                        </div>

                                        <div class=""col-md-6 top-15"">
                                            <label>Patient</label>
                                            <div class="""">
                                                <select id=""opregistrationno"" class=""form-control input-sm""></select>
                                            </div>
                                            <div class="""">
                                                <select id=""ipregistrationno"" class=""form-control input-sm""> </select>
                                            </div>
                                        </div>
                                    </div>

                                    <div class=""form-group "">
       ");
            WriteLiteral(@"                                 <div class=""col-md-3 top-15"">
                                            <label>Category</label>
                                            <select id=""categoryid"" class=""form-control input-sm"" style=""width:100%;""></select>
                                        </div>

                                        <div class=""col-md-6 top-15"">
                                            <label>Company</label>
                                            <select id=""companyid"" class=""form-control input-sm"" style=""width:100%;""></select>
                                        </div>

                                        <div class=""col-md-3 top-15"">
                                            <label>Grade</label>
                                            <select id=""gradeid"" class=""form-control input-sm"" style=""width:100%;""></select>
                                        </div>
                                    </div>

                                    <d");
            WriteLiteral(@"iv class=""form-group "">
                                        <div class=""col-md-4 top-15"">
                                            <label>Contact No.</label>
                                            <input id=""contactnos"" class=""form-control input-sm text-bold text-navy"" readonly=""readonly"" />
                                        </div>
                                        <div class=""col-md-4 top-15"">
                                            <label>Insurance Card No.</label>
                                            <input id=""insurancecardno"" class=""form-control input-sm text-bold text-navy"" readonly=""readonly"" />
                                        </div>
                                        <div class=""col-md-4 top-15"">
                                            <label>Authority ID</label>
                                            <input id=""authorityid"" class=""form-control input-sm text-bold text-navy"" readonly=""readonly"" />
                                     ");
            WriteLiteral(@"   </div>
                                    </div>

                                    <div class=""form-group "">
                                        <div class=""col-md-6 top-15"">
                                            <label>Doctor</label>
                                            <select id=""doctorid"" class=""form-control input-sm""></select>
                                        </div>
                                    </div>


                                    <div class=""form-group "">
                                        <div class=""col-md-12 top-20"">
                                            <label>Clinical Data</label>
                                            <textarea id=""clinicaldata"" class=""form-control"" rows=""15"" style=""background-color:wheat;resize:none;""></textarea>
                                        </div>
                                    </div>
                                </div>
                    </div>
                    <div id=""test-");
            WriteLiteral(@"part"" class=""content"" role=""tabpanel"" aria-labelledby=""test-part-trigger""  style=""background-color:white !important;border: 1px solid #dedddd;min-height:750px;"">
                        <div class=""row"">
                            <div class=""form-group"">
                                <div class=""col-md-12"">
                                    <button class=""btn btn-sm btn-primary pull-right"" style=""width:100px;"" disabled>Next <i class=""glyphicon glyphicon-circle-arrow-right""></i> </button>
                                    <button class=""btn btn-sm btn-primary pull-left"" style=""width:100px;"" onclick=""stepper.previous()""><i class=""glyphicon glyphicon-circle-arrow-left""></i> Previous</button>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""col-md-12 top-35"">
                                    <button class=""btn btn-sm btn-file"" href=""#"" onclick=""approvalrequestcreateScript.");
            WriteLiteral(@"ShowModal()"" style=""width:150px;""><i class=""glyphicon glyphicon-plus-sign""></i> <b>ADD ITEM</b> </button>
                                    <button class=""btn btn-sm btn-success"" href=""#"" onclick=""approvalrequestcreateScript.ConfirmSubmit(approvalrequestcreateScript)""><i class=""glyphicon glyphicon-upload""></i> <b>SUBMIT REQUEST</b> </button>
                                </div>
                                </div>
                            </div>

                            <div class=""form-group"">
                                <div class=""col-md-12 top-15"">
                                   <table id =""tbltestprocedures""class=""table table-striped"" style=""width:100%;"">
                                       <thead>
                                       </thead>
                                       <tbody>
                                       </tbody>
                                   </table>
                                </div>
                            </div>
          ");
            WriteLiteral(@"              </div>
                        </div>
                    <div id=""complete-part"" class=""content"" role=""tabpanel"" aria-labelledby=""complete-part-trigger""  style=""background-color:white !important;min-height:750px; border: 1px solid #dedddd;"">
                        <div class=""row top-20"">
                            <div class=""form-group"">
                                <div class=""col-md-12 top-40"" >
                                    <div class=""col-md-12 top-40"">
                                        <center>
                                            <span style=""font-size: 25px;font-weight: 500;"" class=""text-gray-darker"">REQUEST FOR APPORVAL WAS SUCCESSFULLY SUBMITTED</span>
                                        </center>
                                    </div>
                                    <div class=""col-md-12 top-20"">
                                         <center> 
                                            <button id=""createnew"" class=""btn btn-primary");
            WriteLiteral(@"""><i class=""fa fa-plus-circle""></i> CREATE NEW </button>
                                         </center>
                                    </div>
                                   
                                  
                                </div>
                            </div>
                        </div>
                    </div>
                    </div>
            </div>
        </div>
    </div>
</section>
<!-- /.content -->


<div class=""modal fade"" id=""modalitem"" style=""display: none;"">
    <div class=""modal-dialog"">
        <div class=""modal-content"" style=""border-radius:4px; top:50px;"">
            <div class=""modal-header"">
                <h4 class=""modal-title""><i class=""fa fa-edit text-blue""></i> <span id=""popupitemheader""> Add Item</span> </h4>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-md-12 top-10"">
                        <div class=""form-group"">
                ");
            WriteLiteral(@"            <label class=""form-label col-md-12"">Services</label>
                            <div class=""col-md-12"">
                                <select id=""opipserviceid"" class=""form-control input-sm"" style=""width:100%;""></select>
                            </div>
                        </div>
                    </div>

                    <div class=""col-md-12 top-10"">
                        <div class=""form-group"">
                            <label class=""form-label col-md-12"">Item / Procedure</label>
                            <div class=""col-md-12"">
                                <select id=""serviceitemid"" class=""form-control input-sm"" style=""width:100%;""></select>
                            </div>
                        </div>
                    </div>

                    <div class=""col-md-12 top-15"">
                        <div class=""form-group"">
                            <div class=""col-md-3"">
                                <label class=""form-label row col-md-12");
            WriteLiteral(@""" >Price</label>
                                <input id=""price"" class=""input-sm form-control text-navy text-bold text-right"" readonly />
                            </div>

                            <div class=""col-md-6"">
                                <div class=""col-md-4 row"">
                                    <label class=""form-label col-md-12 row"">Quantity</label>
                                    <input id=""quantity"" class=""input-sm form-control text-navy text-bold"" />
                                </div>
                                <div class=""col-md-8"">
                                    <label class=""form-label col-md-12 row "">Unit</label>
                                    <div class=""col-md-12"" style=""padding-left:0px;padding-right:0px;"">
                                        <select id=""unitid"" class=""form-control input-sm"" style=""width:100%;""></select>
                                    </div>
                                </div>
                            </");
            WriteLiteral(@"div>

                            <div class=""col-md-3"">
                                <label class=""form-label col-md-12 row"">Amount</label>
                                <input id=""amount"" class=""input-sm form-control text-bold text-navy text-right"" readonly />
                            </div>
                        </div>
                    </div>


                    <div class=""col-md-12 top-10"">
                        <div class=""form-group"">
                            <label class=""form-label col-md-12"">Remarks</label>
                            <div class=""col-md-12"">
                                <textarea id=""itemremarks"" class=""form-control bg-wheat-light"" rows=""5"" style=""resize:none;""></textarea>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <input id=""rownumber"" class=""hidden"" />
                <button type=""button"" ");
            WriteLiteral(@"class=""btn btn-default pull-left"" data-dismiss=""modal"" style=""width:95px;"">CLOSE</button>
                <button id=""btnremoveitem"" type=""button"" class=""btn btn-danger""><i class=""fa fa-trash-o""></i> Remove</button>
                <button id=""btnadditem"" type=""button"" class=""btn btn-primary"" style=""width:95px;""><i class=""fa fa-plus-circle""></i> Add</button>
                <button id=""btnupdateitem"" type=""button"" class=""btn btn-primary"" style=""width:95px;""><i class=""fa fa-pencil""></i> Update</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>

<script>
    var approvalrequestcreateScript;
    var stepper;

    $(document).ready(function () {
        stepper = new Stepper($('.bs-stepper')[0]);
        approvalrequestcreateScript = new BillingApprovalCreate();
        approvalrequestcreateScript.init();

        stepper = new Stepper($('.bs-stepper')[0]);

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
