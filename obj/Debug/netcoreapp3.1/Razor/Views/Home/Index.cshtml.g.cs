#pragma checksum "C:\Users\k2\Desktop\Lessons\TestProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18f21ae688d3f6be143e225133fe9bb513cbfe63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\k2\Desktop\Lessons\TestProject\Views\_ViewImports.cshtml"
using TestProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18f21ae688d3f6be143e225133fe9bb513cbfe63", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad041b5a33a9776883ff8550cfd33c708e92988", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Contact>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal tabular-form margin-top-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\k2\Desktop\Lessons\TestProject\Views\Home\Index.cshtml"
  

    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""col-md-12"">
        <div class=""page-people-directory"">
            <div class=""row"">
                <div class=""col-md-3"">
                    <h5 class=""page-title""><b>Contacts</b></h5>
                    <ul class=""nav nav-pills nav-stacked nav-contacts"">
                        <li class=""active"">
                            <a href=""#"">
                                All Contacts
                                <span class=""badge pull-right"">128+</span>
                            </a>
                        </li>
                        <li>
                            <a href=""#"">
                                My Contacts
                                <span class=""badge pull-right"">87</span>
                            </a>
                        </li>
                        <li>
                            <a href=""#"">
                                Skype Contacts
                                <span class=""badge pull-right"">1");
            WriteLiteral(@"0</span>
                            </a>
                        </li>
                        <li>
                            <a href=""#"">
                                Google Contacts a
                                <span class=""badge pull-right"">65</span>
                            </a>
                        </li>
                    </ul>

                    <br>

                    <h5><b>My Favorites</b></h5>
                    <div class=""list-group people-group"">
                        <a href=""#"" class=""list-group-item"">
                            <div class=""media"">
                                <div class=""pull-left"">
                                    <img class=""img-circle"" src=""https://bootdey.com/img/Content/avatar/avatar1.png"" alt=""..."">
                                </div>
                                <div class=""media-body"">
                                    <h4 class=""media-heading"">John Wayne</h4>
                                    <small>Soft");
            WriteLiteral(@"ware Engineer</small>
                                </div>
                            </div>
                        </a>
                        <a href=""#"" class=""list-group-item"">
                            <div class=""media"">
                                <div class=""pull-left"">
                                    <img class=""img-circle"" src=""https://bootdey.com/img/Content/avatar/avatar2.png"" alt=""..."">
                                </div>
                                <div class=""media-body"">
                                    <h4 class=""media-heading"">Jane Dane</h4>
                                    <small>Software Engineer</small>
                                </div>
                            </div>
                        </a>
                        <a href=""#"" class=""list-group-item"">
                            <div class=""media"">
                                <div class=""pull-left"">
                                    <img class=""img-circle"" src=""https://bootd");
            WriteLiteral(@"ey.com/img/Content/avatar/avatar3.png"" alt=""..."">
                                </div>
                                <div class=""media-body"">
                                    <h4 class=""media-heading"">Juan Dela Cruz</h4>
                                    <small>Software Engineer</small>
                                </div>
                            </div>
                        </a>
                        <a href=""#"" class=""list-group-item"">
                            <div class=""media"">
                                <div class=""pull-left"">
                                    <img class=""img-circle"" src=""https://bootdey.com/img/Content/avatar/avatar4.png"" alt=""..."">
                                </div>
                                <div class=""media-body"">
                                    <h4 class=""media-heading"">Jose Cruz</h4>
                                    <small>Software Engineer</small>
                                </div>
                            </div");
            WriteLiteral(@">
                        </a>
                    </div>

                </div>
                <div class=""col-md-9"">
                    <div class=""well"">
                        <div class=""row"">
                            <div class=""col-md-9"">
                                <input type=""text"" placeholder=""Search people"" class=""form-control"">
                            </div>
                            <div class=""col-md-3"">
                                <div class=""btn-group"" style=""display:block"">
                                    <button data-toggle=""dropdown"" class=""btn btn-default dropdown-toggle"" style=""width: 100%; border-radius: 0px; background: white;  color: gray; border-color: #ddd;"">Last 10 days <span class=""caret""></span></button>
                                    <ul class=""dropdown-menu bullet pull-right animated pulse margin-top-45"">
                                        <li>
                                            <input type=""radio"" id=""ex1_1"" name=""ex1");
            WriteLiteral("\" value=\"1\"");
            BeginWriteAttribute("checked", " checked=\"", 5250, "\"", 5260, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            <label for=""ex1_1"">Fullname</label>
                                        </li>
                                        <li>
                                            <input type=""radio"" id=""ex1_2"" name=""ex1"" value=""2"">
                                            <label for=""ex1_2"">Company</label>
                                        </li>
                                        <li>
                                            <input type=""radio"" id=""ex1_3"" name=""ex1"" value=""3"">
                                            <label for=""ex1_3"">Position</label>
                                        </li>
                                    </ul>
                                </div>

                            </div>
                        </div>
                    </div>
                    <br>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <h3>All Contacts</h3>
     ");
            WriteLiteral(@"                   </div>
                        <div class=""col-md-6"">
                            <button type=""button"" class=""btn btn-green btn-raised btn-add-new-contact""><span class=""icon-plus"" data-toggle=""modal"" data-target=""#modal-pull-right-add""> Add New Contact</span></button>
                        </div>
                    </div>
");
#nullable restore
#line 129 "C:\Users\k2\Desktop\Lessons\TestProject\Views\Home\Index.cshtml"
                     foreach (var user in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"list-group contact-group\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18f21ae688d3f6be143e225133fe9bb513cbfe6313072", async() => {
                WriteLiteral("\r\n                                <div class=\"media\">\r\n                                    <div class=\"pull-left\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "18f21ae688d3f6be143e225133fe9bb513cbfe6313490", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                WriteLiteral("~/images/");
#nullable restore
#line 136 "C:\Users\k2\Desktop\Lessons\TestProject\Views\Home\Index.cshtml"
                                                                  WriteLiteral(user.Avatar);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 136 "C:\Users\k2\Desktop\Lessons\TestProject\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"media-body\">\r\n                                        <h4 class=\"media-heading\">");
#nullable restore
#line 139 "C:\Users\k2\Desktop\Lessons\TestProject\Views\Home\Index.cshtml"
                                                             Write(user.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <small> ");
#nullable restore
#line 139 "C:\Users\k2\Desktop\Lessons\TestProject\Views\Home\Index.cshtml"
                                                                                Write(user.Position);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </small></h4>\r\n                                        <div class=\"media-content\">\r\n                                            <i class=\"fa fa-map-marker\"></i> ");
#nullable restore
#line 141 "C:\Users\k2\Desktop\Lessons\TestProject\Views\Home\Index.cshtml"
                                                                        Write(user.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            <ul class=\"list-unstyled\">\r\n                                                <li><i class=\"fa fa-skype\"></i> ");
#nullable restore
#line 143 "C:\Users\k2\Desktop\Lessons\TestProject\Views\Home\Index.cshtml"
                                                                           Write(user.NickName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                                <li><i class=\"fa fa-mobile\"></i> ");
#nullable restore
#line 144 "C:\Users\k2\Desktop\Lessons\TestProject\Views\Home\Index.cshtml"
                                                                            Write(user.PhoneNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                                <li><i class=\"fa fa-envelope-o\"></i> ");
#nullable restore
#line 145 "C:\Users\k2\Desktop\Lessons\TestProject\Views\Home\Index.cshtml"
                                                                                Write(user.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                            </ul>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 133 "C:\Users\k2\Desktop\Lessons\TestProject\Views\Home\Index.cshtml"
                                 WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 152 "C:\Users\k2\Desktop\Lessons\TestProject\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""pull-right"">
                        <ul class=""pagination pagination-split pagination-sm pagination-contact"">
                            <li class=""disabled""><a href=""#""><i class=""fa fa-angle-left""></i></a></li>
                            <li class=""active""><a href=""#"">1</a></li>
                            <li><a href=""#"">2</a></li>
                            <li><a href=""#"">3</a></li>
                            <li><a href=""#"">4</a></li>
                            <li><a href=""#"">5</a></li>
                            <li><a href=""#""><i class=""fa fa-angle-right""></i></a></li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""modal modal-pull-right"" data-easein=""fadeInRight"" data-easeout=""fadeOutRight"" id=""modal-pull-right-add"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"" style=""display: none;"">
                <div class=""modal-dialog"">
                    <div class=""modal-content");
            WriteLiteral(@" animated fadeOutRight"">
                        <div class=""modal-body"">
                            <div class=""row modal-close"">
                                <div class=""col-md-12 padding-bottom-8 padding-top-8 bg-silver"">
                                    <h4 class=""pull-left""><b>Create New Contact</b></h4>
                                    <ul class=""list-unstyled list-inline text-right"">
                                        <li class=""close-right-modal""><span class=""fa fa-times fa-2x"" data-dismiss=""modal""></span></li>
                                    </ul>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <div class=""contact-add-content"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18f21ae688d3f6be143e225133fe9bb513cbfe6323118", async() => {
                WriteLiteral(@"
                                            <div class=""form-group"">
                                                <label for=""name"" class=""col-sm-2 control-label"">Name</label>
                                                <div class=""col-sm-10 tabular-border"">
                                                    <input type=""text"" class=""form-control"" id=""name"" placeholder=""Full Name"">
                                                </div>
                                            </div>
                                            <div class=""form-group"">
                                                <label for=""email"" class=""col-sm-2 control-label"">Email</label>
                                                <div class=""col-sm-10 tabular-border"">
                                                    <input type=""text"" class=""form-control"" id=""email"" placeholder=""Email"">
                                                </div>
                                            </div>
             ");
                WriteLiteral(@"                               <div class=""form-group"">
                                                <label for=""phone"" class=""col-sm-2 control-label"">Phone</label>
                                                <div class=""col-sm-10 tabular-border"">
                                                    <input type=""text"" class=""form-control"" id=""phone"" placeholder=""Phone"">
                                                </div>
                                            </div>
                                            <div class=""form-group"">
                                                <label for=""address"" class=""col-sm-2 control-label"">Address</label>
                                                <div class=""col-sm-10 tabular-border"">
                                                    <input type=""text"" class=""form-control"" id=""address"" placeholder=""Address"">
                                                </div>
                                            </div>
                     ");
                WriteLiteral(@"                       <div class=""form-actions"">
                                                <button type=""button"" class=""btn btn-silver btn-flat"">Cancel</button> <button type=""button"" class=""btn btn-green btn-flat"">Save Changes</button>
                                            </div>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
