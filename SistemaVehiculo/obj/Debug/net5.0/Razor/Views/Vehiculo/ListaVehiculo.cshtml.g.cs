#pragma checksum "C:\Users\danny\Desktop\SistemaAlquiler\SistemaVehiculo\Views\Vehiculo\ListaVehiculo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "430551a10faccf71b34f8ff69fb654974c759d6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehiculo_ListaVehiculo), @"mvc.1.0.view", @"/Views/Vehiculo/ListaVehiculo.cshtml")]
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
#line 1 "C:\Users\danny\Desktop\SistemaAlquiler\SistemaVehiculo\Views\_ViewImports.cshtml"
using SistemaVehiculo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danny\Desktop\SistemaAlquiler\SistemaVehiculo\Views\_ViewImports.cshtml"
using SistemaVehiculo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"430551a10faccf71b34f8ff69fb654974c759d6b", @"/Views/Vehiculo/ListaVehiculo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63ed3bb466569cfb07b89fc2a7fecbeaa6c89a2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehiculo_ListaVehiculo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemaVehiculo.Models.MVehiculos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\danny\Desktop\SistemaAlquiler\SistemaVehiculo\Views\Vehiculo\ListaVehiculo.cshtml"
  
    ViewData["Title"] = "ListaVehiculo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista de Vehículos</h1>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\danny\Desktop\SistemaAlquiler\SistemaVehiculo\Views\Vehiculo\ListaVehiculo.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group mt-5\">\r\n        <label for=\"marca\">Filtrar: </label>\r\n        <input name=\"marca\" id=\"marca\" />\r\n        <input type=\"submit\" value=\"Buscar\" class=\"btn btn-outline-success\">\r\n    </div>\r\n");
#nullable restore
#line 17 "C:\Users\danny\Desktop\SistemaAlquiler\SistemaVehiculo\Views\Vehiculo\ListaVehiculo.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table class=""table table-striped"">
    <thead>
        <tr>
            <th>
                ID
            </th>
            <th>
                Marca
            </th>
            <th>
                Modelo
            </th>
            <th>
                Tipo
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 38 "C:\Users\danny\Desktop\SistemaAlquiler\SistemaVehiculo\Views\Vehiculo\ListaVehiculo.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\danny\Desktop\SistemaAlquiler\SistemaVehiculo\Views\Vehiculo\ListaVehiculo.cshtml"
               Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\danny\Desktop\SistemaAlquiler\SistemaVehiculo\Views\Vehiculo\ListaVehiculo.cshtml"
               Write(Html.DisplayFor(modelItem => item.marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\danny\Desktop\SistemaAlquiler\SistemaVehiculo\Views\Vehiculo\ListaVehiculo.cshtml"
               Write(Html.DisplayFor(modelItem => item.modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\danny\Desktop\SistemaAlquiler\SistemaVehiculo\Views\Vehiculo\ListaVehiculo.cshtml"
               Write(Html.DisplayFor(modelItem => item.tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 54 "C:\Users\danny\Desktop\SistemaAlquiler\SistemaVehiculo\Views\Vehiculo\ListaVehiculo.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemaVehiculo.Models.MVehiculos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
