#pragma checksum "D:\4\Clould\work\webapp_asp\Views\Menu\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67b151d0ac987c0aca0c609e553da3b7c40f0334"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Admin), @"mvc.1.0.view", @"/Views/Menu/Admin.cshtml")]
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
#line 2 "D:\4\Clould\work\webapp_asp\Views\Menu\Admin.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67b151d0ac987c0aca0c609e553da3b7c40f0334", @"/Views/Menu/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e404aefea4181f3910f2680fd39aa912e3a39921", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<webapp_asp.Models.Menu>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CaluSales", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\4\Clould\work\webapp_asp\Views\Menu\Admin.cshtml"
  
    ViewData["Title"] = "Administrator Mode";
    var id = @Context.Session.GetString("id");

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    div{\r\n       font-family: ??????????????? ????????? Pro; \r\n    }\r\n</style>\r\n\r\n");
#nullable restore
#line 13 "D:\4\Clould\work\webapp_asp\Views\Menu\Admin.cshtml"
 if(id == "admin")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"   <div class=""text-center"">
    <h1 class=""display-4"">Online Chicken Delivery Admin Page </h1> <br>
    <h4>????????? ??????</h4> <br>
    <h6>????????? ??????????????? ?????? ??????, ??????, ?????? ??? ?????? ?????? ????????? ???????????????. </h6> <br>
    <input type=""button"" class=""btn btn-primary"" value=""?????? ??????"" onclick=""location.href='/Menu/AddMenu'"" />
    <input type=""button"" class=""btn btn-primary"" value=""??????"" onclick=""window.print()"" />
     <table class=""table"">
      <thead>
      <tr>
        <th>?????? ??????</th>
        <th>?????? ??????</th>
        <th>??????</th>
        <th>??????(??????: KRW: ???)</th>
        <th>?????? ???</th>
      </tr>
      </thead>
     <tbody>
    <tr>
");
#nullable restore
#line 33 "D:\4\Clould\work\webapp_asp\Views\Menu\Admin.cshtml"
         foreach (var Item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <td>");
#nullable restore
#line 35 "D:\4\Clould\work\webapp_asp\Views\Menu\Admin.cshtml"
      Write(Html.DisplayFor(modelltem => Item.number));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 36 "D:\4\Clould\work\webapp_asp\Views\Menu\Admin.cshtml"
      Write(Html.DisplayFor(modelltem => Item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 37 "D:\4\Clould\work\webapp_asp\Views\Menu\Admin.cshtml"
      Write(Html.DisplayFor(modelltem => Item.amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 38 "D:\4\Clould\work\webapp_asp\Views\Menu\Admin.cshtml"
      Write(Html.DisplayFor(modelltem => Item.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 39 "D:\4\Clould\work\webapp_asp\Views\Menu\Admin.cshtml"
      Write(Html.DisplayFor(modelltem => Item.sales));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n       <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67b151d0ac987c0aca0c609e553da3b7c40f03346961", async() => {
                WriteLiteral("?????? ??????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "D:\4\Clould\work\webapp_asp\Views\Menu\Admin.cshtml"
                                                            WriteLiteral(Item.number);

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
            WriteLiteral("</td>\r\n       <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67b151d0ac987c0aca0c609e553da3b7c40f03349328", async() => {
                WriteLiteral("?????? ??????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "D:\4\Clould\work\webapp_asp\Views\Menu\Admin.cshtml"
                                                              WriteLiteral(Item.number);

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
            WriteLiteral("</td>\r\n       <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67b151d0ac987c0aca0c609e553da3b7c40f033411697", async() => {
                WriteLiteral("?????? ??????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\4\Clould\work\webapp_asp\Views\Menu\Admin.cshtml"
                                                             WriteLiteral(Item.number);

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
            WriteLiteral("</td>\r\n");
#nullable restore
#line 43 "D:\4\Clould\work\webapp_asp\Views\Menu\Admin.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("       </tr>\r\n     </tbody>\r\n    </table>\r\n  </div>\r\n");
#nullable restore
#line 48 "D:\4\Clould\work\webapp_asp\Views\Menu\Admin.cshtml"
}
else 
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""text-center"">
    <h1 class=""display-4"">Online Chicken Delivery Main Site </h1> <br>
    <br>
    <h3>????????? ????????? ????????? ?????????. </h3> <br>
    <br>
    <br>
    <p><input type=""button"" value=""?????????"" class=""btn btn-primary"" onclick=""location.href='/Home/Index'"" />
    <input type=""button"" value=""????????????"" class=""btn btn-primary"" onclick='history.go(-1);' /></p>
</div>
");
#nullable restore
#line 60 "D:\4\Clould\work\webapp_asp\Views\Menu\Admin.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<webapp_asp.Models.Menu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
