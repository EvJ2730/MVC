#pragma checksum "C:\Users\User\OneDrive - UKIM - Faculty Of Natural Sciences And Mathematcs\Desktop\eva\seavus\MVC\G6\Class_08\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e6726024a46777ab43136a4075b4fa0a629e3ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Order), @"mvc.1.0.view", @"/Views/Order/Order.cshtml")]
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
#line 1 "C:\Users\User\OneDrive - UKIM - Faculty Of Natural Sciences And Mathematcs\Desktop\eva\seavus\MVC\G6\Class_08\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive - UKIM - Faculty Of Natural Sciences And Mathematcs\Desktop\eva\seavus\MVC\G6\Class_08\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e6726024a46777ab43136a4075b4fa0a629e3ef", @"/Views/Order/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9df46eeb8e9226be8f48cfc38e77ab42cd37ae40", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Order Pizza</h1>\n");
#nullable restore
#line 4 "C:\Users\User\OneDrive - UKIM - Faculty Of Natural Sciences And Mathematcs\Desktop\eva\seavus\MVC\G6\Class_08\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Order.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\n        <div class=\"col-md-2\">&nbsp;</div>\n        <div class=\"col-md-8\">\n            <div class=\"input-group\">\n                <span class=\"input-group-append\">");
#nullable restore
#line 10 "C:\Users\User\OneDrive - UKIM - Faculty Of Natural Sciences And Mathematcs\Desktop\eva\seavus\MVC\G6\Class_08\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Order.cshtml"
                                            Write(Html.LabelFor(x => x.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                ");
#nullable restore
#line 11 "C:\Users\User\OneDrive - UKIM - Faculty Of Natural Sciences And Mathematcs\Desktop\eva\seavus\MVC\G6\Class_08\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Order.cshtml"
           Write(Html.TextBox("Username", null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"col-md-2\">&nbsp;</div>\n    </div>\n");
#nullable restore
#line 16 "C:\Users\User\OneDrive - UKIM - Faculty Of Natural Sciences And Mathematcs\Desktop\eva\seavus\MVC\G6\Class_08\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Order.cshtml"
     for (int i = 0; i < Model.Pizzas.Count(); i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Pizza no: ");
#nullable restore
#line 18 "C:\Users\User\OneDrive - UKIM - Faculty Of Natural Sciences And Mathematcs\Desktop\eva\seavus\MVC\G6\Class_08\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Order.cshtml"
                  Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n        <div class=\"row\">\n            <div class=\"col-md-6\">\n                <div class=\"input-group input-group-md\">\n                    <span class=\"input-group-addon\">");
#nullable restore
#line 22 "C:\Users\User\OneDrive - UKIM - Faculty Of Natural Sciences And Mathematcs\Desktop\eva\seavus\MVC\G6\Class_08\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Order.cshtml"
                                               Write(Html.Label(expression: $"model.Pizzas[{i}].Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    ");
#nullable restore
#line 23 "C:\Users\User\OneDrive - UKIM - Faculty Of Natural Sciences And Mathematcs\Desktop\eva\seavus\MVC\G6\Class_08\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Order.cshtml"
               Write(Html.TextBox($"Pizzas[{i}].Name", Model.Pizzas[i].Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n            <div class=\"col-md-6\">\n                <div class=\"input-group input-group-md\">\n                    <span class=\"input-group-addon\">");
#nullable restore
#line 28 "C:\Users\User\OneDrive - UKIM - Faculty Of Natural Sciences And Mathematcs\Desktop\eva\seavus\MVC\G6\Class_08\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Order.cshtml"
                                               Write(Html.Label(expression: $"model.Pizzas[{i}].Size"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    ");
#nullable restore
#line 29 "C:\Users\User\OneDrive - UKIM - Faculty Of Natural Sciences And Mathematcs\Desktop\eva\seavus\MVC\G6\Class_08\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Order.cshtml"
               Write(Html.DropDownList($"Pizzas[{i}].Size", Html.GetEnumSelectList(Model.Pizzas[i].Size.GetType()), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 33 "C:\Users\User\OneDrive - UKIM - Faculty Of Natural Sciences And Mathematcs\Desktop\eva\seavus\MVC\G6\Class_08\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Order.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-danger\" type=\"submit\">Order</button>\n");
#nullable restore
#line 35 "C:\Users\User\OneDrive - UKIM - Faculty Of Natural Sciences And Mathematcs\Desktop\eva\seavus\MVC\G6\Class_08\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Order.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
