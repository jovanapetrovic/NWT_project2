#pragma checksum "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5917ab8dabb937e33d524357bf872cfdc32d15d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bugs_Index), @"mvc.1.0.view", @"/Views/Bugs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bugs/Index.cshtml", typeof(AspNetCore.Views_Bugs_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5917ab8dabb937e33d524357bf872cfdc32d15d6", @"/Views/Bugs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"491c1f558aef85392e6252b48a8de1f461811125", @"/Views/_ViewImports.cshtml")]
    public class Views_Bugs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bugster.Models.Bug>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(124, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 8 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
 if (ViewBag.IsRedirected && ViewBag.IsSuccessfull)
{

#line default
#line hidden
            BeginContext(179, 238, true);
            WriteLiteral("<div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\n    Success!\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\n        <span aria-hidden=\"true\">&times;</span>\n    </button>\n</div>\n");
            EndContext();
#line 16 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
}

#line default
#line hidden
#line 17 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
 if (ViewBag.IsRedirected && !ViewBag.IsSuccessfull)
{

#line default
#line hidden
            BeginContext(474, 237, true);
            WriteLiteral("<div class=\"alert alert-danger alert-dismissible fade show\" role=\"alert\">\n    Failure!\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\n        <span aria-hidden=\"true\">&times;</span>\n    </button>\n</div>\n");
            EndContext();
#line 25 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
}

#line default
#line hidden
            BeginContext(713, 172, true);
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"row\">\n        <div class=\"col-sm\">\n            <h2>View Reported Bugs</h2>\n        </div>\n        <div class=\"col-sm\">\n            ");
            EndContext();
            BeginContext(885, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11e2e515d7264e178c8e0523535e92bf", async() => {
                BeginContext(940, 14, true);
                WriteLiteral("Create New Bug");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(958, 329, true);
            WriteLiteral(@"
        </div>
    </div>
    <div class=""row mt-3"">
        <div class=""col-md-12 col-sm-12"">
            <div class=""table-responsive-md"">
                <table id=""bugsTable"" class=""table table-hover"">
                    <thead>
                        <tr>
                            <th>
                                ");
            EndContext();
            BeginContext(1288, 38, false);
#line 43 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 100, true);
            WriteLiteral("\n                            </th>\n                            <th>\n                                ");
            EndContext();
            BeginContext(1427, 45, false);
#line 46 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.ProjectId));

#line default
#line hidden
            EndContext();
            BeginContext(1472, 100, true);
            WriteLiteral("\n                            </th>\n                            <th>\n                                ");
            EndContext();
            BeginContext(1573, 44, false);
#line 49 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Reporter));

#line default
#line hidden
            EndContext();
            BeginContext(1617, 100, true);
            WriteLiteral("\n                            </th>\n                            <th>\n                                ");
            EndContext();
            BeginContext(1718, 41, false);
#line 52 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1759, 100, true);
            WriteLiteral("\n                            </th>\n                            <th>\n                                ");
            EndContext();
            BeginContext(1860, 47, false);
#line 55 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1907, 100, true);
            WriteLiteral("\n                            </th>\n                            <th>\n                                ");
            EndContext();
            BeginContext(2008, 42, false);
#line 58 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2050, 100, true);
            WriteLiteral("\n                            </th>\n                            <th>\n                                ");
            EndContext();
            BeginContext(2151, 44, false);
#line 61 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Priority));

#line default
#line hidden
            EndContext();
            BeginContext(2195, 100, true);
            WriteLiteral("\n                            </th>\n                            <th>\n                                ");
            EndContext();
            BeginContext(2296, 43, false);
#line 64 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.DueDate));

#line default
#line hidden
            EndContext();
            BeginContext(2339, 236, true);
            WriteLiteral("\n                            </th>\n                            <th></th>\n                            <th></th>\n                            <th></th>\n                        </tr>\n                    </thead>\n                    <tbody>\n");
            EndContext();
#line 72 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2654, 106, true);
            WriteLiteral("                            <tr>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(2761, 37, false);
#line 76 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2798, 112, true);
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(2911, 44, false);
#line 79 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ProjectId));

#line default
#line hidden
            EndContext();
            BeginContext(2955, 112, true);
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(3068, 43, false);
#line 82 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Reporter));

#line default
#line hidden
            EndContext();
            BeginContext(3111, 112, true);
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(3224, 40, false);
#line 85 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(3264, 112, true);
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(3377, 46, false);
#line 88 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3423, 112, true);
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(3536, 41, false);
#line 91 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3577, 112, true);
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(3690, 43, false);
#line 94 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Priority));

#line default
#line hidden
            EndContext();
            BeginContext(3733, 112, true);
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(3846, 42, false);
#line 97 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DueDate));

#line default
#line hidden
            EndContext();
            BeginContext(3888, 112, true);
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(4000, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "325c86824b894c0b9d9a0c04606e2ef5", async() => {
                BeginContext(4045, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 100 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                                                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4053, 112, true);
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(4165, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f10363a45294c78897b943e86a8ea79", async() => {
                BeginContext(4213, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 103 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4224, 112, true);
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(4336, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c74af3fd4ab42719444ecf951e14966", async() => {
                BeginContext(4383, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 106 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4393, 73, true);
            WriteLiteral("\n                                </td>\n                            </tr>\n");
            EndContext();
#line 109 "E:\FAKS\Elfak\NWT\Bugster\Bugster\Views\Bugs\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4492, 496, true);
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    $('#bugsTable').DataTable({
        responsive: true,
        ""columns"": [
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            { ""orderable"": false },
            { ""orderable"": false },
            { ""orderable"": false }
        ]
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bugster.Models.Bug>> Html { get; private set; }
    }
}
#pragma warning restore 1591
