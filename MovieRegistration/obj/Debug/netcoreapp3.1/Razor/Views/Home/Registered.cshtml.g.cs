#pragma checksum "C:\Users\HPHAN1\OneDrive - Knex\Desktop\HuyP\DevB\HTMLPractice\LABMovieRegistration\MovieRegistration\Views\Home\Registered.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43ff26653c4766ac336bf3d388de820d60aade33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registered), @"mvc.1.0.view", @"/Views/Home/Registered.cshtml")]
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
#line 1 "C:\Users\HPHAN1\OneDrive - Knex\Desktop\HuyP\DevB\HTMLPractice\LABMovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HPHAN1\OneDrive - Knex\Desktop\HuyP\DevB\HTMLPractice\LABMovieRegistration\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43ff26653c4766ac336bf3d388de820d60aade33", @"/Views/Home/Registered.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edb0700316839935d5586746ff80ad9306f8388", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Registered : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p> Your movie is registered: </p>\r\n<p>ID: ");
#nullable restore
#line 4 "C:\Users\HPHAN1\OneDrive - Knex\Desktop\HuyP\DevB\HTMLPractice\LABMovieRegistration\MovieRegistration\Views\Home\Registered.cshtml"
  Write(Model.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Title: ");
#nullable restore
#line 5 "C:\Users\HPHAN1\OneDrive - Knex\Desktop\HuyP\DevB\HTMLPractice\LABMovieRegistration\MovieRegistration\Views\Home\Registered.cshtml"
     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Genre: ");
#nullable restore
#line 6 "C:\Users\HPHAN1\OneDrive - Knex\Desktop\HuyP\DevB\HTMLPractice\LABMovieRegistration\MovieRegistration\Views\Home\Registered.cshtml"
     Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Year: ");
#nullable restore
#line 7 "C:\Users\HPHAN1\OneDrive - Knex\Desktop\HuyP\DevB\HTMLPractice\LABMovieRegistration\MovieRegistration\Views\Home\Registered.cshtml"
    Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Actors: ");
#nullable restore
#line 8 "C:\Users\HPHAN1\OneDrive - Knex\Desktop\HuyP\DevB\HTMLPractice\LABMovieRegistration\MovieRegistration\Views\Home\Registered.cshtml"
      Write(Model.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Directors: ");
#nullable restore
#line 9 "C:\Users\HPHAN1\OneDrive - Knex\Desktop\HuyP\DevB\HTMLPractice\LABMovieRegistration\MovieRegistration\Views\Home\Registered.cshtml"
         Write(Model.Directors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
