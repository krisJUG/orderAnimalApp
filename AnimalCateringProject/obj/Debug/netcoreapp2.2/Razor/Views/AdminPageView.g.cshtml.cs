#pragma checksum "C:\Users\KrisJ\Desktop\Kris\UG\sem4\ProgramApliRozprCSharp\AnimalCateringProject - Copy\AnimalCateringProject\Views\AdminPageView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7785a98229fc6148df093c0f5732d689d9981160"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPageView), @"mvc.1.0.view", @"/Views/AdminPageView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminPageView.cshtml", typeof(AspNetCore.Views_AdminPageView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7785a98229fc6148df093c0f5732d689d9981160", @"/Views/AdminPageView.cshtml")]
    public class Views_AdminPageView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\KrisJ\Desktop\Kris\UG\sem4\ProgramApliRozprCSharp\AnimalCateringProject - Copy\AnimalCateringProject\Views\AdminPageView.cshtml"
  
    ViewData["Title"] = "AdminPage";

#line default
#line hidden
            BeginContext(45, 32, true);
            WriteLiteral("\r\n<h1>AdminPage</h1>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(77, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7785a98229fc6148df093c0f5732d689d99811603633", async() => {
                BeginContext(83, 152, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title></title>\r\n\r\n    <style>\r\n\r\n        #hideThisItem {\r\n            display: none;\r\n        }\r\n\r\n    </style>\r\n\r\n");
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
            BeginContext(242, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(244, 6576, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7785a98229fc6148df093c0f5732d689d99811604990", async() => {
                BeginContext(355, 6458, true);
                WriteLiteral(@"
    <div>
        <h1 style=""text-align: center; height: 12%;""><strong>Animal Add Edit</strong></h1>
        <h3>Add</h3>
        <form action=""javascript:void(0);"" method=""POST"" onsubmit=""addDish()"">
            <input type=""text"" id=""add-name"" placeholder=""New dish"">
            <input type=""text"" id=""add-desc"" placeholder=""desc"">
            <input type=""submit"" value=""Add"">
        </form>

        <div id=""hideThisItem"">
            <h3>Edit</h3>
            <form class=""my-form"">
                <input type=""hidden"" id=""edit-id"">
                <input type=""checkbox"" id=""edit-isComplete"">
                <input type=""text"" id=""edit-name"">
                <input type=""text"" id=""edit-desc"">
                <input type=""submit"" value=""Save"">
                <a onclick=""closeInput()"" aria-label=""Close"">&#10006;</a>
            </form>
        </div>

        <div>
            <div id=""menu"" style=""width: 100%;"">
                <table>
                    <tr>
                   ");
                WriteLiteral(@"     <th style=""width:10%; text-align: left;"">isComplete</th>
                        <th style=""width:25%; text-align: left;"">Name</th>
                        <th style=""width:45%; text-align: center;"">Description</th>
                        <th style=""width:10%; text-align: right;"">Edit</th>
                        <th style=""width:10%; text-align: right;"">Delete</th>
                    </tr>
                    <tbody id=""getAllDish""></tbody>
                </table>
            </div>
        </div>
    </div>

    <script src=""https://code.jquery.com/jquery-3.3.1.min.js""
            integrity=""sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8=""
            crossorigin=""anonymous""></script>
    <script>
        const uri = ""https://localhost:44344/pages/adminpage/"";
        let getAllDish = null;
        function getCount(data) {
            const el = $(""#counter"");
            let name = ""dish-do"";
            if (data) {
                if (data > 1) {
                    nam");
                WriteLiteral(@"e = ""to-dish"";
                }
                el.text(data + "" "" + name);
            } else {
                el.text(""No "" + name);
            }
        }

        $(document).ready(function () {
            getDish();
        });

        function getDish() {
            $.ajax({
                type: ""GET"",
                url: uri,
                cache: false,
                success: function (data) {
                    const tBody = $(""#getAllDish"");

                    $(tBody).empty();

                    getCount(data.length);

                    $.each(data, function (key, item) {
                        const tr = $(""<tr></tr>"")
                            .append(
                                $(""<td></td>"").append(
                                    $(""<input/>"", {
                                        type: ""checkbox"",
                                        disabled: true,
                                        checked: item.vege
                 ");
                WriteLiteral(@"                   })
                                )
                            )
                            .append($(""<td></td>"").text(item.name))
                            .append($(""<td></td>"").text(item.desc))
                            .append(
                                $(""<td></td>"").append(
                                        $(""<button>Edit</button>"").on(""click"", function () {
                                        editDish(item.id);
                                    })
                                )
                            )
                            .append(
                                $(""<td></td>"").append(
                                    $(""<button>Delete</button>"").on(""click"", function () {
                                        deleteDish(item.id);
                                    })
                                )
                            );

                        tr.appendTo(tBody);
                    });

              ");
                WriteLiteral(@"      getAllDish = data;
                }
            });
        }

        function addDish() {
            const item = {
                name: $(""#add-name"").val(),
                desc: $(""#add-desc"").val(),
                isComplete: false
            };

            $.ajax({
                type: ""POST"",
                accepts: ""application/json"",
                url: uri,
                contentType: ""application/json"",
                data: JSON.stringify(item),
                error: function (jqXHR, textStatus, errorThrown) {
                    alert(""Something went wrong!"");
                },
                success: function (result) {
                    getDish();
                    $(""#add-name"").val("""");
                }
            });
        }

        function deleteDish(id) {
            $.ajax({
                url: uri + id,
                type: ""DELETE"",
                success: function (result) {
                    getDish();
              ");
                WriteLiteral(@"  }
            });
        }

        function editDish(id) {
            $.each(getAllDish, function (key, item) {
                if (item.id === id) {
                    $(""#edit-name"").val(item.name);
                    $(""#edit-id"").val(item.id);
                    $(""#edit-desc"").val(item.desc);
                    $(""#edit-isComplete"")[0].checked = item.isComplete;
                }
            });
            $(""#hideThisItem"").css({ display: ""block"" });
        }

        $("".my-form"").on(""submit"", function () {
            const item = {
                name: $(""#edit-name"").val(),
                desc: $(""#edit-desc"").val(),
                isComplete: $(""#edit-isComplete"").is("":checked""),
                id: $(""#edit-id"").val()
            };

            $.ajax({
                url: uri + $(""#edit-id"").val(),
                type: ""PUT"",
                accepts: ""application/json"",
                contentType: ""application/json"",
                data: JSON.string");
                WriteLiteral(@"ify(item),
                success: function (result) {
                    getDish();
                }
            });

            closeInput();
            return false;
        });

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
            BeginContext(6820, 9, true);
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
