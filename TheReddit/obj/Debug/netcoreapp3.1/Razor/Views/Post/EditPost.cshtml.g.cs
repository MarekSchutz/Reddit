#pragma checksum "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b6b07854ad01cdb5bfcccdc74c186eb0a68782b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b6b07854ad01cdb5bfcccdc74c186eb0a68782b", @"/Views/Post/EditPost.cshtml")]
    public class Views_Post_EditPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TheReddit.Models.PostViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/UserPosts"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b6b07854ad01cdb5bfcccdc74c186eb0a68782b3263", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>The Reddit GFA</title>

    <link rel=""canonical"" href=""https://getbootstrap.com/docs/4.4/examples/album/"">

    <!-- Bootstrap core CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">

    <!-- Favicons -->
    <link rel=""apple-touch-icon"" href=""/docs/4.4/assets/img/favicons/apple-touch-icon.png"" sizes=""180x180"">
    <link rel=""icon"" href=""/docs/4.4/assets/img/favicons/favicon-32x32.png"" sizes=""32x32"" type=""image/png"">
    <link rel=""icon"" href=""/docs/4.4/assets/img/favicons/favicon-16x16.png"" sizes=""16x16"" type=""image/png"">
    <link rel=""manifest"" href=""/docs/4.4/assets/img/favicons/manifest.json"">
    <link rel=""mask-icon"" href=""/docs/4.4/assets/img/favicons/safari-pinned-tab.svg"" color=""#563d7c"">
    <link rel=""icon"" href=""/docs/4.4/assets/img/favicons/favicon.ico"">
    <meta name=");
                WriteLiteral(@"""msapplication-config"" content=""/docs/4.4/assets/img/favicons/browserconfig.xml"">
    <meta name=""theme-color"" content=""#563d7c"">
    <script src=""https://kit.fontawesome.com/59a839ad30.js"" crossorigin=""anonymous""></script>

    <!-- Custom styles for this template -->
    <link href=""album.css"" rel=""stylesheet"">
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b6b07854ad01cdb5bfcccdc74c186eb0a68782b5673", async() => {
                WriteLiteral(@"
    <header>
        <div class=""collapse bg-dark"" id=""navbarHeader"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-sm-8 col-md-7 py-4"">
                    </div>
                    <div class=""col-sm-4 offset-md-1 py-4"">
");
#nullable restore
#line 35 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <h4 class=\"text-white\">Hello ");
#nullable restore
#line 37 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
                                                    Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h4>
                            <ul class=""list-unstyled"">
                                <li><a href=""Home/UserPosts"" class=""text-white"">Show my posts</a></li>
                                <li><a href=""Account/Logout"" class=""text-white"">Logout</a></li>
                            </ul>
");
#nullable restore
#line 42 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <h4 class=""text-white"">Please login</h4>
                            <ul class=""list-unstyled"">
                                <li><a href=""User/AddUser"" class=""text-white"">Register</a></li>
                                <li><a href=""Account/Login"" class=""text-white"">Login</a></li>
                            </ul>
");
#nullable restore
#line 50 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
        <div class=""navbar navbar-dark bg-dark shadow-sm"">
            <div class=""container d-flex justify-content-between"">
                <a href=""/"" class=""navbar-brand d-flex align-items-center"">
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""20"" height=""20"" fill=""none"" stroke=""currentColor"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" aria-hidden=""true"" class=""mr-2"" viewBox=""0 0 24 24"" focusable=""false""><path d=""M23 19a2 2 0 0 1-2 2H3a2 2 0 0 1-2-2V8a2 2 0 0 1 2-2h4l2-3h6l2 3h4a2 2 0 0 1 2 2z"" /><circle cx=""12"" cy=""13"" r=""4"" /></svg>
                    <strong>The Reddit</strong>
                </a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarHeader"" aria-controls=""navbarHeader"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                ");
                WriteLiteral("</button>\r\n            </div>\r\n        </div>\r\n    </header>\r\n    <main class=\"mdl-layout__content\">\r\n        <div class=\"justify-content-center\" style=\"text-align: center; margin-top:20px \">\r\n");
#nullable restore
#line 69 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
             using (Html.BeginForm("EditPost", "Post", FormMethod.Post))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
           Write(Html.HiddenFor(p => p.Post.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
           Write(Html.HiddenFor(p => p.Post.Likes));

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
           Write(Html.HiddenFor(p => p.Post.Created));

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div>\r\n                    <div>\r\n                        ");
#nullable restore
#line 76 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
                   Write(Html.Label("Title:"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div><br />\r\n                    <div>\r\n                        ");
#nullable restore
#line 79 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
                   Write(Html.TextBoxFor(p => p.Post.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n\r\n                </div><br />\r\n                <div>\r\n                    <div>\r\n                        ");
#nullable restore
#line 85 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
                   Write(Html.Label("Url:"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div><br />\r\n                    <div>\r\n                        ");
#nullable restore
#line 88 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
                   Write(Html.TextBoxFor(p => p.Post.Url));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div><br />\r\n                <input type=\"submit\" value=\"Edit\" />\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b6b07854ad01cdb5bfcccdc74c186eb0a68782b11815", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 93 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Post\EditPost.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </div>
    </main>

    <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
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
