#pragma checksum "D:\4\Clould\work\webapp_asp\Views\Menu\OrderMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28cc9421a528c435c3c025e40c5f2b713c818ef0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_OrderMenu), @"mvc.1.0.view", @"/Views/Menu/OrderMenu.cshtml")]
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
#line 1 "D:\4\Clould\work\webapp_asp\Views\_ViewImports.cshtml"
using webapp_asp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\4\Clould\work\webapp_asp\Views\_ViewImports.cshtml"
using webapp_asp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\4\Clould\work\webapp_asp\Views\Menu\OrderMenu.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28cc9421a528c435c3c025e40c5f2b713c818ef0", @"/Views/Menu/OrderMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e404aefea4181f3910f2680fd39aa912e3a39921", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_OrderMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<webapp_asp.Models.Menu>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\4\Clould\work\webapp_asp\Views\Menu\OrderMenu.cshtml"
  
    ViewData["Title"] = "Add Menu Page";
    var id = @Context.Session.GetString("id");

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    div{\r\n       font-family: 배달의민족 한나체 Pro; \r\n    }\r\n</style>\r\n\r\n");
#nullable restore
#line 13 "D:\4\Clould\work\webapp_asp\Views\Menu\OrderMenu.cshtml"
 if(id != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("   <div class=\"text-center\">\r\n    <h1 class=\"display-4\">Online Chicken Delivery Order Menu Page </h1><br>\r\n    <h4>해당 정보로 주문하시겠습니까? </h4> <br>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28cc9421a528c435c3c025e40c5f2b713c818ef05029", async() => {
                WriteLiteral("\r\n       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "28cc9421a528c435c3c025e40c5f2b713c818ef05294", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 19 "D:\4\Clould\work\webapp_asp\Views\Menu\OrderMenu.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.number);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n       <p>메뉴 이름:<input type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 554, "\"", 599, 1);
#nullable restore
#line 20 "D:\4\Clould\work\webapp_asp\Views\Menu\OrderMenu.cshtml"
WriteAttributeValue("", 562, Html.DisplayFor(model => model.name), 562, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly/>  </p>\r\n       <p><input type=\"hidden\" name=\"amount\"");
                BeginWriteAttribute("value", " value=\"", 663, "\"", 710, 1);
#nullable restore
#line 21 "D:\4\Clould\work\webapp_asp\Views\Menu\OrderMenu.cshtml"
WriteAttributeValue("", 671, Html.DisplayFor(model => model.amount), 671, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly /></p>\r\n       <p>메뉴 가격:<input type=\"text\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 776, "\"", 822, 1);
#nullable restore
#line 22 "D:\4\Clould\work\webapp_asp\Views\Menu\OrderMenu.cshtml"
WriteAttributeValue("", 784, Html.DisplayFor(model => model.price), 784, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly /> </p>\r\n       <input type=\"hidden\" name=\"sales\"");
                BeginWriteAttribute("value", " value=\"", 882, "\"", 928, 1);
#nullable restore
#line 23 "D:\4\Clould\work\webapp_asp\Views\Menu\OrderMenu.cshtml"
WriteAttributeValue("", 890, Html.DisplayFor(model => model.sales), 890, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n      <input type=\"submit\" class=\"btn btn-primary\" value=\"주문하기\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br>\r\n    <br>\r\n    <input type=\"button\" class=\"btn btn-primary\" value=\"뒤로가기\" onclick=\"history.go(-1);\" />\r\n</div>\r\n");
#nullable restore
#line 29 "D:\4\Clould\work\webapp_asp\Views\Menu\OrderMenu.cshtml"
}
else 
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""text-center"">
    <h1 class=""display-4"">Online Chicken Delivery Oreder Site </h1><br>
    <h3>주문을 하기 전에 먼저 로그인을 해주세요. </h3><br>
    <br>
    <br>
    <p><input type=""button"" value=""로그인"" class=""btn btn-primary"" onclick=""location.href='/Home/Index'"" />
    <input type=""button"" value=""뒤로가기"" class=""btn btn-primary"" onclick='history.go(-1);' /></p>
</div>
");
#nullable restore
#line 40 "D:\4\Clould\work\webapp_asp\Views\Menu\OrderMenu.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<webapp_asp.Models.Menu> Html { get; private set; }
    }
}
#pragma warning restore 1591