#pragma checksum "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\Empresa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1203f4aa962a67773da6d23e2d62b6dd09dd7a4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empresa_Index), @"mvc.1.0.view", @"/Views/Empresa/Index.cshtml")]
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
#line 1 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\_ViewImports.cshtml"
using FrontEndAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\_ViewImports.cshtml"
using FrontEndAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1203f4aa962a67773da6d23e2d62b6dd09dd7a4c", @"/Views/Empresa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fee25c8c16d87d879587c5a863019dfa4cea0dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Empresa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FrontEndAPI.Models.EmpresaViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("small text-black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\Empresa\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""layoutSidenav_content"">
    <main>
        <div class=""card-header""><h3 class=""text-center font-weight-light my-4"">Empresas</h3></div>

        <div class=""row"">
            <div class=""col-xl-12"">
                <div class=""card mb-4"">
                </div>
            </div>
        </div>
        <div class=""card mb-4"">
            <div class=""card-header"">
                <i class=""fas fa-table mr-1""></i>
                Mediciones Registradas
            </div>
            <div class=""card-body"">
                <p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1203f4aa962a67773da6d23e2d62b6dd09dd7a4c4662", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </p>
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>
                                    ");
#nullable restore
#line 30 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\Empresa\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.EmpresaID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 33 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\Empresa\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 36 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\Empresa\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.NombreEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 39 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\Empresa\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 42 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\Empresa\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 45 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\Empresa\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.CedulaJuridica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\Empresa\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 55 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\Empresa\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.EmpresaID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 58 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\Empresa\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 61 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\Empresa\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.NombreEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 64 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\Empresa\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 67 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\Empresa\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 70 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\Empresa\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CedulaJuridica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 73 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\Empresa\Index.cshtml"
                                   Write(Html.ActionLink("Edit", "Edit", new { id = item.EmpresaID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                                        ");
#nullable restore
#line 74 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\Empresa\Index.cshtml"
                                   Write(Html.ActionLink("Details", "Details", new { id = item.EmpresaID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                                        ");
#nullable restore
#line 75 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\Empresa\Index.cshtml"
                                   Write(Html.ActionLink("Delete", "Delete", new { id = item.EmpresaID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 78 "C:\Users\casti\Source\Repos\kennethsgue\ProyectoNetCore2\FrontEndAPI\Views\Empresa\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </main>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FrontEndAPI.Models.EmpresaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
