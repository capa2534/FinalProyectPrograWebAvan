#pragma checksum "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c943d04d605063f3dae9921b2d32d829e2e47887"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
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
#line 1 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\_ViewImports.cshtml"
using Examen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\_ViewImports.cshtml"
using Examen.Models.DataModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\_ViewImports.cshtml"
using Examen.Models.DataTransferModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\_ViewImports.cshtml"
using Examen.Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\_ViewImports.cshtml"
using Examen.Models.InputModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\_ViewImports.cshtml"
using Examen.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c943d04d605063f3dae9921b2d32d829e2e47887", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"608961145734fd4859998535ebb6bdfc82707c3f", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    body {
        background: rgb(52,58,64);
        background: linear-gradient(90deg, rgba(52,58,64,1) 0%, rgba(108,117,125,1) 25%, rgba(145,145,145,1) 50%, rgba(108,117,125,1) 75%, rgba(52,58,64,1) 100%);
        /*background: rgb(108,117,125);
                background: radial-gradient(circle, rgba(108,117,125,1) 0%, rgba(52,58,64,1) 80%, rgba(52,58,64,1) 100%);*/
    }

</style>

<div class=""row"">
    <div class=""col-6 offset-3 text-left text-center"">
        <h2 class=""text-dark border-bottom border-dark"" style=""font-size:100px;""><i class=""fa-solid fa-people-line""></i></h2>
    </div>
</div>


<div class=""row"">
    <div class=""col-12 text-lg-right"">
        <a href=""/Cliente/upsert/"" class=""btn btn-primary""><i class=""fa-solid fa-circle-plus""></i> &nbsp; Crear nuevo Cliente</a>
    </div>
</div>


<br />
<div class=""bg-dark p-4 border rounded "">
    <div class=""bg-light p-1"">
        <table id=""Clientes"" class=""table table-striped table-bordered"" style=""width:100%"">");
            WriteLiteral("\r\n            <thead class=\"thead-dark\">\r\n                <tr class=\"text-center\">\r\n                    <th colspan=\"5\">Clientes</th>\r\n                </tr>\r\n            </thead>\r\n\r\n            <tbody");
            BeginWriteAttribute("class", " class=\"", 1246, "\"", 1254, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 38 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Cliente\Index.cshtml"
                 foreach (var Cliente in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("id", " id=\"", 1349, "\"", 1373, 2);
            WriteAttributeValue("", 1354, "Cliente_", 1354, 8, true);
#nullable restore
#line 40 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 1362, Cliente.Id, 1362, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <td>\r\n                            ");
#nullable restore
#line 42 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Cliente\Index.cshtml"
                       Write(Cliente.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 45 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Cliente\Index.cshtml"
                       Write(Cliente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 45 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Cliente\Index.cshtml"
                                       Write(Cliente.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 48 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Cliente\Index.cshtml"
                       Write(Cliente.CorreoElectronico);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 51 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Cliente\Index.cshtml"
                       Write(Cliente.FechaNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 54 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Cliente\Index.cshtml"
                       Write(Cliente.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            <div class=\"text-right\">\r\n\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2070, "\"", 2104, 2);
            WriteAttributeValue("", 2077, "/Cliente/upsert/", 2077, 16, true);
#nullable restore
#line 60 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 2093, Cliente.Id, 2093, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-white\" style=\"cursor:pointer\">\r\n                                    <i class=\"fas fa-edit\"></i>\r\n                                </a>\r\n\r\n                                <a onclick=Delete(\"");
#nullable restore
#line 64 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Cliente\Index.cshtml"
                                              Write(Cliente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""") class=""btn btn-danger text-white"" style=""cursor:pointer"">
                                    <i class=""fas fa-trash-alt""></i>
                                </a>
                            </div>
                        </td>
                    </tr>
");
#nullable restore
#line 70 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Cliente\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>

        </table>
    </div>

    <script>

        function Delete(id) {
            swal({
                title: ""??Esta seguro de eliminar el Cliente?"",
                text: ""??Los datos no podran ser recuperandos una vez se hayan eliminado del sistema, esta seguro que desea eliminarlos completamente?"",
                icon: ""warning"",
                buttons: true,
                dangerMode: true
            }).then((willDelete) => {
                if (willDelete) {
                    $.ajax({
                        type: ""DELETE"",
                        url: ""/Cliente/delete/"" + id,
                        success: function(data) {
                            if (data.success) {
                                toastr.success(data.message);
                                $(""#Cliente_"" + id).remove();
                            }
                            else {
                                toastr.error(data.message);
                            }");
            WriteLiteral("\n                        }\r\n                    });\r\n                }\r\n            });\r\n        }\r\n\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
