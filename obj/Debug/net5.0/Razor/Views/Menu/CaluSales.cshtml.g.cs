#pragma checksum "D:\4\Clould\work\webapp_asp\Views\Menu\CaluSales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d4e8dfc5f4c9be502b4ef1eef4b85a54e100170"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_CaluSales), @"mvc.1.0.view", @"/Views/Menu/CaluSales.cshtml")]
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
#line 2 "D:\4\Clould\work\webapp_asp\Views\Menu\CaluSales.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d4e8dfc5f4c9be502b4ef1eef4b85a54e100170", @"/Views/Menu/CaluSales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e404aefea4181f3910f2680fd39aa912e3a39921", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_CaluSales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<webapp_asp.Models.Menu>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CaluSales2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\4\Clould\work\webapp_asp\Views\Menu\CaluSales.cshtml"
  
    ViewData["Title"] = "Administrator Mode";
    var id = @Context.Session.GetString("id");
    var sales = @Context.Session.GetInt32("totalsales");

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    div{\r\n       font-family: 배달의민족 한나체 Pro; \r\n    }\r\n</style>\r\n\r\n");
#nullable restore
#line 14 "D:\4\Clould\work\webapp_asp\Views\Menu\CaluSales.cshtml"
 if(id == "admin")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("   <div class=\"text-center\">\r\n    <h1 class=\"display-4\">Online Chicken Delivery Admin Page </h1> <br>\r\n    <h4>매출 계산</h4><br>\r\n    <h6>여기서 담당하는 것은 하루 매출 계산을 담당합니다.(메뉴 하나마다) </h6> <br>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d4e8dfc5f4c9be502b4ef1eef4b85a54e1001705139", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d4e8dfc5f4c9be502b4ef1eef4b85a54e1001705401", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 21 "D:\4\Clould\work\webapp_asp\Views\Menu\CaluSales.cshtml"
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
                WriteLiteral("\r\n     <p>메뉴 번호: <input type=\"text\" name=\"number\"");
                BeginWriteAttribute("value", " value=\"", 660, "\"", 707, 1);
#nullable restore
#line 22 "D:\4\Clould\work\webapp_asp\Views\Menu\CaluSales.cshtml"
WriteAttributeValue("", 668, Html.DisplayFor(model => model.number), 668, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readOnly /> </p>\r\n     <p>메뉴 이름: <input type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 772, "\"", 817, 1);
#nullable restore
#line 23 "D:\4\Clould\work\webapp_asp\Views\Menu\CaluSales.cshtml"
WriteAttributeValue("", 780, Html.DisplayFor(model => model.name), 780, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readOnly /> </p>\r\n     <p>메뉴 수량: <input type=\"text\" name=\"amount\"");
                BeginWriteAttribute("value", " value=\"", 884, "\"", 931, 1);
#nullable restore
#line 24 "D:\4\Clould\work\webapp_asp\Views\Menu\CaluSales.cshtml"
WriteAttributeValue("", 892, Html.DisplayFor(model => model.amount), 892, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readOnly /></p>\r\n     <p>메뉴 가격: <input type=\"text\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 996, "\"", 1042, 1);
#nullable restore
#line 25 "D:\4\Clould\work\webapp_asp\Views\Menu\CaluSales.cshtml"
WriteAttributeValue("", 1004, Html.DisplayFor(model => model.price), 1004, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readOnly /> </p>\r\n     <p>팔린 양: <input type=\"text\" name=\"sales\"");
                BeginWriteAttribute("value", " value=\"", 1107, "\"", 1153, 1);
#nullable restore
#line 26 "D:\4\Clould\work\webapp_asp\Views\Menu\CaluSales.cshtml"
WriteAttributeValue("", 1115, Html.DisplayFor(model => model.sales), 1115, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readOnly /></p>\r\n");
#nullable restore
#line 27 "D:\4\Clould\work\webapp_asp\Views\Menu\CaluSales.cshtml"
      if(sales == null) {

#line default
#line hidden
#nullable disable
                WriteLiteral(" <p> 하루 매출을 계산해주세요. </p>");
#nullable restore
#line 27 "D:\4\Clould\work\webapp_asp\Views\Menu\CaluSales.cshtml"
                                                 }
     else {

#line default
#line hidden
#nullable disable
                WriteLiteral(" <p>하루 매출: ");
#nullable restore
#line 28 "D:\4\Clould\work\webapp_asp\Views\Menu\CaluSales.cshtml"
                 Write(sales);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p> ");
#nullable restore
#line 28 "D:\4\Clould\work\webapp_asp\Views\Menu\CaluSales.cshtml"
                                  }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"     <input type=""submit"" value=""하루 매출 계산하기"" class=""btn btn-primary"" />
     <input type=""button"" value=""메인 화면으로 돌아가기"" class=""btn btn-primary"" onclick=""location.href='/Home/Index'"" />
    <input type=""button"" value=""뒤로가기"" class=""btn btn-primary"" onclick='history.go(-1);' />
    ");
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
            WriteLiteral("\r\n  </div>\r\n");
#nullable restore
#line 34 "D:\4\Clould\work\webapp_asp\Views\Menu\CaluSales.cshtml"
}
else 
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""text-center"">
    <h1 class=""display-4"">Online Chicken Delivery Main Site </h1> <br>
    <h3>관리자 모드는 관리자 전용임. </h3> <br>
    <br>
    <br>
    <input type=""button"" value=""로그인"" class=""btn btn-primary"" onclick=""location.href='../Home/Index'"" />
    <input type=""button"" value=""뒤로가기"" class=""btn btn-primary"" onclick='history.go(-1);' />
</div>
");
#nullable restore
#line 45 "D:\4\Clould\work\webapp_asp\Views\Menu\CaluSales.cshtml"
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