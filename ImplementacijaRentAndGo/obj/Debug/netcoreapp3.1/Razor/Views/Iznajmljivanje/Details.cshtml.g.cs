#pragma checksum "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3ca6069aa56c2a1e3394022824de774bdb678da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Iznajmljivanje_Details), @"mvc.1.0.view", @"/Views/Iznajmljivanje/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\_ViewImports.cshtml"
using ImplementacijaRentAndGo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\_ViewImports.cshtml"
using ImplementacijaRentAndGo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3ca6069aa56c2a1e3394022824de774bdb678da", @"/Views/Iznajmljivanje/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebfe1076445bd4b0d73e2f789a73c23a4324251c", @"/Views/_ViewImports.cshtml")]
    public class Views_Iznajmljivanje_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ImplementacijaRentAndGo.Models.Iznajmljivanje>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalji</h1>\r\n\r\n<div>\r\n    <h4>Iznajmljivanje</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IDKlijenta));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayFor(model => model.IDKlijenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IDVozila));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayFor(model => model.IDVozila));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IDVozaca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayFor(model => model.IDVozaca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IDAdmin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayFor(model => model.IDAdmin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cijena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cijena));

#line default
#line hidden
#nullable disable
            WriteLiteral(" KM\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Lokacija));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayFor(model => model.Lokacija));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Stanje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayFor(model => model.Stanje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Komentar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayFor(model => model.Komentar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Popust));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayFor(model => model.Popust));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NacinPlacanja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayFor(model => model.NacinPlacanja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DatumPreuzmanja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayFor(model => model.DatumPreuzmanja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DatumVracanja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
       Write(Html.DisplayFor(model => model.DatumVracanja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3ca6069aa56c2a1e3394022824de774bdb678da12405", async() => {
                WriteLiteral("Uredi");
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
#nullable restore
#line 88 "C:\Users\azra\Source\Repos\Grupa6-Rent\ImplementacijaRentAndGo\Views\Iznajmljivanje\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3ca6069aa56c2a1e3394022824de774bdb678da14568", async() => {
                WriteLiteral("Vrati se na listu");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ImplementacijaRentAndGo.Models.Iznajmljivanje> Html { get; private set; }
    }
}
#pragma warning restore 1591
