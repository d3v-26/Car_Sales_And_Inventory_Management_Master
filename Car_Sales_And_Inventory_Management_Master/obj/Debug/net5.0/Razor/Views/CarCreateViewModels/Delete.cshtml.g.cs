#pragma checksum "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59b9b07a1dbcfcf47f7d08b3bd445ffea9da3271"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarCreateViewModels_Delete), @"mvc.1.0.view", @"/Views/CarCreateViewModels/Delete.cshtml")]
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
#line 1 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\_ViewImports.cshtml"
using Car_Sales_And_Inventory_Management_Master;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\_ViewImports.cshtml"
using Car_Sales_And_Inventory_Management_Master.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59b9b07a1dbcfcf47f7d08b3bd445ffea9da3271", @"/Views/CarCreateViewModels/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aea00180eb1e24436386e937dfaf170ce35ce6a", @"/Views/_ViewImports.cshtml")]
    public class Views_CarCreateViewModels_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car_Sales_And_Inventory_Management_Master.ViewModel.CarCreateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>CarCreateViewModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.car_model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.car_model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.launch_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.launch_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.no_of_images));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.no_of_images));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.specification_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.specification_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.average));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.average));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.max_speed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.max_speed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.dimensionsId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.dimensionsId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.no_of_seats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.no_of_seats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.free_space));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.free_space));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.airbags));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.airbags));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.fuel_Consumption_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.fuel_Consumption_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.additional_description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.additional_description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.engine_model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.engine_model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.performance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.performance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.efficiency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.efficiency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59b9b07a1dbcfcf47f7d08b3bd445ffea9da327119956", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "59b9b07a1dbcfcf47f7d08b3bd445ffea9da327120223", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 131 "G:\Hardik\Sem 6\SDP\Car_Sales_And_Inventory_Management_Master\Car_Sales_And_Inventory_Management_Master\Views\CarCreateViewModels\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.car_id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59b9b07a1dbcfcf47f7d08b3bd445ffea9da327122079", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car_Sales_And_Inventory_Management_Master.ViewModel.CarCreateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
