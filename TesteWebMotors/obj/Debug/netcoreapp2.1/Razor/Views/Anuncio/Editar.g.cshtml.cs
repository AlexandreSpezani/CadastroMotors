#pragma checksum "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\Anuncio\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a6d9311b3357fc70bc68e02ee605f573d4d9fed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anuncio_Editar), @"mvc.1.0.view", @"/Views/Anuncio/Editar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Anuncio/Editar.cshtml", typeof(AspNetCore.Views_Anuncio_Editar))]
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
#line 1 "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\_ViewImports.cshtml"
using TesteWebMotors;

#line default
#line hidden
#line 2 "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\_ViewImports.cshtml"
using TesteWebMotors.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a6d9311b3357fc70bc68e02ee605f573d4d9fed", @"/Views/Anuncio/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0c023caa3de0d03f2d1f0b3f01899321ecfd115", @"/Views/_ViewImports.cshtml")]
    public class Views_Anuncio_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TesteWebMotors.Models.AnuncioViewModel>
    {
        private global::AspNetCore.Views_Anuncio_Editar.__Generated__ComboMakerViewComponentTagHelper __ComboMakerViewComponentTagHelper;
        private global::AspNetCore.Views_Anuncio_Editar.__Generated__ComboModelViewComponentTagHelper __ComboModelViewComponentTagHelper;
        private global::AspNetCore.Views_Anuncio_Editar.__Generated__ComboVersionViewComponentTagHelper __ComboVersionViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Anuncio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\Anuncio\Editar.cshtml"
  
    ViewData["Title"] = "Anúncio";

#line default
#line hidden
            BeginContext(92, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(111, 105, true);
                WriteLiteral("\r\n\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#select_marca option:contains(\"");
                EndContext();
                BeginContext(217, 19, false);
#line 11 "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\Anuncio\Editar.cshtml"
                                         Write(Model.Anuncio.Marca);

#line default
#line hidden
                EndContext();
                BeginContext(236, 95, true);
                WriteLiteral("\")\').prop(\'selected\', true);\r\n            $(\"#select_modelo\").html(\'<option selected value=\"0\">");
                EndContext();
                BeginContext(332, 20, false);
#line 12 "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\Anuncio\Editar.cshtml"
                                                            Write(Model.Anuncio.Modelo);

#line default
#line hidden
                EndContext();
                BeginContext(352, 79, true);
                WriteLiteral("</option>\');\r\n            $(\"#select_versao\").html(\'<option selected value=\"0\">");
                EndContext();
                BeginContext(432, 20, false);
#line 13 "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\Anuncio\Editar.cshtml"
                                                            Write(Model.Anuncio.Versao);

#line default
#line hidden
                EndContext();
                BeginContext(452, 205, true);
                WriteLiteral("</option>\');\r\n\r\n            $(\'#select_marca\').change(function () {\r\n                var makerId = $(this).val();\r\n                var select = $(this)\r\n                $.ajax({\r\n                    url: \"");
                EndContext();
                BeginContext(658, 35, false);
#line 19 "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\Anuncio\Editar.cshtml"
                     Write(Url.Action("ComboModel", "Anuncio"));

#line default
#line hidden
                EndContext();
                BeginContext(693, 539, true);
                WriteLiteral(@"?makerId="" + makerId,
                    dataType: 'html',
                    success: function (result) {
                        $('#combo-model-wrapper').html(result);
                        $('#anuncio_marca').val($(select).find('option:selected').text());
                    }
                })
            });

            $(document).on(""change"", ""#select_modelo"", function () {
                var makerId = $(this).val();
                var select = $(this)

                $.ajax({
                    url: """);
                EndContext();
                BeginContext(1233, 36, false);
#line 33 "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\Anuncio\Editar.cshtml"
                     Write(Url.Action("ComboVersion","Anuncio"));

#line default
#line hidden
                EndContext();
                BeginContext(1269, 652, true);
                WriteLiteral(@"?modelId="" + makerId,
                    dataType: 'html',
                    success: function (result) {
                        $('#combo-version-wrapper').html(result);
                        $('#anuncio_modelo').val($(select).find('option:selected').text());
                    }
                })
            });

            $(document).on(""change"", ""#select_versao"", function () {
                var select = $(this)
                $('#anuncio_versao').val($(select).find('option:selected').text());
            });
        });

         function excluirAnuncio(id) {
                 $.ajax({
                    url: """);
                EndContext();
                BeginContext(1922, 31, false);
#line 50 "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\Anuncio\Editar.cshtml"
                     Write(Url.Action("Excluir","Anuncio"));

#line default
#line hidden
                EndContext();
                BeginContext(1953, 227, true);
                WriteLiteral("?id=\" + id,\r\n                    dataType: \'json\',\r\n                    success: function (result) {;\r\n                        alert(`o anuncio ${result.id} foi excluído com sucesso`);\r\n                        location.reload(\"");
                EndContext();
                BeginContext(2181, 29, false);
#line 54 "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\Anuncio\Editar.cshtml"
                                    Write(Url.Action("Index","Anuncio"));

#line default
#line hidden
                EndContext();
                BeginContext(2210, 78, true);
                WriteLiteral("\");\r\n                    }\r\n                })\r\n          }\r\n    </script>\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(2291, 78, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <h1 class=\"title\"> Criar anúncio</h1>\r\n\r\n    ");
            EndContext();
            BeginContext(2369, 1581, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e96e980a8f69452693f0c613693871fa", async() => {
                BeginContext(2434, 12, true);
                WriteLiteral("\r\n\r\n        ");
                EndContext();
                BeginContext(2447, 33, false);
#line 68 "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\Anuncio\Editar.cshtml"
   Write(Html.HiddenFor(m => m.Anuncio.Id));

#line default
#line hidden
                EndContext();
                BeginContext(2480, 282, true);
                WriteLiteral(@"
        <input type=""hidden"" id=""anuncio_marca"" name=""anuncio.marca"" />
        <input type=""hidden"" id=""anuncio_modelo"" name=""anuncio.modelo"" />
        <input type=""hidden"" id=""anuncio_versao"" name=""anuncio.versao"" />

        <div class=""form-group col-md-4"">
            ");
                EndContext();
                BeginContext(2762, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:combo-maker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e406a2fc0c3f4501a7ace0b3598d070c", async() => {
                }
                );
                __ComboMakerViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Anuncio_Editar.__Generated__ComboMakerViewComponentTagHelper>();
                __tagHelperExecutionContext.Add(__ComboMakerViewComponentTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2795, 100, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-4\" id=\"combo-model-wrapper\">\r\n            ");
                EndContext();
                BeginContext(2895, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:combo-model", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc492b1ac3ec4217806729cdce721404", async() => {
                }
                );
                __ComboModelViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Anuncio_Editar.__Generated__ComboModelViewComponentTagHelper>();
                __tagHelperExecutionContext.Add(__ComboModelViewComponentTagHelper);
#line 78 "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\Anuncio\Editar.cshtml"
__ComboModelViewComponentTagHelper.MakerId = 0;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("maker-id", __ComboModelViewComponentTagHelper.MakerId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2941, 102, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-4\" id=\"combo-version-wrapper\">\r\n            ");
                EndContext();
                BeginContext(3043, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:combo-version", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5e2e25a101545259f1530fb200fe131", async() => {
                }
                );
                __ComboVersionViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Anuncio_Editar.__Generated__ComboVersionViewComponentTagHelper>();
                __tagHelperExecutionContext.Add(__ComboVersionViewComponentTagHelper);
#line 82 "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\Anuncio\Editar.cshtml"
__ComboVersionViewComponentTagHelper.ModelId = 0;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("model-id", __ComboVersionViewComponentTagHelper.ModelId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3093, 134, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-4\" id=\"combo-version-wrapper\">\r\n            <label>Ano</label>\r\n            ");
                EndContext();
                BeginContext(3228, 86, false);
#line 87 "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\Anuncio\Editar.cshtml"
       Write(Html.TextBoxFor(m => m.Anuncio.Ano, new { @class = "form-control", @type = "number" }));

#line default
#line hidden
                EndContext();
                BeginContext(3314, 144, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-4\" id=\"combo-version-wrapper\">\r\n            <label>Quilometragem</label>\r\n            ");
                EndContext();
                BeginContext(3459, 96, false);
#line 92 "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\Anuncio\Editar.cshtml"
       Write(Html.TextBoxFor(m => m.Anuncio.Quilometragem, new { @class = "form-control", @type = "number" }));

#line default
#line hidden
                EndContext();
                BeginContext(3555, 141, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-4\" id=\"combo-version-wrapper\">\r\n            <label>Observação</label>\r\n            ");
                EndContext();
                BeginContext(3697, 76, false);
#line 97 "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\Anuncio\Editar.cshtml"
       Write(Html.TextAreaFor(m => m.Anuncio.Observacao, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(3773, 170, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-12\">\r\n            <button type=\"submit\" class=\"btn btn-default pull-right\">Enviar</button>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3950, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TesteWebMotors.Models.AnuncioViewModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:combo-maker")]
        public class __Generated__ComboMakerViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__ComboMakerViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("ComboMaker", new {  });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:combo-model")]
        public class __Generated__ComboModelViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__ComboModelViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.Int32 MakerId { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("ComboModel", new { MakerId });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:combo-version")]
        public class __Generated__ComboVersionViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__ComboVersionViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.Int32 ModelId { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("ComboVersion", new { ModelId });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591
