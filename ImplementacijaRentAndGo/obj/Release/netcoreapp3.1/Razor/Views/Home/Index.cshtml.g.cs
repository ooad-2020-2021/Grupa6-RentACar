#pragma checksum "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f157e89a91650cdbb680d8ab9652efd7f864eda7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\_ViewImports.cshtml"
using ImplementacijaRentAndGo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\_ViewImports.cshtml"
using ImplementacijaRentAndGo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f157e89a91650cdbb680d8ab9652efd7f864eda7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebfe1076445bd4b0d73e2f789a73c23a4324251c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "lokacija", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Vozilo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VozilaZaRentanje", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Home\Index.cshtml"
  
    var data = ViewBag.Message;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f157e89a91650cdbb680d8ab9652efd7f864eda76217", async() => {
                WriteLiteral(@"
    <div class=""border"" style=""background-image: url(https://moneyinc.com/wp-content/uploads/2019/06/2019-BMW-X2-1024x683.jpg); background-repeat:no-repeat; background-size: cover; height:800px; margin-left:unset; margin-right:unset"">
        <div class=""text-center"">
            <h1 class=""display-2 ""> Dobro došli!</h1>
            <p1> Hvala Vam što ste odabrali RentAndGo.</p1>
        </div>
        <div class=""filter-container"">
            <div class=""filter"" style=""border-right: 3px solid black;"">
                <span> Lokacija</span>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f157e89a91650cdbb680d8ab9652efd7f864eda77060", async() => {
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f157e89a91650cdbb680d8ab9652efd7f864eda77348", async() => {
                        WriteLiteral("Odaberite lokaciju");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 16 "C:\Users\DT User\Source\Repos\ooad-2020-2021\Grupa6-RentACar\ImplementacijaRentAndGo\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<Lokacija>();

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <span class=""text-danger""></span>
            </div>
            <div class=""filter"" style=""border-right: 3px solid black;"">
                <span> Datum preuzimanja</span>
                <input name=""datumPocetka"" class=""form-control"" type=""date"" data-val=""true"" data-val-required=""Obavezno polje!"" id=""datumPocetka"" value=""Datum Početka""  style=""width:auto"" required>
                <span class=""text-danger""></span>
            </div>
            <div class=""filter"">
                <span> Datum povratka</span>
                <input name=""datumKraja"" class=""form-control"" type=""date"" data-val=""true"" data-val-required=""Obavezno polje!"" id=""datumKraja"" value=""Datum Početka""  style=""width:auto"" required>
            </div>
            <div>
                <button type=""submit"" class=""btn btn-primary"" style=""height:55px; margin-right:10px; margin-top:30px"">Iznajmite vozilo</button>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <div class=""text-center"">
        <h5 class=""display-5"">Krenite na put bezbjedno</h5>
        <h3 class=""display-4"">Sigurno iznajmljivanje vozila</h3>
        <h3 class=""display-4"">tijekom COVID-19</h3>
    </div>
    <br />


    <div class=""card-deck"">
        <div class=""card"" style=""border-color:ActiveBorder"">
            <img src=""https://scontent.fsjj1-1.fna.fbcdn.net/v/t1.15752-9/cp0/195631138_139181881608774_2458713185474721373_n.png?_nc_cat=104&ccb=1-3&_nc_sid=ae9488&_nc_ohc=f9gbcsRZ-P0AX_0Us78&tn=2iDOBuMILrNoV67u&_nc_ht=scontent.fsjj1-1.fna&tp=30&oh=8ba3bd3588ecca5bc828cb4cb383cfc0&oe=60E0E49D"" class=""rounded mx-auto d-block"" alt=""..."">

            <div class=""card-body"">
                <h6 class=""card-title"">Čista i dezinficirana vozila</h6>
                <p class=""card-text"">Poboljšana politika čišćenja zahtjeva od nas da očistimo i dezinficiramo svoja vozila kako biste se osjećali dobro za volanom.</p>
            </div>
        </div>
        <div class=""card"" style=");
            WriteLiteral(@"""border-color:ActiveBorder"">
            <img src=""https://scontent.fsjj1-1.fna.fbcdn.net/v/t1.15752-9/cp0/198856058_342709907267395_4052365488558713764_n.png?_nc_cat=102&ccb=1-3&_nc_sid=ae9488&_nc_ohc=sARuUCXmQowAX8gBX78&_nc_ht=scontent.fsjj1-1.fna&tp=30&oh=c7dd41945fe95cac140a9c5ab96b0022&oe=60E690D9"" class=""rounded mx-auto d-block"" alt=""..."">
            <div class=""card-body"">
                <h6 class=""card-title"">Online rezervacija</h6>
                <p class=""card-text"">Mogućnost rezervacije vozila bez fizičkog kontakta.</p>
            </div>
        </div>
        <div class=""card"" style=""border-color:ActiveBorder"">
            <img src=""https://scontent.fsjj1-1.fna.fbcdn.net/v/t1.15752-9/cp0/198102046_899948260558097_7060851812322534066_n.png?_nc_cat=102&ccb=1-3&_nc_sid=ae9488&_nc_ohc=MnubVcosTscAX-zcSGp&_nc_ht=scontent.fsjj1-1.fna&tp=30&oh=ed32686bb029dcc4ad8c4b769106807a&oe=60E7A7CB"" class=""rounded mx-auto d-block"" alt=""..."">
            <div class=""card-body"">
                <h6 clas");
            WriteLiteral(@"s=""card-title"">Fleksibilno otkazivanje</h6>
                <p class=""card-text"">Otkažite Vašu rezervaciju 24h prije vašeg putovanja. Planovi se mogu uvijek promijeniti i mi smo tu da Vam olakšamo.</p>
            </div>
        </div>
    </div>
    <br />
    <br />
    <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"" style=""background-color:lightgray"">
        <ol class=""carousel-indicators"">
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
        </ol>
        <div class=""carousel-inner"">
            <div class=""carousel-item active"">
                <img class=""rounded mx-auto d-block"" src=""https://images.pexels.com/photos/1252500/pexels-photo-1252500.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940"" alt=""First slide"" style=""width: 100%; height: 100%"">
            WriteLiteral(@"
            </div>
            <div class=""carousel-item"">
                <img class=""rounded mx-auto d-block"" src=https://images.pexels.com/photos/4429509/pexels-photo-4429509.jpeg?auto =compress&cs =tinysrgb&dpr =2&h =650&w =940"" alt=""First slide"" style=""width: 100%; height: 100%"">
            </div>
            <div class=""carousel-item"">
                <img class=""rounded mx-auto d-block"" src=""https://images.pexels.com/photos/97079/pexels-photo-97079.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940"" alt=""First slide"" style="" width: 100%; height: 100%"">
            </div>
        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"" style=""color:aquamarine"">
            <span class=""ca");
            WriteLiteral("rousel-control-next-icon\" aria-hidden=\"true\"></span>\r\n            <span class=\"sr-only\">Next</span>\r\n        </a>\r\n    </div>\r\n\r\n    <br />\r\n    <br />\r\n\r\n\r\n");
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