#pragma checksum "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95a23d72789d485f7e167b9f9e158eb27c7d8ab0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TVS_Delete), @"mvc.1.0.view", @"/Views/TVS/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TVS/Delete.cshtml", typeof(AspNetCore.Views_TVS_Delete))]
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
#line 1 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\_ViewImports.cshtml"
using TV_Buddy;

#line default
#line hidden
#line 2 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\_ViewImports.cshtml"
using TV_Buddy.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95a23d72789d485f7e167b9f9e158eb27c7d8ab0", @"/Views/TVS/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08e090d837e36d85fd0943c6227c9074bf8572b3", @"/Views/_ViewImports.cshtml")]
    public class Views_TVS_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TV_Buddy.Models.TVS>
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
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(72, 173, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>TVS</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(246, 41, false);
#line 15 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(287, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(351, 37, false);
#line 18 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(388, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(451, 47, false);
#line 21 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ModelNumber));

#line default
#line hidden
            EndContext();
            BeginContext(498, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(562, 43, false);
#line 24 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ModelNumber));

#line default
#line hidden
            EndContext();
            BeginContext(605, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(668, 48, false);
#line 27 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SerialNumber));

#line default
#line hidden
            EndContext();
            BeginContext(716, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(780, 44, false);
#line 30 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SerialNumber));

#line default
#line hidden
            EndContext();
            BeginContext(824, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(887, 40, false);
#line 33 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(927, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(991, 36, false);
#line 36 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1027, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1090, 43, false);
#line 39 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Quality));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1197, 39, false);
#line 42 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Quality));

#line default
#line hidden
            EndContext();
            BeginContext(1236, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1299, 39, false);
#line 45 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HDR));

#line default
#line hidden
            EndContext();
            BeginContext(1338, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1402, 35, false);
#line 48 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HDR));

#line default
#line hidden
            EndContext();
            BeginContext(1437, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1500, 40, false);
#line 51 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OLED));

#line default
#line hidden
            EndContext();
            BeginContext(1540, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1604, 36, false);
#line 54 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OLED));

#line default
#line hidden
            EndContext();
            BeginContext(1640, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1703, 40, false);
#line 57 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.QLED));

#line default
#line hidden
            EndContext();
            BeginContext(1743, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1807, 36, false);
#line 60 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayFor(model => model.QLED));

#line default
#line hidden
            EndContext();
            BeginContext(1843, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1906, 39, false);
#line 63 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LED));

#line default
#line hidden
            EndContext();
            BeginContext(1945, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2009, 35, false);
#line 66 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LED));

#line default
#line hidden
            EndContext();
            BeginContext(2044, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2107, 50, false);
#line 69 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ContrastLevels));

#line default
#line hidden
            EndContext();
            BeginContext(2157, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2221, 46, false);
#line 72 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ContrastLevels));

#line default
#line hidden
            EndContext();
            BeginContext(2267, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2330, 41, false);
#line 75 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2371, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2435, 37, false);
#line 78 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2472, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2535, 39, false);
#line 81 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Hrz));

#line default
#line hidden
            EndContext();
            BeginContext(2574, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2638, 35, false);
#line 84 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Hrz));

#line default
#line hidden
            EndContext();
            BeginContext(2673, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2736, 43, false);
#line 87 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BitRate));

#line default
#line hidden
            EndContext();
            BeginContext(2779, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2843, 39, false);
#line 90 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BitRate));

#line default
#line hidden
            EndContext();
            BeginContext(2882, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2920, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95a23d72789d485f7e167b9f9e158eb27c7d8ab015481", async() => {
                BeginContext(2946, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2956, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "95a23d72789d485f7e167b9f9e158eb27c7d8ab015874", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 95 "C:\Users\Chad\workspace\TV-Buddy\TV-Buddy\Views\TVS\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TVSId);

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
                BeginContext(2995, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(3078, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95a23d72789d485f7e167b9f9e158eb27c7d8ab017769", async() => {
                    BeginContext(3100, 12, true);
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
                BeginContext(3116, 6, true);
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
            BeginContext(3129, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TV_Buddy.Models.TVS> Html { get; private set; }
    }
}
#pragma warning restore 1591