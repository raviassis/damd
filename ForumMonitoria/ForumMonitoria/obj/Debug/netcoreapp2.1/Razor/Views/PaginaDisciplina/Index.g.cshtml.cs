#pragma checksum "C:\projects\damd\ForumMonitoria\ForumMonitoria\Views\PaginaDisciplina\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80d3c4125ce4b1387a12bf7099f4172ac4e876fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PaginaDisciplina_Index), @"mvc.1.0.view", @"/Views/PaginaDisciplina/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PaginaDisciplina/Index.cshtml", typeof(AspNetCore.Views_PaginaDisciplina_Index))]
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
#line 1 "C:\projects\damd\ForumMonitoria\ForumMonitoria\Views\_ViewImports.cshtml"
using ForumMonitoria;

#line default
#line hidden
#line 2 "C:\projects\damd\ForumMonitoria\ForumMonitoria\Views\_ViewImports.cshtml"
using ForumMonitoria.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80d3c4125ce4b1387a12bf7099f4172ac4e876fe", @"/Views/PaginaDisciplina/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d18025eb8f0a8d4cd8b2317ab9d9dbd2065337", @"/Views/_ViewImports.cshtml")]
    public class Views_PaginaDisciplina_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Disciplina>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTopico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\projects\damd\ForumMonitoria\ForumMonitoria\Views\PaginaDisciplina\Index.cshtml"
  
    ViewData["Title"] = "PaginaDisciplina";

#line default
#line hidden
            BeginContext(71, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(78, 10, false);
#line 6 "C:\projects\damd\ForumMonitoria\ForumMonitoria\Views\PaginaDisciplina\Index.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(88, 36, true);
            WriteLiteral("</h2>\r\n\r\n<h3>Tópicos</h3>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(124, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "475f747d0a8d4ab988eab03f3beb71f5", async() => {
                BeginContext(153, 11, true);
                WriteLiteral("Novo Tópico");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(168, 35, true);
            WriteLiteral("\r\n</p>\r\n\r\n<div class=\"container\">\r\n");
            EndContext();
#line 14 "C:\projects\damd\ForumMonitoria\ForumMonitoria\Views\PaginaDisciplina\Index.cshtml"
     foreach (var item in Model.Topicos)
    {

#line default
#line hidden
            BeginContext(252, 76, true);
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 328, "\"", 375, 3);
#line 18 "C:\projects\damd\ForumMonitoria\ForumMonitoria\Views\PaginaDisciplina\Index.cshtml"
WriteAttributeValue("", 335, item.DisciplinaID, 335, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 353, "/PaginaTopico/", 353, 14, true);
#line 18 "C:\projects\damd\ForumMonitoria\ForumMonitoria\Views\PaginaDisciplina\Index.cshtml"
WriteAttributeValue("", 367, item.ID, 367, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(376, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(378, 9, false);
#line 18 "C:\projects\damd\ForumMonitoria\ForumMonitoria\Views\PaginaDisciplina\Index.cshtml"
                                                              Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(387, 42, true);
            WriteLiteral("</a>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 21 "C:\projects\damd\ForumMonitoria\ForumMonitoria\Views\PaginaDisciplina\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(436, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Disciplina> Html { get; private set; }
    }
}
#pragma warning restore 1591
