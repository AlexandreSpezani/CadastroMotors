#pragma checksum "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\Shared\Components\Combo\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c380b219e458dcdf34473263fc82a9d5d7ce119f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Combo_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Combo/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Combo/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Combo_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c380b219e458dcdf34473263fc82a9d5d7ce119f", @"/Views/Shared/Components/Combo/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0c023caa3de0d03f2d1f0b3f01899321ecfd115", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Combo_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TesteWebMotors.Models.ComboViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 9, true);
            WriteLiteral("\r\n<label>");
            EndContext();
            BeginContext(55, 11, false);
#line 3 "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\Shared\Components\Combo\Default.cshtml"
  Write(Model.Label);

#line default
#line hidden
            EndContext();
            BeginContext(66, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
            BeginContext(77, 83, false);
#line 4 "C:\Users\Spezani\Desktop\TesteWebMotors\TesteWebMotors\TesteWebMotors\Views\Shared\Components\Combo\Default.cshtml"
Write(Html.DropDownList(Model.Id, Model.ListaProcessada, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(160, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TesteWebMotors.Models.ComboViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
