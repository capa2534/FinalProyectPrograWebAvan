#pragma checksum "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Ventas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34eef87736602bc507b09e8fd76fb0ea82055ea7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ventas_Index), @"mvc.1.0.view", @"/Views/Ventas/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34eef87736602bc507b09e8fd76fb0ea82055ea7", @"/Views/Ventas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"608961145734fd4859998535ebb6bdfc82707c3f", @"/Views/_ViewImports.cshtml")]
    public class Views_Ventas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ventas>>
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
        <h2 class=""text-dark border-bottom border-dark"" style=""font-size:100px;""><i class=""fa-solid fa-cars""></i></h2>
    </div>
</div>


<div class=""row"">
	<div class=""col-12 text-lg-right"">
		<a href=""/Ventas/upsert/"" class=""btn btn-dark""><i class=""fa-solid fa-circle-plus""></i> &nbsp; Crear una nueva Venta</a>
		
	</div>
</div>


<br />

<div class=""bg-dark p-4 border rounded "">
	<div class=""bg-light p-1"">
		<table id=""Empleados"" class=""table table-hover table-striped container"">
			<thead class=""thead-dark"">
				<tr class=""text-center"">
					<th");
            WriteLiteral(" colspan=\"8\">Ventas</th>\r\n\t\t\t\t</tr>\r\n\t\t\t</thead>\r\n\t\t\t<tbody");
            BeginWriteAttribute("class", " class=\"", 1104, "\"", 1112, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 40 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Ventas\Index.cshtml"
                 foreach (var Ventas in Model)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("id", " id=\"", 1178, "\"", 1200, 2);
            WriteAttributeValue("", 1183, "Ventas_", 1183, 7, true);
#nullable restore
#line 42 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Ventas\Index.cshtml"
WriteAttributeValue("", 1190, Ventas.Id, 1190, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Ventas\Index.cshtml"
                   Write(Ventas.Id_Cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Ventas\Index.cshtml"
                   Write(Ventas.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Ventas\Index.cshtml"
                   Write(Ventas.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Ventas\Index.cshtml"
                   Write(Ventas.Id_Auto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                   \r\n                    <td>\r\n                        ");
#nullable restore
#line 57 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Ventas\Index.cshtml"
                   Write(Ventas.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 60 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Ventas\Index.cshtml"
                   Write(Ventas.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 63 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Ventas\Index.cshtml"
                   Write(Ventas.Annio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 66 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Ventas\Index.cshtml"
                   Write(Ventas.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div class=\"text-right\">\r\n\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2080, "\"", 2112, 2);
            WriteAttributeValue("", 2087, "/Ventas/upsert/", 2087, 15, true);
#nullable restore
#line 71 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Ventas\Index.cshtml"
WriteAttributeValue("", 2102, Ventas.Id, 2102, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning text-white\" style=\"cursor:pointer\">\r\n                                <i class=\"fas fa-edit\"></i>\r\n                            </a>\r\n\r\n                            <a onclick=Delete(\"");
#nullable restore
#line 75 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Ventas\Index.cshtml"
                                          Write(Ventas.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\") class=\"btn btn-danger text-white\" style=\"cursor:pointer\">\r\n                                <i class=\"fas fa-trash-alt\"></i>\r\n                            </a>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 81 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Ventas\Index.cshtml"

				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</tbody>\r\n");
            WriteLiteral(@"		</table>

	</div>
</div>


<script>

	function Delete(id) {
		swal({
			title: ""??Esta seguro de eliminar el Auto?"",
			text: ""??Los datos no podran ser recuperandos una vez se hayan eliminado del sistema, esta seguro que desea eliminarlos completamente?"",
			icon: ""warning"",
			buttons: true,
			dangerMode: true
		}).then((willDelete) => {
			if (willDelete) {
				$.ajax({
					type: ""DELETE"",
					url: ""/Ventas/delete/"" + id,
					success: function(data) {
						if (data.success) {
							toastr.success(data.message);
							$(""#Ventas_"" + id).remove();
						}
						else {
							toastr.error(data.message);
						}
					}
				});
			}
		});
	}

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ventas>> Html { get; private set; }
    }
}
#pragma warning restore 1591
