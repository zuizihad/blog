#pragma checksum "/home/zihad/Desktop/blog/blog/Views/Comments/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a31b9a3174072108451696fe609f988b40f89bfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comments_Delete), @"mvc.1.0.view", @"/Views/Comments/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comments/Delete.cshtml", typeof(AspNetCore.Views_Comments_Delete))]
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
#line 1 "/home/zihad/Desktop/blog/blog/Views/_ViewImports.cshtml"
using blog;

#line default
#line hidden
#line 2 "/home/zihad/Desktop/blog/blog/Views/_ViewImports.cshtml"
using blog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a31b9a3174072108451696fe609f988b40f89bfd", @"/Views/Comments/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb75ca75589086f3cd7b7a5e09e52e9d3c84d752", @"/Views/_ViewImports.cshtml")]
    public class Views_Comments_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<blog.Models.Comments>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/zihad/Desktop/blog/blog/Views/Comments/Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(73, 178, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Comments</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(252, 49, false);
#line 15 "/home/zihad/Desktop/blog/blog/Views/Comments/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.commentAuthor));

#line default
#line hidden
            EndContext();
            BeginContext(301, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(365, 45, false);
#line 18 "/home/zihad/Desktop/blog/blog/Views/Comments/Delete.cshtml"
       Write(Html.DisplayFor(model => model.commentAuthor));

#line default
#line hidden
            EndContext();
            BeginContext(410, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(473, 47, false);
#line 21 "/home/zihad/Desktop/blog/blog/Views/Comments/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.commentDate));

#line default
#line hidden
            EndContext();
            BeginContext(520, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(584, 43, false);
#line 24 "/home/zihad/Desktop/blog/blog/Views/Comments/Delete.cshtml"
       Write(Html.DisplayFor(model => model.commentDate));

#line default
#line hidden
            EndContext();
            BeginContext(627, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(690, 44, false);
#line 27 "/home/zihad/Desktop/blog/blog/Views/Comments/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.isHidden));

#line default
#line hidden
            EndContext();
            BeginContext(734, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(798, 40, false);
#line 30 "/home/zihad/Desktop/blog/blog/Views/Comments/Delete.cshtml"
       Write(Html.DisplayFor(model => model.isHidden));

#line default
#line hidden
            EndContext();
            BeginContext(838, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(901, 54, false);
#line 33 "/home/zihad/Desktop/blog/blog/Views/Comments/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.commentAuthorEmail));

#line default
#line hidden
            EndContext();
            BeginContext(955, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1019, 50, false);
#line 36 "/home/zihad/Desktop/blog/blog/Views/Comments/Delete.cshtml"
       Write(Html.DisplayFor(model => model.commentAuthorEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1132, 54, false);
#line 39 "/home/zihad/Desktop/blog/blog/Views/Comments/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.commentDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1250, 50, false);
#line 42 "/home/zihad/Desktop/blog/blog/Views/Comments/Delete.cshtml"
       Write(Html.DisplayFor(model => model.commentDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1338, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a31b9a3174072108451696fe609f988b40f89bfd8766", async() => {
                BeginContext(1364, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1374, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a31b9a3174072108451696fe609f988b40f89bfd9153", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 47 "/home/zihad/Desktop/blog/blog/Views/Comments/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.authorId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1416, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1499, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a31b9a3174072108451696fe609f988b40f89bfd11018", async() => {
                    BeginContext(1521, 12, true);
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
                BeginContext(1537, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1550, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<blog.Models.Comments> Html { get; private set; }
    }
}
#pragma warning restore 1591
