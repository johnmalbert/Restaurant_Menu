#pragma checksum "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Crudelicious\Views\Home\DishNumber.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d291197ab4c756c2acb88e58b0c2df96c67b3009"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DishNumber), @"mvc.1.0.view", @"/Views/Home/DishNumber.cshtml")]
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
#line 1 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Crudelicious\Views\_ViewImports.cshtml"
using Crudelicious;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Crudelicious\Views\_ViewImports.cshtml"
using Crudelicious.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d291197ab4c756c2acb88e58b0c2df96c67b3009", @"/Views/Home/DishNumber.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64c0db40c4c91a29aacfb134c187d6cf7f912d39", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DishNumber : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Crudelicious\Views\Home\DishNumber.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n<style>\r\n    .checked {\r\n        color: orange;\r\n    }\r\n</style>\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 11 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Crudelicious\Views\Home\DishNumber.cshtml"
                     Write(ViewBag.CurrentDish.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1 class=\"display-8 border-top\">");
#nullable restore
#line 12 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Crudelicious\Views\Home\DishNumber.cshtml"
                                Write(ViewBag.CurrentDish.Chef);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"container text-center p-5 border mb-3\">\r\n        <h1 class=\"display-5\">");
#nullable restore
#line 14 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Crudelicious\Views\Home\DishNumber.cshtml"
                         Write(ViewBag.CurrentDish.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <div class=\"row text-left mt-5\">\r\n            <div class=\"col\">\r\n                <h1 class=\"display-5\"><strong>Tastiness:</h1>\r\n");
#nullable restore
#line 18 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Crudelicious\Views\Home\DishNumber.cshtml"
                 for (int i = 0; i < @ViewBag.CurrentDish.Tastiness; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"fa fa-star fa-5x checked\"></span>\r\n");
#nullable restore
#line 21 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Crudelicious\Views\Home\DishNumber.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col text-left\">\r\n                <h1 class=\"display-5\"><strong>Calories: </strong>");
#nullable restore
#line 24 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Crudelicious\Views\Home\DishNumber.cshtml"
                                                            Write(ViewBag.CurrentDish.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1097, "\"", 1138, 2);
#nullable restore
#line 30 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Crudelicious\Views\Home\DishNumber.cshtml"
WriteAttributeValue("", 1104, ViewBag.CurrentDish.DishId, 1104, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1131, "/Delete", 1131, 7, true);
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-primary\">Delete</button></a>\r\n        </div>\r\n        <div class=\"col\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1250, "\"", 1291, 2);
#nullable restore
#line 33 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Crudelicious\Views\Home\DishNumber.cshtml"
WriteAttributeValue("", 1257, ViewBag.CurrentDish.DishId, 1257, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1284, "/update", 1284, 7, true);
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-primary\">Edit</button></a>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"container\">\r\n    <span id=\"rateMe4\" class=\"feedback\"></span>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
