#pragma checksum "C:\Users\amina\Desktop\StudioGhibili\StudioGhibili\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69e88e098b0d2c5300c6fb0a972c99a8ab832dc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StudioGhibili.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace StudioGhibili.Pages
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
#line 1 "C:\Users\amina\Desktop\StudioGhibili\StudioGhibili\Pages\_ViewImports.cshtml"
using StudioGhibili;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\amina\Desktop\StudioGhibili\StudioGhibili\Pages\Index.cshtml"
using StudioGhibili.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\amina\Desktop\StudioGhibili\StudioGhibili\Pages\Index.cshtml"
using StudioGhibili.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69e88e098b0d2c5300c6fb0a972c99a8ab832dc7", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c6d6fa4594d713778ce0680d8209a130d98150c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\amina\Desktop\StudioGhibili\StudioGhibili\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- This is Razor (cshtml)

    where C# (Server-Side not JS) goes after the AT

-->
<!-- L1: this line ""deractive"" specities it is a Razor page  -->
<!-- L2: From Class L12 in the nested file index.cshtml.cs
    This model ""IndexModel"" associated with this page knows about the other data that should be displayed
  -->
<!-- L3: Set the page title , in the title tag of HTML doc in the Layout  -->

<div class=""text-center"">
    <br />
    <h3 class=""display-6 title"">Welcome to Studio Ghibili Gallery 2020 - 2021<br /></h3><h1 class=""display-4 title"" style=""font-family: 'Racing Sans One', cursive; color:lightseagreen"">Super-girls</h1>
    <!--<button onclick=""count"" type=""button"">Count Letters in file</button>-->
    <br />
    <h1>Now is ");
#nullable restore
#line 23 "C:\Users\amina\Desktop\StudioGhibili\StudioGhibili\Pages\Index.cshtml"
          Write(Model.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <br />\r\n</div>\r\n\r\n<!--  Add ");
            WriteLiteral(" -->\r\n<!-- Await, cuz its predefined Async func - this Async func renders our component as name its specified -->\r\n");
#nullable restore
#line 29 "C:\Users\amina\Desktop\StudioGhibili\StudioGhibili\Pages\Index.cshtml"
Write(await Html.RenderComponentAsync<CharacterList>(RenderMode.ServerPrerendered));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--  Blazor needs JavaScript, so add this JS file into index or Layout -->
<script src=""_framework/blazor.server.js""></script>














<!-- UPDATE: we're moving this block to RAZOR component that has some code and more advance -->
<!--<div class=""card-columns colored"">-->
<!-- Model here is referring to the model in L2-->
<!--");
#nullable restore
#line 49 "C:\Users\amina\Desktop\StudioGhibili\StudioGhibili\Pages\Index.cshtml"
     foreach (var character in Model.Characters)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h3 class=\"card-title\" style=\"color:cornflowerblue; font-family:Arial, Helvetica, sans-serif; font-weight:bolder;\">");
#nullable restore
#line 53 "C:\Users\amina\Desktop\StudioGhibili\StudioGhibili\Pages\Index.cshtml"
                                                                                                                          Write(character.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</h3>\r\n            <div class=\"card-text\"><h5>From Movie: <span style=\"font-style: italic\">");
#nullable restore
#line 54 "C:\Users\amina\Desktop\StudioGhibili\StudioGhibili\Pages\Index.cshtml"
                                                                               Write(character.movie);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;");
#nullable restore
#line 54 "C:\Users\amina\Desktop\StudioGhibili\StudioGhibili\Pages\Index.cshtml"
                                                                                                     Write(character.year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n            <br />\r\n            <h6>");
#nullable restore
#line 56 "C:\Users\amina\Desktop\StudioGhibili\StudioGhibili\Pages\Index.cshtml"
           Write(character.descripition);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</h6>\r\n            </div>\r\n        </div>\r\n        <div class=\"card-img\"");
            BeginWriteAttribute("style", " style=\"", 2034, "\"", 2100, 7);
            WriteAttributeValue("", 2042, "background-image:", 2042, 17, true);
            WriteAttributeValue(" ", 2059, "url(\'", 2060, 6, true);
#nullable restore
#line 59 "C:\Users\amina\Desktop\StudioGhibili\StudioGhibili\Pages\Index.cshtml"
WriteAttributeValue("", 2065, character.image, 2065, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2081, "\');", 2081, 3, true);
            WriteAttributeValue(" ", 2084, "height:", 2085, 8, true);
            WriteAttributeValue(" ", 2092, "250px;", 2093, 7, true);
            WriteAttributeValue(" ", 2099, "", 2100, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 62 "C:\Users\amina\Desktop\StudioGhibili\StudioGhibili\Pages\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
