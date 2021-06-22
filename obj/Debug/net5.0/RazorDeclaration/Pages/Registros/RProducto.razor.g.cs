// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Registro_Detalle2_Ap2.Pages.Registros
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lina\Desktop\APLICADA II\Registros\Registro_Detalle2_Ap2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lina\Desktop\APLICADA II\Registros\Registro_Detalle2_Ap2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lina\Desktop\APLICADA II\Registros\Registro_Detalle2_Ap2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lina\Desktop\APLICADA II\Registros\Registro_Detalle2_Ap2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lina\Desktop\APLICADA II\Registros\Registro_Detalle2_Ap2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lina\Desktop\APLICADA II\Registros\Registro_Detalle2_Ap2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lina\Desktop\APLICADA II\Registros\Registro_Detalle2_Ap2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lina\Desktop\APLICADA II\Registros\Registro_Detalle2_Ap2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lina\Desktop\APLICADA II\Registros\Registro_Detalle2_Ap2\_Imports.razor"
using Registro_Detalle2_Ap2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lina\Desktop\APLICADA II\Registros\Registro_Detalle2_Ap2\_Imports.razor"
using Registro_Detalle2_Ap2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lina\Desktop\APLICADA II\Registros\Registro_Detalle2_Ap2\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lina\Desktop\APLICADA II\Registros\Registro_Detalle2_Ap2\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lina\Desktop\APLICADA II\Registros\Registro_Detalle2_Ap2\Pages\Registros\RProducto.razor"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lina\Desktop\APLICADA II\Registros\Registro_Detalle2_Ap2\Pages\Registros\RProducto.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RProducto")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/RProducto/{ProductoId:int}")]
    public partial class RProducto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\Lina\Desktop\APLICADA II\Registros\Registro_Detalle2_Ap2\Pages\Registros\RProducto.razor"
       
    [Parameter]
    public int ProductoId { get; set; }

    private Productos productos = new Productos();

    protected override void OnInitialized()
    {
        if (ProductoId > 0)
        {
            productos = ProductosBLL.Buscar(ProductoId);
        }
    }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\Lina\Desktop\APLICADA II\Registros\Registro_Detalle2_Ap2\Pages\Registros\RProducto.razor"
                                                   
    public void Nuevo()
    {
        productos = new Productos();
    }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\Lina\Desktop\APLICADA II\Registros\Registro_Detalle2_Ap2\Pages\Registros\RProducto.razor"
                                                    
    private void Buscar()
    {
        var encontrado = ProductosBLL.Buscar(productos.ProductoId);

        if (encontrado != null)
        {
            this.productos = encontrado;
            return;
        }
        else
            Nuevo();
        Toast.ShowWarning("Esta Id no pudo ser encontrada.");
        return;
    }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\Lina\Desktop\APLICADA II\Registros\Registro_Detalle2_Ap2\Pages\Registros\RProducto.razor"
                                                     
    public void Guardar()
    {
        bool guardado;

        guardado = ProductosBLL.Guardar(productos);

        if (guardado)
        {
            Nuevo();
            Toast.ShowSuccess("Registro Guardado exitosamente.");
        }
        else
            Toast.ShowError("No fue posible Guardar este Registro.");
        return;
    }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "C:\Users\Lina\Desktop\APLICADA II\Registros\Registro_Detalle2_Ap2\Pages\Registros\RProducto.razor"
                                                      
    public void Eliminar()
    {
        bool eliminado;

        eliminado = ProductosBLL.Eliminar(productos.ProductoId);

        if (eliminado)
        {
            Nuevo();
            Toast.ShowSuccess("Registro Eliminado exitosamente.");
        }
        else
            Toast.ShowError("No fue posible Eliminar este Registro.");
        return;
    }

    //++++++++++++++++++ ValorInventario ++++++++++++++++++
    public void ActualizarInventario()
    {
        productos.ValorInventario = (Convert.ToDecimal(productos.Existencia) * productos.Costo);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService Toast { get; set; }
    }
}
#pragma warning restore 1591
