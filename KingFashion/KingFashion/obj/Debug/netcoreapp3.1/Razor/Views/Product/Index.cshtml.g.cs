#pragma checksum "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e94594d27906661de57e71737b28ebafbe7fd94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\_ViewImports.cshtml"
using KingFashion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\_ViewImports.cshtml"
using KingFashion.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\_ViewImports.cshtml"
using KingFashion.Models.Categorys;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\_ViewImports.cshtml"
using KingFashion.Models.CategoryDetail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\_ViewImports.cshtml"
using KingFashion.Models.Products;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e94594d27906661de57e71737b28ebafbe7fd94", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d49ec4426de693030868cba3cb14c2a272a47a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/product.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<p>
    <a href=""javascript:;"" class=""btn btn-out-dashed btn-success btn-square"" onclick=""product.openModel()""><i class=""ti-plus""></i>Thêm Mới</a>
</p>
<div class=""card-block table-border-style"">
    <div class=""table-responsive"">
        <table class=""table table-hover"" id=""tbProduct"">
            <thead style=""background: black;color:white"">
                <tr>
                    <th>
                        #
                    </th>
                    <th>
                        Sản Phẩm
                    </th>
                    <th>
                        Sự Mô Tả
                    </th>
                    <th>
                        Màu
                    </th>
                    <th>
                        Size
                    </th>
                    <th>
                        Trạng Thái
                    </th>
                    <th>
                        Bị Xóa
                    </th>
                    <th>
                        Số L");
            WriteLiteral(@"ượng
                    </th>
                    <th>
                        Ảnh
                    </th>
                    <th>
                        Giá
                    </th>
                    <th>
                        Mã Sản Phẩm
                    </th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 52 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
                 foreach (var pro in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 55 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
                       Write(pro.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 56 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
                       Write(pro.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 57 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
                       Write(pro.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 58 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
                       Write(pro.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 59 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
                       Write(pro.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 61 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
                             if (pro.Status)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"javascript:;\" class=\"btn btn-warning btn-sm\" style=\"background-color:#33d176; border-color:#33d176\"\r\n                                   title=\"Sẵn Có\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2108, "\"", 2188, 5);
            WriteAttributeValue("", 2118, "product.changeStatus(", 2118, 21, true);
#nullable restore
#line 64 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
WriteAttributeValue("", 2139, pro.ProductId, 2139, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2153, ",", 2153, 1, true);
#nullable restore
#line 64 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
WriteAttributeValue(" ", 2154, pro.Status.ToString().ToLower(), 2155, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2187, ")", 2187, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    Sẵn Có\r\n                                </a>\r\n");
#nullable restore
#line 67 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"javascript:;\" class=\"btn btn-warning btn-sm\"\r\n                                   title=\"Hết Hàng\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2510, "\"", 2590, 5);
            WriteAttributeValue("", 2520, "product.changeStatus(", 2520, 21, true);
#nullable restore
#line 72 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
WriteAttributeValue("", 2541, pro.ProductId, 2541, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2555, ",", 2555, 1, true);
#nullable restore
#line 72 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
WriteAttributeValue(" ", 2556, pro.Status.ToString().ToLower(), 2557, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2589, ")", 2589, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    Hết Hàng\r\n                                </a>\r\n");
#nullable restore
#line 75 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 78 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
                             if (pro.IsDeleted)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"javascript:;\" class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", "\r\n                                   onclick=\"", 2934, "\"", 3056, 5);
            WriteAttributeValue("", 2980, "product.changeIsDeleted(", 2980, 24, true);
#nullable restore
#line 81 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
WriteAttributeValue("", 3004, pro.ProductId, 3004, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3018, ",", 3018, 1, true);
#nullable restore
#line 81 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
WriteAttributeValue(" ", 3019, pro.IsDeleted.ToString().ToLower(), 3020, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3055, ")", 3055, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    Đã Xóa\r\n                                </a>\r\n");
#nullable restore
#line 84 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"javascript:;\" class=\"btn btn-warning btn-sm\" style=\"background-color:#33d176; border-color:#33d176\"");
            BeginWriteAttribute("onclick", "\r\n                                   onclick=\"", 3380, "\"", 3502, 5);
            WriteAttributeValue("", 3426, "product.changeIsDeleted(", 3426, 24, true);
#nullable restore
#line 89 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
WriteAttributeValue("", 3450, pro.ProductId, 3450, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3464, ",", 3464, 1, true);
#nullable restore
#line 89 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
WriteAttributeValue(" ", 3465, pro.IsDeleted.ToString().ToLower(), 3466, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3501, ")", 3501, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    Hoạt Động\r\n                                </a>\r\n");
#nullable restore
#line 92 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>");
#nullable restore
#line 94 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
                       Write(pro.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 95 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
                       Write(pro.Photo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 96 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
                       Write(pro.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 97 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
                       Write(pro.ProductCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a href=\"javascript:;\" class=\"btn btn-secondary\" title=\"Sửa\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3960, "\"", 3997, 3);
            WriteAttributeValue("", 3970, "product.get(", 3970, 12, true);
#nullable restore
#line 99 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
WriteAttributeValue("", 3982, pro.ProductId, 3982, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3996, ")", 3996, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"ti-pencil\"></i>\r\n                            </a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 104 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>
<div class=""modal fade"" id=""productModel"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Sản Phẩm</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e94594d27906661de57e71737b28ebafbe7fd9417544", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label>Sản Phẩm</label>
                        <input type=""text"" name=""ProductName"" class=""form-control"" data-rule-required=""true"" />
                        <input type=""hidden"" name=""ProductId"" value=""0"" />
                        <input type=""hidden"" name=""CatDetailsId""");
                BeginWriteAttribute("value", " value=\"", 5189, "\"", 5218, 1);
#nullable restore
#line 124 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
WriteAttributeValue("", 5197, ViewBag.CatDetailsId, 5197, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                    <div class=""form-group"">
                        <label>Sự Mô Tả</label>
                        <input type=""text"" name=""Description"" class=""form-control"" data-rule-required=""true"" />
                    </div>
                    <div class=""form-group"">
                        <label>Màu</label>
                        <input type=""text"" name=""Color"" class=""form-control"" data-rule-required=""true"" />
");
                WriteLiteral("                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Size</label>\r\n                        <input type=\"text\" name=\"Size\" class=\"form-control\" data-rule-required=\"true\" />\r\n");
                WriteLiteral(@"                    </div>
                    <div class=""form-check"">
                        <label class=""form-check-label"">
                            <input type=""checkbox"" class=""form-check-input"" name=""Status"">  Trạng thái
                        </label>
                    </div>
                    <div class=""form-group"">
                        <label>Số Lượng</label>
                        <input type=""text"" name=""Quantity"" class=""form-control"" data-rule-required=""true"" />
                    </div>
                    <div class=""form-group"">
                        <label>Ảnh</label>
                        <input type=""text"" name=""Photo"" class=""form-control"" data-rule-required=""true"" />
                    </div>
                    <div class=""form-group"">
                        <label>Giá</label>
                        <input type=""text"" name=""Price"" class=""form-control"" data-rule-required=""true"" />
                    </div>
                    <div class=""form-group""");
                WriteLiteral(">\r\n                        <label>Mã Sản Phẩm</label>\r\n                        <input type=\"text\" name=\"ProductCode\" class=\"form-control\" data-rule-required=\"true\" />\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">
                    <i class=""fa fa-times""></i>
                    Trở Lại
                </button>
                <button type=""button"" class=""btn btn-primary"" onclick=""product.save()"">
                    <i class=""fa fa-save""></i>
                    Lưu
                </button>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e94594d27906661de57e71737b28ebafbe7fd9422373", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 186 "C:\Users\ADMIN\Desktop\Project\KingFashionShop\KingFashion\KingFashion\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
