#pragma checksum "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75412883d0bd220163160357b8201a1fdc696613"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
using OrderingWebsite.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75412883d0bd220163160357b8201a1fdc696613", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Menu>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/element-ui/theme-chalk/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/vue/vue.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/element-ui/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75412883d0bd220163160357b8201a1fdc6966136058", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>Index</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "75412883d0bd220163160357b8201a1fdc6966136464", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "75412883d0bd220163160357b8201a1fdc6966137627", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75412883d0bd220163160357b8201a1fdc6966138790", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75412883d0bd220163160357b8201a1fdc6966139961", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75412883d0bd220163160357b8201a1fdc69661311132", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75412883d0bd220163160357b8201a1fdc69661312304", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75412883d0bd220163160357b8201a1fdc69661314168", async() => {
                WriteLiteral(@"
    <div id=""app"">
        <template>
            <el-container>
                <el-header>
                    <div style="" width: 230px; height: 50px; text-align: center;
                                    line-height: 60px; color: #fff; font-size: 20px;"">
                        <span class=""big"">");
#nullable restore
#line 25 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                     Write(ViewData["system_name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                    </div>\r\n                    <div style=\"margin-top: -31px;  margin-left: 250px; width:100px; text-align:left;\">\r\n                        <span ");
                WriteLiteral(@"@click=""menuToggle"">
                            <i class=""el-icon-menu""></i>
                        </span>
                    </div>
                    <div style=""margin-top: -24px;  margin-left: 330px; text-align:right;"">
                        当前用户：{{username}}
                    </div>
                </el-header>
                <el-container>
                    <el-aside width=""230px"">
                        <el-menu :default-active=""tabsIndex""
                                 class=""el-menu-vertical-demo""
                                 ");
                WriteLiteral("@open=\"handleOpen\"\r\n                                 ");
                WriteLiteral(@"@close=""handleClose""
                                 background-color=""#222d32""
                                 text-color=""#fff""
                                 active-text-color=""#ffd04b""
                                 style=""height:100%;""
                                 :collapse=""isCollapse"">
");
#nullable restore
#line 47 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                             foreach (var item in Model)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                 if (item.path.Contains("/") && item.parentId == "0")
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <el-menu-item");
                BeginWriteAttribute("index", " index=\"", 2385, "\"", 2403, 1);
#nullable restore
#line 51 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
WriteAttributeValue("", 2393, item.name, 2393, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
                WriteLiteral("@click=\"addTab(\'");
#nullable restore
#line 51 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                                                                 Write(item.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\'");
#nullable restore
#line 51 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                                                                               Write(item.path);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\'");
#nullable restore
#line 51 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                                                                                            Write(item.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\">\r\n                                        <i");
                BeginWriteAttribute("class", " class=\"", 2508, "\"", 2526, 1);
#nullable restore
#line 52 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
WriteAttributeValue("", 2516, item.icon, 2516, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>\r\n                                        <span slot=\"title\">");
#nullable restore
#line 53 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                                      Write(item.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                    </el-menu-item>\r\n");
#nullable restore
#line 55 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                }
                                else if (item.parentId == "0")
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <el-submenu");
                BeginWriteAttribute("index", " index=\"", 2847, "\"", 2865, 1);
#nullable restore
#line 58 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
WriteAttributeValue("", 2855, item.name, 2855, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <template slot=\"title\">\r\n                                            <i");
                BeginWriteAttribute("class", " class=\"", 2980, "\"", 2998, 1);
#nullable restore
#line 60 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
WriteAttributeValue("", 2988, item.icon, 2988, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>\r\n                                            <span slot=\"title\">");
#nullable restore
#line 61 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                                          Write(item.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                        </template>\r\n");
#nullable restore
#line 63 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                          
                                            var childMenu = Model.Where<Menu>(m => m.parentId == item.id);
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                         foreach (var item2 in childMenu)
                                        {
                                            if (item2.path.Contains("/"))
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <el-menu-item");
                BeginWriteAttribute("index", " index=\"", 3638, "\"", 3657, 1);
#nullable restore
#line 70 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
WriteAttributeValue("", 3646, item2.name, 3646, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
                WriteLiteral("@click=\"addTab(\'");
#nullable restore
#line 70 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                                                                              Write(item2.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\'");
#nullable restore
#line 70 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                                                                                             Write(item2.path);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\'");
#nullable restore
#line 70 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                                                                                                           Write(item2.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\">\r\n                                                    <i");
                BeginWriteAttribute("class", " class=\"", 3777, "\"", 3796, 1);
#nullable restore
#line 71 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
WriteAttributeValue("", 3785, item2.icon, 3785, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>\r\n                                                    <span slot=\"title\">");
#nullable restore
#line 72 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                                                  Write(item2.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                </el-menu-item>\r\n");
#nullable restore
#line 74 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <el-submenu");
                BeginWriteAttribute("index", " index=\"", 4164, "\"", 4183, 1);
#nullable restore
#line 77 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
WriteAttributeValue("", 4172, item2.name, 4172, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    <template slot=\"title\">\r\n                                                        <i");
                BeginWriteAttribute("class", " class=\"", 4322, "\"", 4341, 1);
#nullable restore
#line 79 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
WriteAttributeValue("", 4330, item2.icon, 4330, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>\r\n                                                        <span slot=\"title\">");
#nullable restore
#line 80 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                                                      Write(item2.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                    </template>\r\n");
#nullable restore
#line 82 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                                      
                                                        var childMenu2 = Model.Where<Menu>(m => m.parentId == item2.id);
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                                     foreach (var item3 in childMenu2)
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <el-menu-item");
                BeginWriteAttribute("index", " index=\"", 4955, "\"", 4974, 1);
#nullable restore
#line 87 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
WriteAttributeValue("", 4963, item3.name, 4963, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
                WriteLiteral("@click=\"addTab(\'");
#nullable restore
#line 87 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                                                                                      Write(item3.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\'");
#nullable restore
#line 87 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                                                                                                     Write(item3.path);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\'");
#nullable restore
#line 87 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                                                                                                                   Write(item3.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\">\r\n                                                            <i");
                BeginWriteAttribute("class", " class=\"", 5102, "\"", 5121, 1);
#nullable restore
#line 88 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
WriteAttributeValue("", 5110, item3.icon, 5110, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>\r\n                                                            <span slot=\"title\">");
#nullable restore
#line 89 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                                                          Write(item3.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                        </el-menu-item>\r\n");
#nullable restore
#line 91 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                </el-submenu>\r\n");
#nullable restore
#line 93 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </el-submenu>\r\n");
#nullable restore
#line 96 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </el-menu>\r\n                    </el-aside>\r\n                    <el-main v-bind:class=\"{main_toggle:isCollapse}\">\r\n                        <el-tabs v-model=\"tabsIndex\" type=\"border-card\" closable\r\n                                 ");
                WriteLiteral(@"@tab-remove=""removeTab""
                                 style=""height:100%;min-width:900px;"">
                            <el-tab-pane v-for=""(item, index) in tabsData""
                                         :key=""item.name""
                                         :label=""item.title""
                                         :name=""item.name""
                                         style=""height:100%;"">
                                <div :id=""'tab_'+item.name""></div>
                                <component :is=""item.content"" :ref=""item.name""
                                           :tabIndex=""item.name""></component>

                            </el-tab-pane>
                        </el-tabs>
                    </el-main>
                </el-container>
            </el-container>
        </template>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>
<script>

    var table_s = {
        template: '<el-table border v-bind:data=""tableData"" style=""width: 100%""  ><el-table-column prop=""date"" label=""日期""  width=""180"">'
            + ' </el-table-column> <el-table-column prop=""name"" label=""姓名"" width=""180""></el-table-column><el-table-column prop=""address"" label=""地址"">'
            + '</el-table-column></el-table >',
        data() {
            return {
                tableData: [
                    {
                        date: '2020-06-25',
                        name: '王小虎',
                        address: '上海市普陀区金沙江路 1518 弄',
                    }, {
                        date: '2020-06-25',
                        name: '王小虎',
                        address: '上海市普陀区金沙江路 1518 弄'
                    }, {
                        date: '2020-06-25',
                        name: '王小虎',
                        address: '上海市普陀区金沙江路 1518 弄',
                    }, {
                        date: '2020-06-25',
             ");
            WriteLiteral(@"           name: '王小虎',
                        address: '上海市普陀区金沙江路 1518 弄'
                    }
                ]
            }
        }
    }
    var app = new Vue({
        el: ""#app"",
        data: {
            isCollapse:false,
            username: '");
#nullable restore
#line 156 "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Home/Index.cshtml"
                  Write(Html.Raw(ViewData["username"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            tabsData: [{
                name: '1',
                title: '首页',
                content: table_s
            }],
            tabsIndex: ""1""
        },
        methods: {
            handleOpen(key, keyPath) {
                console.log(key, keyPath);
            },
            handleClose(key, keyPath) {
                console.log(key, keyPath);
            },
            menuToggle() {
                if (this.isCollapse) {

                    this.isCollapse = false;
                } else {

                    this.isCollapse = true;
                }
            },
            addTab(title, path, name) {
                console.log(title + "","" + path + "","" + name);
                let flag = false;
                let tabs = this.tabsData;
                var self = this;
                for (let tab of tabs) {
                    if (tab.name === name) {
                        this.tabsIndex = name;
                        flag = true;
           ");
            WriteLiteral(@"             return false;
                    }
                }
                if (!flag) {
                    this.tabsData.push({
                        title: title,
                        name: name,
                        content: null
                    });
                    this.tabsIndex = name;
                    $.post(path, function (result) {
                        $(""#tab_"" + name).html(result);
                        self.tabsData[self.tabsData.length - 1].content = eval(name);
                    });
                }
            },
            removeTab(targetName) {
                let tabs = this.tabsData;
                let activeName = this.tabsIndex;
                if (activeName === targetName) {
                    tabs.forEach((tab, index) => {
                        if (tab.name === targetName) {
                            let nextTab = tabs[index + 1] || tabs[index - 1];
                            if (nextTab) {
                             ");
            WriteLiteral(@"   activeName = nextTab.name;
                            }
                        }
                    });
                }
                this.tabsIndex = activeName;
                this.tabsData = tabs.filter(tab => tab.name !== targetName);
            },
        }
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Menu>> Html { get; private set; }
    }
}
#pragma warning restore 1591