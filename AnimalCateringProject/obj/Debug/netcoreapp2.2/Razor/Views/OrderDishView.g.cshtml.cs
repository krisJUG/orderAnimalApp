#pragma checksum "C:\Users\KrisJ\Desktop\Kris\UG\sem4\ProgramApliRozprCSharp\AnimalCateringProject - Copy\AnimalCateringProject\Views\OrderDishView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f02ba7a808c5567b5baa1ede1812aa5e6916802"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderDishView), @"mvc.1.0.view", @"/Views/OrderDishView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrderDishView.cshtml", typeof(AspNetCore.Views_OrderDishView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f02ba7a808c5567b5baa1ede1812aa5e6916802", @"/Views/OrderDishView.cshtml")]
    public class Views_OrderDishView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align: center; max-width: 70%; max-height: 50%; min-height: 600px; border: 1px solid black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "C:\Users\KrisJ\Desktop\Kris\UG\sem4\ProgramApliRozprCSharp\AnimalCateringProject - Copy\AnimalCateringProject\Views\OrderDishView.cshtml"
  
    ViewData["Title"] = "Order Page";

#line default
#line hidden
            BeginContext(46, 32, true);
            WriteLiteral("\r\n<h1>AdminPage</h1>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(78, 163, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f02ba7a808c5567b5baa1ede1812aa5e69168023634", async() => {
                BeginContext(84, 150, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title></title>\r\n\r\n    <style>\r\n\r\n        #hideThisItem {\r\n            display: none;\r\n        }\r\n    </style>\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(241, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(243, 5169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f02ba7a808c5567b5baa1ede1812aa5e69168024987", async() => {
                BeginContext(354, 5051, true);
                WriteLiteral(@"
    <div>
        <div id=""selectDish"" style=""width: 100%;"">
            <table>
                <tr>
                    <th style=""width:10%; text-align: left;"">isComplete</th>
                    <th style=""width:25%; text-align: left;"">Name</th>
                    <th style=""width:45%; text-align: center;"">Description</th>
                    <th style=""width:10%; text-align: right;"">Order</th>
                </tr>
                <tbody id=""getAllDish""></tbody>
            </table>
        </div>
        <div id=""selectedOrder"" style=""width: 100%; position: relative;"">
            <table>
                <tr>
                    <th style=""width:10%; text-align: left;"">isComplete</th>
                    <th style=""width:25%; text-align: left;"">Name</th>
                    <th style=""width:45%; text-align: center;"">Description</th>
                </tr>
                <tbody id=""getAllOrdered""></tbody>
            </table>
        </div>
    </div>

    <script src=""https://");
                WriteLiteral(@"code.jquery.com/jquery-3.3.1.min.js""
            integrity=""sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8=""
            crossorigin=""anonymous""></script>
    <script>
        const uriAll = ""https://localhost:44344/pages/orderpagealldish/"";
        const uriOrdered = ""https://localhost:44344/pages/orderpageordered/"";
        let getAllDish = null;
        let getAllOrdered = null;

        function getCount(data) {
            const el = $(""#counter"");
            let name = ""dish-do"";
            if (data) {
                if (data > 1) {
                    name = ""to-dish"";
                }
                el.text(data + "" "" + name);
            } else {
                el.text(""No "" + name);
            }
        }

        $(document).ready(function () {
            getAllDishes();
            getOrderedDishes();
        });

        function getAllDishes() {
            $.ajax({
                type: ""GET"",
                url: uriAll,
                cache: false,
                WriteLiteral(@"
                success: function (data) {

                    const allDishesConst = $(""#getAllDish"");
                    $(allDishesConst).empty();
                    getCount(data.length);

                    $.each(data, function (key, item) {
                        const tr = $(""<tr></tr>"")
                            .append(
                                $(""<td></td>"").append(
                                    $(""<input/>"", {
                                        type: ""checkbox"",
                                        disabled: true,
                                        checked: item.vege
                                    })
                                )
                            )
                            .append($(""<td></td>"").text(item.name))
                            .append($(""<td></td>"").text(item.desc))
                            .append(
                                $(""<td></td>"").append(
                                    $(""<button>Order");
                WriteLiteral(@"</button>"").on(""click"", function () {
                                        orderDish(item.id);
                                    })
                                )
                            );

                        tr.appendTo(allDishesConst);
                    });

                    getAllDish = data;
                }
            });
        }

        function getOrderedDishes() {
            $.ajax({
                type: ""GET"",
                url: uriOrdered,
                cache: false,
                success: function (data) {

                    const orderedDishes = $(""#getAllOrdered"");
                    $(orderedDishes).empty();
                    getCount(data.length);

                    $.each(data, function (key, item) {
                        const tr = $(""<tr></tr>"")
                            .append(
                                $(""<td></td>"").append(
                                    $(""<input/>"", {
                               ");
                WriteLiteral(@"         type: ""checkbox"",
                                        disabled: true,
                                        checked: item.dish.vege
                                    })
                                )
                            )
                            .append($(""<td></td>"").text(item.dish.name))
                            .append($(""<td></td>"").text(item.dish.desc))

                        tr.appendTo(orderedDishes);
                    });

                    getAllOrdered = data;
                }
            });
        }

        function orderDish(id) {
            $.ajax({
                url: uriAll + id,
                type: ""DELETE"",
                success: function (result) {
                    getOrderedDishes();
                }
            });
        }

        function closeInput() {
            $(""#hideThisItem"").css({ display: ""none"" });
        }
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5412, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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