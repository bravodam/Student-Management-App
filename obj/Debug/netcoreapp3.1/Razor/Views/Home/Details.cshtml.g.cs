#pragma checksum "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfe656bc3b543d625aa191ddcb5c36a03f226529"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\victo\source\repos\Code360NEWWEB\Views\_ViewImports.cshtml"
using Code360NEWWEB.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\victo\source\repos\Code360NEWWEB\Views\_ViewImports.cshtml"
using Code360NEWWEB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\victo\source\repos\Code360NEWWEB\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfe656bc3b543d625aa191ddcb5c36a03f226529", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e47966be6b8a75968e47330b9be8c591e021a0e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "\r\n                           account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
  

    ViewBag.Title = "Student Details";
    var PhotoPath = "~/images/" + (Model.StudentClass.PhotoPath ?? "employee.png");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<header id=""header"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-10"">
                <h1><i class=""fa fa-cog""></i> Dashboard <small>Manage Your Student</small></h1>
            </div>
            <div class=""col-md-2"">
                <div class=""dropdown create"">
                    <button class=""btn btn-default dropdown-toggle"" type=""button"" id=""dropdownMenu1"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""true"">
                        Create New
                        <span class=""caret""></span>
                    </button>
                    <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenu1"">
                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfe656bc3b543d625aa191ddcb5c36a03f2265297872", async() => {
                WriteLiteral("Add New Student");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                        <li><a href=""#"">Search Student</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</header>




<section id=""breadcrumb"">
    <div class=""container"">
        <ol class=""breadcrumb"">
            <li class=""active"">Dashboard</li>
        </ol>
    </div>
</section>

<section id=""main"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-3"">
                <div class=""list-group"">
                    <a href=""index.html"" class=""list-group-item active main-color-bg"">
                        <span class=""glyphicon glyphicon-cog"" aria-hidden=""true""></span> DashBoard
                    </a>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfe656bc3b543d625aa191ddcb5c36a03f22652910023", async() => {
                WriteLiteral("<span class=\"glyphicon glyphicon-user\" aria-hidden=\"true\"></span> Students <span class=\"badge\">");
#nullable restore
#line 54 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
                                                                                                                                                                                  Write(_student.GetAllStudents().Count());

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfe656bc3b543d625aa191ddcb5c36a03f22652911995", async() => {
                WriteLiteral("<span class=\"glyphicon glyphicon-pencil\" aria-hidden=\"true\"></span> Register <span class=\"badge\">33</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <a href=""users.html"" class=""list-group-item""> <span class=""glyphicon glyphicon-user"" aria-hidden=""true""></span> Users <span class=""badge"">203</span></a>
                </div>
                <div class=""well"">
                    <h4>Disk Space Used</h4>
                    <div class=""progress"">
                        <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 60%;"">
                            60%
                        </div>
                    </div>
                    <h4>BanthWidth USed</h4>
                    <div class=""progress"">
                        <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 40%;"">
                            40%
                        </div>
                    </div>
                </div>
            </div>


            <div class=""col-md-9"">
                <div class=""row justify-co");
            WriteLiteral("ntent-center m3\">\r\n                    <div class=\"col-sm-8\">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-header\">\r\n                                <h1 class=\"text-center\">");
#nullable restore
#line 81 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
                                                   Write(Model.StudentClass.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            </div>\r\n\r\n                            <div class=\"card-body text-center\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cfe656bc3b543d625aa191ddcb5c36a03f22652915292", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
                                                   WriteLiteral(PhotoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 85 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
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
            WriteLiteral("\r\n\r\n                                <h5>Employee ID : ");
#nullable restore
#line 87 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
                                             Write(Model.StudentClass.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <h5>Email  : ");
#nullable restore
#line 88 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
                                        Write(Model.StudentClass.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <h5>Gender : ");
#nullable restore
#line 89 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
                                        Write(Model.StudentClass.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <h5>DOB: ");
#nullable restore
#line 90 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
                                    Write(Model.StudentClass.DOB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <h5>NextOfKinName: ");
#nullable restore
#line 91 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
                                              Write(Model.StudentClass.NextOfKinName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <h5>NextOfKinPhone: ");
#nullable restore
#line 92 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
                                               Write(Model.StudentClass.NextOfKinPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <h5>NextOfKinAddress: ");
#nullable restore
#line 93 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
                                                 Write(Model.StudentClass.NextOfKinAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <h5>Address  : ");
#nullable restore
#line 94 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
                                          Write(Model.StudentClass.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <h5>Identification : ");
#nullable restore
#line 95 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
                                                Write(Model.StudentClass.Identification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <h5>Nationality : ");
#nullable restore
#line 96 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
                                             Write(Model.StudentClass.Nationality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <h5>Phone  : ");
#nullable restore
#line 97 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
                                        Write(Model.StudentClass.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <h5>Health COndition : ");
#nullable restore
#line 98 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
                                                  Write(Model.StudentClass.HealthCondition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <h5>Marital Status  : ");
#nullable restore
#line 99 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
                                                 Write(Model.StudentClass.Marital);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                                <h5>Student Status : ");
#nullable restore
#line 101 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
                                                Write(Model.StudentClass.StudentStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <h5> Admission: ");
#nullable restore
#line 102 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
                                           Write(Model.StudentClass.AdmissionType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                            </div>\r\n                            <div class=\"card-footer text-center\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfe656bc3b543d625aa191ddcb5c36a03f22652922384", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfe656bc3b543d625aa191ddcb5c36a03f22652923859", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\victo\source\repos\Code360NEWWEB\Views\Home\Details.cshtml"
                                     WriteLiteral(Model.StudentClass.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <a href=""#"" class=""btn btn-danger"" >Delete</a>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>
    </div>
    </section>







            
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfe656bc3b543d625aa191ddcb5c36a03f22652926706", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStudent _student { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591