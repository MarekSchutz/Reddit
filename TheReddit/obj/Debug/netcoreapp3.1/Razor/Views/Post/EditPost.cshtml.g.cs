#pragma checksum "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "980e72c4f248615acc4e5d8a921a030854507d4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_EditPost), @"mvc.1.0.view", @"/Views/Post/EditPost.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"980e72c4f248615acc4e5d8a921a030854507d4b", @"/Views/Post/EditPost.cshtml")]
    public class Views_Post_EditPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TheReddit.Models.PostViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Styles/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/UserPosts"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "980e72c4f248615acc4e5d8a921a030854507d4b3961", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Index</title>
    <script defer src=""https://code.getmdl.io/1.3.0/material.min.js""></script>
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/icon?family=Material+Icons"">
    <link rel=""stylesheet"" href=""https://code.getmdl.io/1.3.0/material.lime-indigo.min.css"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "980e72c4f248615acc4e5d8a921a030854507d4b4589", async() => {
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
                WriteLiteral("\r\n    <script src=\"https://kit.fontawesome.com/59a839ad30.js\" crossorigin=\"anonymous\"></script>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "980e72c4f248615acc4e5d8a921a030854507d4b6572", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
    <div class=""mdl-layout mdl-js-layout mdl-layout--fixed-header"">
        <header class=""mdl-layout__header"">
            <div class=""mdl-layout__header-row"">
                <span class=""mdl-layout-title"">TheReddit</span>
                <a class=""mdl-navigation__link"" href=""/"">Show trending</a>
                <a class=""mdl-navigation__link"" href=""/?filter=all"">Show all posts</a>
                <div class=""m");
                WriteLiteral("dl-layout-spacer\"></div>\r\n                <nav class=\"mdl-navigation mdl-layout--large-screen-only\">\r\n                    <a class=\"mdl-navigation__link\" href=\"/\">Home</a>\r\n");
#nullable restore
#line 27 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a class=\"mdl-navigation__link\" href=\"Account/Logout\">");
#nullable restore
#line 29 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
                                                                         Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" [Logout]</a>\r\n                        <a class=\"mdl-navigation__link\" href=\"Home/UserPosts\">Show my posts</a>\r\n");
#nullable restore
#line 31 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a class=\"mdl-navigation__link\" href=\"Account/Login\">Login</a>\r\n                        <a class=\"mdl-navigation__link\" href=\"User/AddUser\">Register</a>\r\n");
#nullable restore
#line 36 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </nav>\r\n            </div>\r\n        </header>\r\n        <main class=\"mdl-layout__content\">\r\n            <div class=\"page-content\">\r\n");
#nullable restore
#line 42 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
                 using (Html.BeginForm("EditPost", "Post", FormMethod.Post))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
               Write(Html.HiddenFor(p => p.Post.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
               Write(Html.HiddenFor(p => p.Post.Likes));

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
               Write(Html.HiddenFor(p => p.Post.Created));

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"mdl-textfield mdl-js-textfield\">\r\n                        <div class=\"mdl-textfield__label\">\r\n                            ");
#nullable restore
#line 49 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
                       Write(Html.Label("Title:"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div><br />\r\n                        <div class=\"mdl-textfield__input\">\r\n                            ");
#nullable restore
#line 52 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
                       Write(Html.TextBoxFor(p => p.Post.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n\r\n                    </div><br />\r\n                    <div class=\"mdl-textfield mdl-js-textfield\">\r\n                        <div class=\"mdl-textfield__label\">\r\n                            ");
#nullable restore
#line 58 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
                       Write(Html.Label("Url:"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div><br />\r\n                        <div class=\"mdl-textfield__input\">\r\n                            ");
#nullable restore
#line 61 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
                       Write(Html.TextBoxFor(p => p.Post.Url));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div><br />\r\n                    <input class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent\" type=\"submit\" value=\"Edit\" />\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "980e72c4f248615acc4e5d8a921a030854507d4b12589", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 66 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </main>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TheReddit.Models.PostViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
