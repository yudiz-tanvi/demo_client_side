// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWASMCRUD.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorDemoClientSide\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorDemoClientSide\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorDemoClientSide\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorDemoClientSide\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorDemoClientSide\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorDemoClientSide\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorDemoClientSide\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorDemoClientSide\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorDemoClientSide\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using BlazorWASMCRUD.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorDemoClientSide\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using BlazorWASMCRUD.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorDemoClientSide\BlazorWASMCRUD\BlazorWASMCRUD\Client\Pages\AddEmployee.razor"
using BlazorWASMCRUD.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addemployee")]
    public partial class AddEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorDemoClientSide\BlazorWASMCRUD\BlazorWASMCRUD\Client\Pages\AddEmployee.razor"
       
    Employee emp = new Employee();
    protected async Task CreateEmployee()
    {
        await Http.PostAsJsonAsync("http://localhost:34451/api/EmployeeInfoes" , emp);
        NavigationManager.NavigateTo("employeeList");
    }
    void Cancle()
    {
        NavigationManager.NavigateTo("employeeList");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
