#pragma checksum "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Rol\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f55376c2874e57cfda77d8457d1134bca489f446"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rol_Index), @"mvc.1.0.view", @"/Views/Rol/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f55376c2874e57cfda77d8457d1134bca489f446", @"/Views/Rol/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4554b10dbe20898f6d13248fb5df52fbb1954d04", @"/Views/_ViewImports.cshtml")]
    public class Views_Rol_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Rol>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
	body {
		background: rgb(52,58,64);
		background: linear-gradient(90deg, rgba(52,58,64,1) 0%, rgba(108,117,125,1) 25%, rgba(145,145,145,1) 50%, rgba(108,117,125,1) 75%, rgba(52,58,64,1) 100%);
		/*background: rgb(108,117,125);
		background: radial-gradient(circle, rgba(108,117,125,1) 0%, rgba(52,58,64,1) 80%, rgba(52,58,64,1) 100%);*/
	}

</style>

<div class=""row"">
	<div class=""col-6 offset-3 text-left text-center"">
		<h2 class=""text-dark border-bottom border-dark"" style=""font-size:100px;""><i class=""fa-solid fa-id-badge""></i></h2>
	</div>
</div>


<div class=""row"">
	<div class=""col-12 text-lg-right"">
		<a href=""/Rol/upsert/"" class=""btn btn-dark""><i class=""fa-solid fa-circle-plus""></i> &nbsp; Crear nuevo Rol</a>
	</div>
</div>

<br />
<div class=""bg-dark p-4 border rounded "">
	<div class=""bg-light p-1"">
		<table id=""Roles"" class=""table table-hover table-striped container"">
			<thead class=""thead-dark"">
				<tr");
            BeginWriteAttribute("class", " class=\"", 949, "\"", 957, 0);
            EndWriteAttribute();
            WriteLiteral(">\n\t\t\t\t\t<th colspan=\"2\" class=\"text-center\">Roles</th>\n\t\t\t\t</tr>\n\t\t\t</thead>\n\t\t\t<tbody class=\"table-light\">\n");
#nullable restore
#line 35 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Rol\Index.cshtml"
                 if (Model != null)
				{
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Rol\Index.cshtml"
                     foreach (var Rol in Model)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<tr");
            BeginWriteAttribute("id", " id=\"", 1144, "\"", 1160, 2);
            WriteAttributeValue("", 1149, "Rol_", 1149, 4, true);
#nullable restore
#line 39 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Rol\Index.cshtml"
WriteAttributeValue("", 1153, Rol.Id, 1153, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 40 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Rol\Index.cshtml"
                           Write(Rol.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\t\t\t\t\t\t\t<td>\n\t\t\t\t\t\t\t\t<div class=\"text-right\">\n\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1247, "\"", 1289, 2);
            WriteAttributeValue("", 1254, "/Rol/ReporteMatriculadosRol/", 1254, 28, true);
#nullable restore
#line 43 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Rol\Index.cshtml"
WriteAttributeValue("", 1282, Rol.Id, 1282, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary text-white\" style=\"cursor:pointer\">\n\t\t\t\t\t\t\t\t\t\t<i class=\"fa-solid fa-share-from-square\"></i> Reporte por Empleados\n\t\t\t\t\t\t\t\t\t</a>\n\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1455, "\"", 1481, 2);
            WriteAttributeValue("", 1462, "/Rol/upsert/", 1462, 12, true);
#nullable restore
#line 46 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Rol\Index.cshtml"
WriteAttributeValue("", 1474, Rol.Id, 1474, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning text-white\" style=\"cursor:pointer\">\n\t\t\t\t\t\t\t\t\t\t<i class=\"fas fa-edit\"></i>\n\t\t\t\t\t\t\t\t\t</a>\n\t\t\t\t\t\t\t\t\t<a onclick=Delete(\"");
#nullable restore
#line 49 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Rol\Index.cshtml"
                                                  Write(Rol.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\") class=\"btn btn-danger text-white\" style=\"cursor:pointer\">\n\t\t\t\t\t\t\t\t\t\t<i class=\"fas fa-trash-alt\"></i>\n\t\t\t\t\t\t\t\t\t</a>\n\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t</td>\n\t\t\t\t\t\t</tr>\n");
#nullable restore
#line 55 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Rol\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Rol\Index.cshtml"
                     
				}
				else
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tr class=\"text-center\">\n\t\t\t\t\t\t<td colspan=\"2\">Sin Datos</td>\n\t\t\t\t\t</tr>\n");
#nullable restore
#line 62 "\\Mac\Home\Desktop\FinalProyectPrograWebAvan\Examen1\Examen.Responsive\Views\Rol\Index.cshtml"
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
			title: ""¿Esta seguro de eliminar el Rol?"",
			text: ""¿Los datos no podran ser recuperandos una vez se hayan eliminado del sistema, esta seguro que desea eliminarlos completamente?"",
			icon: ""warning"",
			buttons: true,
			dangerMode: true
		}).then((willDelete) => {
			if (willDelete) {
				$.ajax({
					type: ""DELETE"",
					url: ""/Rol/delete/"" + id,
					success: function(data) {
						if (data.success) {
							toastr.success(data.message);
							$(""#Rol_"" + id).remove();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Rol>> Html { get; private set; }
    }
}
#pragma warning restore 1591
