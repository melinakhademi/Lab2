#pragma checksum "/Users/melinakhademi/Desktop/Applied Web Architecture/Labs/Lab2/lab2-melinakhademi/Views/Home/GenreDrama.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60aed9749d746f6af073026e0e567ffcbc1c6827"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GenreDrama), @"mvc.1.0.view", @"/Views/Home/GenreDrama.cshtml")]
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
#line 1 "/Users/melinakhademi/Desktop/Applied Web Architecture/Labs/Lab2/lab2-melinakhademi/Views/_ViewImports.cshtml"
using MovieLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/melinakhademi/Desktop/Applied Web Architecture/Labs/Lab2/lab2-melinakhademi/Views/_ViewImports.cshtml"
using MovieLab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60aed9749d746f6af073026e0e567ffcbc1c6827", @"/Views/Home/GenreDrama.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"991a69292ea27371af9a9dc4685e2126a27328ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GenreDrama : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "/Users/melinakhademi/Desktop/Applied Web Architecture/Labs/Lab2/lab2-melinakhademi/Views/Home/GenreDrama.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<h3>This is a list of movies with the genre Drama.</h3>\r\n<p>There are ");
#nullable restore
#line 6 "/Users/melinakhademi/Desktop/Applied Web Architecture/Labs/Lab2/lab2-melinakhademi/Views/Home/GenreDrama.cshtml"
        Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" movies in this category</p>\r\n\r\n");
#nullable restore
#line 8 "/Users/melinakhademi/Desktop/Applied Web Architecture/Labs/Lab2/lab2-melinakhademi/Views/Home/GenreDrama.cshtml"
 foreach (var movie in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div><a");
            BeginWriteAttribute("href", " href=\"", 212, "\"", 249, 2);
            WriteAttributeValue("", 219, "/Home/MovieDetails/", 219, 19, true);
#nullable restore
#line 10 "/Users/melinakhademi/Desktop/Applied Web Architecture/Labs/Lab2/lab2-melinakhademi/Views/Home/GenreDrama.cshtml"
WriteAttributeValue("", 238, movie.Id, 238, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 10 "/Users/melinakhademi/Desktop/Applied Web Architecture/Labs/Lab2/lab2-melinakhademi/Views/Home/GenreDrama.cshtml"
                                             Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> - ");
#nullable restore
#line 10 "/Users/melinakhademi/Desktop/Applied Web Architecture/Labs/Lab2/lab2-melinakhademi/Views/Home/GenreDrama.cshtml"
                                                                Write(movie.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 11 "/Users/melinakhademi/Desktop/Applied Web Architecture/Labs/Lab2/lab2-melinakhademi/Views/Home/GenreDrama.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
