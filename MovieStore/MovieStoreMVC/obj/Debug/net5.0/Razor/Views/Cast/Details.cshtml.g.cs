#pragma checksum "E:\DotNetCore\MovieStore\MovieStoreMVC\Views\Cast\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f18dfaeedf112c1287dbde8ce574acc8274159b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cast_Details), @"mvc.1.0.view", @"/Views/Cast/Details.cshtml")]
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
#line 1 "E:\DotNetCore\MovieStore\MovieStoreMVC\Views\_ViewImports.cshtml"
using MovieStoreMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DotNetCore\MovieStore\MovieStoreMVC\Views\_ViewImports.cshtml"
using MovieStoreMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f18dfaeedf112c1287dbde8ce574acc8274159b2", @"/Views/Cast/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dfe7f2ba5deeb3392f3f0dcafcf530cd0fa3159", @"/Views/_ViewImports.cshtml")]
    public class Views_Cast_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationCore.Models.CastDetailsResponseModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\DotNetCore\MovieStore\MovieStoreMVC\Views\Cast\Details.cshtml"
  
    ViewData["Title"] = "Cast Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <img");
            BeginWriteAttribute("src", " src=", 205, "", 228, 1);
#nullable restore
#line 10 "E:\DotNetCore\MovieStore\MovieStoreMVC\Views\Cast\Details.cshtml"
WriteAttributeValue("", 210, Model.ProfilePath, 210, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded-lg float-right\"\r\n                 alt=\"Cast Profile Image\" />\r\n        </div>\r\n        <div class=\"col\">\r\n            <h1>Name: ");
#nullable restore
#line 14 "E:\DotNetCore\MovieStore\MovieStoreMVC\Views\Cast\Details.cshtml"
                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 15 "E:\DotNetCore\MovieStore\MovieStoreMVC\Views\Cast\Details.cshtml"
              
                switch (Model.Gender)
                {
                    case "1":

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3>Gender: Female</h3>\r\n");
#nullable restore
#line 20 "E:\DotNetCore\MovieStore\MovieStoreMVC\Views\Cast\Details.cshtml"
                        break;
                    case "2":

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3>Gender: Male</h3>\r\n");
#nullable restore
#line 23 "E:\DotNetCore\MovieStore\MovieStoreMVC\Views\Cast\Details.cshtml"
                        break;
                    default:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3>Gender: N/A</h3>\r\n");
#nullable restore
#line 26 "E:\DotNetCore\MovieStore\MovieStoreMVC\Views\Cast\Details.cshtml"
                        break;
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>List of Movies:</h3>\r\n            <ul>\r\n");
#nullable restore
#line 31 "E:\DotNetCore\MovieStore\MovieStoreMVC\Views\Cast\Details.cshtml"
                  
                    foreach (var movie in Model.Movies)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                            ");
#nullable restore
#line 35 "E:\DotNetCore\MovieStore\MovieStoreMVC\Views\Cast\Details.cshtml"
                       Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </li>\r\n");
#nullable restore
#line 38 "E:\DotNetCore\MovieStore\MovieStoreMVC\Views\Cast\Details.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n    \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationCore.Models.CastDetailsResponseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
