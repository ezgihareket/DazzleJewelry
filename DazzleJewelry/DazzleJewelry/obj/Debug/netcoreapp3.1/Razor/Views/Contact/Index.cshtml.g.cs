#pragma checksum "C:\Users\ezgih\Desktop\Ezgi Hareket\DazzleJewelry\DazzleJewelry\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75cef416a6c1f9c3a9b3fd6881d443bc4a9f74d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\ezgih\Desktop\Ezgi Hareket\DazzleJewelry\DazzleJewelry\Views\_ViewImports.cshtml"
using DazzleJewelry.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ezgih\Desktop\Ezgi Hareket\DazzleJewelry\DazzleJewelry\Views\_ViewImports.cshtml"
using DazzleJewelry.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75cef416a6c1f9c3a9b3fd6881d443bc4a9f74d4", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09420a88a877374328f76b44e84178b160699c00", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("address", "iletisim@dazzlejewelry.com", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("link-text", "iletisim@dazzlejewelry.com", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::DazzleJewelry.TagHelpers.EmailTagHelper __DazzleJewelry_TagHelpers_EmailTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"ticiContainer\" id=\"divIcerik\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 52, "\"", 60, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""display: none;"">
        <div id=""loader""></div>
    </div>
    <div id=""mainHolder_divBlocks"">
        <div id=""divCenterBlock"" class=""centerCount iletisimContent""></div>
        <div class=""middleTopBlock"">
        </div>
        <div>
            <div class=""clear""></div>
            <div class=""row iletisimLeft"">
                <div class=""categoryTitle"" style=""border-bottom: solid 7px #e4e4e4;"">
                    <div class=""categoryTitleText"">
                        İLETİŞİM
                    </div>
                </div>
                <div class=""span iletisimLeft"" style=""padding:10px;"">
                    <div class=""Left"" style=""float:left; width: 15%; line-height: 30px; min-height: 30px;"">Firma Adı</div>
                    <div class=""Center"" style=""width: 2%; float:left;"">:</div>
                    <div class=""Right"" style=""width: 83%; min-height: 30px; line-height: 30px;"">
                        Dazzlecave
                    </div>
                </div>
");
            WriteLiteral(@"                <div class=""span iletisimLeftTelefon"" style=""padding:10px;"">
                    <div class=""Left"" style=""float:left; width: 15%;"">Telefon </div>
                    <div class=""Center"" style=""width: 2%; float:left;"">:</div>
                    <div class=""Right"" style=""width: 83%; min-height: 30px; line-height: 30px;"">
                        123456789
                    </div>
                </div>
                <div class=""span iletisimLeftAdres"" style=""padding:10px;"">
                    <div class=""Left"" style=""float:left; width: 15%;"">Adres</div>
                    <div class=""Center"" style=""width: 2%; float:left;"">:</div>
                    <div class=""Right"" style=""width: 83%; min-height: 30px; line-height: 30px;"">
                        -
                    </div>
                </div>
                <div class=""span iletisimLeftEposta"" style=""padding:10px;"">
                    <div class=""Left"" style=""float:left; width: 15%"">E-posta</div>
                  ");
            WriteLiteral("  <div class=\"Center\" style=\"width: 2%; float:left;\">:</div>\r\n                    <div class=\"Right\" style=\"width: 83%; min-height: 30px; line-height: 30px;\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("email", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75cef416a6c1f9c3a9b3fd6881d443bc4a9f74d46315", async() => {
            }
            );
            __DazzleJewelry_TagHelpers_EmailTagHelper = CreateTagHelper<global::DazzleJewelry.TagHelpers.EmailTagHelper>();
            __tagHelperExecutionContext.Add(__DazzleJewelry_TagHelpers_EmailTagHelper);
            __DazzleJewelry_TagHelpers_EmailTagHelper.Address = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __DazzleJewelry_TagHelpers_EmailTagHelper.LinkText = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""categoryTitle"" style=""border-bottom: solid 7px #e4e4e4;"">
                    </divclass=""categoryTitle"">
                </div>
            </div>
        </div>
    </div>
");
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
