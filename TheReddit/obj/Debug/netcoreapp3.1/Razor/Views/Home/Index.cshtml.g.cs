#pragma checksum "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37b4148a878bfbc564af00ff2a619a4a04da2fc2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37b4148a878bfbc564af00ff2a619a4a04da2fc2", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TheReddit.Models.PostViewModel>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37b4148a878bfbc564af00ff2a619a4a04da2fc22735", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37b4148a878bfbc564af00ff2a619a4a04da2fc25145", async() => {
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
#line 35 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Home\Index.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <h4 class=\"text-white\">Hello ");
#nullable restore
#line 37 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Home\Index.cshtml"
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
#line 42 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Home\Index.cshtml"
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
#line 50 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Home\Index.cshtml"
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
                WriteLiteral("</button>\r\n            </div>\r\n        </div>\r\n    </header>\r\n\r\n    <main role=\"main\">\r\n");
#nullable restore
#line 69 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Home\Index.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <section class=\"jumbotron text-center\">\r\n                <div class=\"container\">\r\n                    <h1>Welcome, ");
#nullable restore
#line 73 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Home\Index.cshtml"
                            Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                </div>\r\n            </section>\r\n");
#nullable restore
#line 76 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Home\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <section class=\"jumbotron text-center\">\r\n                <div class=\"container\">\r\n                    <h1>Welcome to Reddit</h1>\r\n                </div>\r\n            </section>\r\n");
#nullable restore
#line 84 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"album py-5 bg-light\">\r\n            <div class=\"container\">\r\n\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 90 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Home\Index.cshtml"
                     foreach (var post in Model.Posts)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"col-md-4\">\r\n                            <div class=\"card mb-4 shadow-sm\">\r\n                                <div class=\"card-body\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 4670, "\"", 4686, 1);
#nullable restore
#line 95 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Home\Index.cshtml"
WriteAttributeValue("", 4677, post.Url, 4677, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\" class=\"card-text\">");
#nullable restore
#line 95 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Home\Index.cshtml"
                                                                                     Write(post.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                    <div class=\"d-flex justify-content-between align-items-center\">\r\n                                        <div class=\"btn-group\">\r\n                                            <a");
                BeginWriteAttribute("href", " href=\"", 4951, "\"", 4986, 2);
                WriteAttributeValue("", 4958, "Post/Vote?vote=1&id=", 4958, 20, true);
#nullable restore
#line 98 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Home\Index.cshtml"
WriteAttributeValue("", 4978, post.Id, 4978, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-arrow-circle-up fa-lg\" style=\"color:green\"></i></a>\r\n                                        </div>\r\n                                        <div class=\"btn-group\" >\r\n                                            <a");
                BeginWriteAttribute("href", " href=\"", 5218, "\"", 5254, 2);
                WriteAttributeValue("", 5225, "Post/Vote?vote=-1&id=", 5225, 21, true);
#nullable restore
#line 101 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Home\Index.cshtml"
WriteAttributeValue("", 5246, post.Id, 5246, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-arrow-circle-down fa-lg\" style=\"color:red\"></i></a>\r\n                                        </div>\r\n                                        <small class=\"text-muted\">Likes: ");
#nullable restore
#line 103 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Home\Index.cshtml"
                                                                    Write(post.Likes);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n                                        <small class=\"text-muted\">Likes: ");
#nullable restore
#line 104 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Home\Index.cshtml"
                                                                    Write(post.Created);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 110 "C:\Users\Marek\Desktop\greenfox\Reddit\TheReddit\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <input class=""btn btn-primary my-2"" type=""button"" value=""Add new post"" onclick=""location.href='Post/AddPost'"" />
            </div>
        </div>

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
            WriteLiteral("\r\n</html>");
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
