#pragma checksum "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Empleado\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37b245026f6ccdafcc941d3b64aa1b9104e8ca5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_Index), @"mvc.1.0.view", @"/Views/Empleado/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37b245026f6ccdafcc941d3b64aa1b9104e8ca5f", @"/Views/Empleado/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4554b10dbe20898f6d13248fb5df52fbb1954d04", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Empleado>>
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
		<h2 class=""text-dark border-bottom border-dark"" style=""font-size:100px;""><i class=""fa-solid fa-people-group""></i></h2>
	</div>
</div>


<div class=""row"">
	<div class=""col-12 text-lg-right"">
		<a href=""/Empleado/upsert/"" class=""btn btn-dark""><i class=""fa-solid fa-circle-plus""></i> &nbsp; Crear nuevo Empleado</a>
		
	</div>
</div>


<br />
");
            WriteLiteral(@"



<div class=""bg-dark p-4 border rounded "">
	<div class=""bg-light p-1"">
		<table id=""Empleados"" class=""table table-hover table-striped container"">
			<thead class=""thead-dark"">
				<tr class=""text-center"">
					<th colspan=""5"">Empleados</th>
				</tr>
			</thead>
			<tbody");
            BeginWriteAttribute("class", " class=\"", 1931, "\"", 1939, 0);
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 72 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Empleado\Index.cshtml"
                 foreach (var Empleado in Model)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr");
            BeginWriteAttribute("id", " id=\"", 1992, "\"", 2018, 2);
            WriteAttributeValue("", 1997, "Empleado_", 1997, 9, true);
#nullable restore
#line 74 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Empleado\Index.cshtml"
WriteAttributeValue("", 2006, Empleado.Id, 2006, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n\t\t\t\t\t<td>\n\t\t\t\t\t\t");
#nullable restore
#line 76 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Empleado\Index.cshtml"
                   Write(Empleado.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t\t</td>\n\t\t\t\t\t<td>\n\t\t\t\t\t\t");
#nullable restore
#line 79 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Empleado\Index.cshtml"
                   Write(Empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t\t</td>\n\t\t\t\t\t<td>\n\t\t\t\t\t\t");
#nullable restore
#line 82 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Empleado\Index.cshtml"
                   Write(Empleado.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t\t</td>\n\t\t\t\t\t<td>\n\t\t\t\t\t\t");
#nullable restore
#line 85 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Empleado\Index.cshtml"
                   Write(Empleado.CorreoElectronico);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t\t</td>\n\t\t\t\t\t<td>\n\t\t\t\t\t\t<div class=\"text-right\">\n\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2262, "\"", 2298, 2);
            WriteAttributeValue("", 2269, "/Empleado/upsert/", 2269, 17, true);
#nullable restore
#line 90 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Empleado\Index.cshtml"
WriteAttributeValue("", 2286, Empleado.Id, 2286, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning text-white\" style=\"cursor:pointer\">\n\t\t\t\t\t\t\t\t<i class=\"fas fa-edit\"></i>\n\t\t\t\t\t\t\t</a>\n\n\t\t\t\t\t\t\t<a onclick=Delete(\"");
#nullable restore
#line 94 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Empleado\Index.cshtml"
                                          Write(Empleado.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\") class=\"btn btn-danger text-white\" style=\"cursor:pointer\">\n\t\t\t\t\t\t\t\t<i class=\"fas fa-trash-alt\"></i>\n\t\t\t\t\t\t\t</a>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t</td>\n\t\t\t\t</tr>\n");
#nullable restore
#line 100 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Empleado\Index.cshtml"

				}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			</tbody>
		</table>

	</div>
</div>


<script>

	function Delete(id) {
		swal({
			title: ""¿Esta seguro de eliminar el Empleado?"",
			text: ""¿Los datos no podran ser recuperandos una vez se hayan eliminado del sistema, esta seguro que desea eliminarlos completamente?"",
			icon: ""warning"",
			buttons: true,
			dangerMode: true
		}).then((willDelete) => {
			if (willDelete) {
				$.ajax({
					type: ""DELETE"",
					url: ""/Empleado/delete/"" + id,
					success: function(data) {
						if (data.success) {
							toastr.success(data.message);
							$(""#Empleado_"" + id).remove();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Empleado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
