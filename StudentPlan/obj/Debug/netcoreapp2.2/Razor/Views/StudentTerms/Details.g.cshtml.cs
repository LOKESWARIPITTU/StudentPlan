#pragma checksum "C:\Users\S533901\Documents\44663\StudentPlan\StudentPlan\Views\StudentTerms\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd0712bc0be418a659e72d02ce7134d3a3cf6881"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentTerms_Details), @"mvc.1.0.view", @"/Views/StudentTerms/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StudentTerms/Details.cshtml", typeof(AspNetCore.Views_StudentTerms_Details))]
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
#line 1 "C:\Users\S533901\Documents\44663\StudentPlan\StudentPlan\Views\_ViewImports.cshtml"
using StudentPlan;

#line default
#line hidden
#line 2 "C:\Users\S533901\Documents\44663\StudentPlan\StudentPlan\Views\_ViewImports.cshtml"
using StudentPlan.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd0712bc0be418a659e72d02ce7134d3a3cf6881", @"/Views/StudentTerms/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"268f0ee4ee82ba3de036016cd8792dc157a3cd5e", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentTerms_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentPlan.Models.StudentTerm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\S533901\Documents\44663\StudentPlan\StudentPlan\Views\StudentTerms\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 134, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>StudentTerm</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(219, 45, false);
#line 14 "C:\Users\S533901\Documents\44663\StudentPlan\StudentPlan\Views\StudentTerms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StudentID));

#line default
#line hidden
            EndContext();
            BeginContext(264, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(328, 41, false);
#line 17 "C:\Users\S533901\Documents\44663\StudentPlan\StudentPlan\Views\StudentTerms\Details.cshtml"
       Write(Html.DisplayFor(model => model.StudentID));

#line default
#line hidden
            EndContext();
            BeginContext(369, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(432, 48, false);
#line 20 "C:\Users\S533901\Documents\44663\StudentPlan\StudentPlan\Views\StudentTerms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DegreePlanID));

#line default
#line hidden
            EndContext();
            BeginContext(480, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(544, 44, false);
#line 23 "C:\Users\S533901\Documents\44663\StudentPlan\StudentPlan\Views\StudentTerms\Details.cshtml"
       Write(Html.DisplayFor(model => model.DegreePlanID));

#line default
#line hidden
            EndContext();
            BeginContext(588, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(651, 40, false);
#line 26 "C:\Users\S533901\Documents\44663\StudentPlan\StudentPlan\Views\StudentTerms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Term));

#line default
#line hidden
            EndContext();
            BeginContext(691, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(755, 36, false);
#line 29 "C:\Users\S533901\Documents\44663\StudentPlan\StudentPlan\Views\StudentTerms\Details.cshtml"
       Write(Html.DisplayFor(model => model.Term));

#line default
#line hidden
            EndContext();
            BeginContext(791, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(854, 44, false);
#line 32 "C:\Users\S533901\Documents\44663\StudentPlan\StudentPlan\Views\StudentTerms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TermAbbr));

#line default
#line hidden
            EndContext();
            BeginContext(898, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(962, 40, false);
#line 35 "C:\Users\S533901\Documents\44663\StudentPlan\StudentPlan\Views\StudentTerms\Details.cshtml"
       Write(Html.DisplayFor(model => model.TermAbbr));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1065, 44, false);
#line 38 "C:\Users\S533901\Documents\44663\StudentPlan\StudentPlan\Views\StudentTerms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TermName));

#line default
#line hidden
            EndContext();
            BeginContext(1109, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1173, 40, false);
#line 41 "C:\Users\S533901\Documents\44663\StudentPlan\StudentPlan\Views\StudentTerms\Details.cshtml"
       Write(Html.DisplayFor(model => model.TermName));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1276, 52, false);
#line 44 "C:\Users\S533901\Documents\44663\StudentPlan\StudentPlan\Views\StudentTerms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NoOfCoursesTaken));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1392, 48, false);
#line 47 "C:\Users\S533901\Documents\44663\StudentPlan\StudentPlan\Views\StudentTerms\Details.cshtml"
       Write(Html.DisplayFor(model => model.NoOfCoursesTaken));

#line default
#line hidden
            EndContext();
            BeginContext(1440, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1487, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd0712bc0be418a659e72d02ce7134d3a3cf68819514", async() => {
                BeginContext(1544, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\S533901\Documents\44663\StudentPlan\StudentPlan\Views\StudentTerms\Details.cshtml"
                           WriteLiteral(Model.StudentTermID);

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
            BeginContext(1552, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1560, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd0712bc0be418a659e72d02ce7134d3a3cf688111857", async() => {
                BeginContext(1582, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1598, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentPlan.Models.StudentTerm> Html { get; private set; }
    }
}
#pragma warning restore 1591