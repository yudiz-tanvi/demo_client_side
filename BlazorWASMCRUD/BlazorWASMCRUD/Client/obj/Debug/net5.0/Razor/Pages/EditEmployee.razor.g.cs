#pragma checksum "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorWASMCRUD\BlazorWASMCRUD\Client\Pages\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "426f8520791f574091af474395322269964cd5bc"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWASMCRUD.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using BlazorWASMCRUD.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorWASMCRUD\BlazorWASMCRUD\Client\_Imports.razor"
using BlazorWASMCRUD.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorWASMCRUD\BlazorWASMCRUD\Client\Pages\EditEmployee.razor"
using BlazorWASMCRUD.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editEmployee/{id}")]
    public partial class EditEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Edit Employee</h2>\r\n<hr>\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"EmpName\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "form", "EmpName");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorWASMCRUD\BlazorWASMCRUD\Client\Pages\EditEmployee.razor"
                                                                   emp.EmpName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.EmpName = __value, emp.EmpName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"Designation\" class=\"control-label\">Designation</label>\r\n                ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "form", "Designation");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorWASMCRUD\BlazorWASMCRUD\Client\Pages\EditEmployee.razor"
                                                                       emp.Designation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.Designation = __value, emp.Designation));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "<label for=\"Department\" class=\"control-label\">Department</label>\r\n                ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "form", "Department");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorWASMCRUD\BlazorWASMCRUD\Client\Pages\EditEmployee.razor"
                                                                      emp.Department

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.Department = __value, emp.Department));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "row");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "=col-md-4");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-group");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "class", "btn btn-primary");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorWASMCRUD\BlazorWASMCRUD\Client\Pages\EditEmployee.razor"
                                                                        UpdateEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "btn");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorWASMCRUD\BlazorWASMCRUD\Client\Pages\EditEmployee.razor"
                                                            Cancle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\YUDIZ\Trainee\B\BlazorLocal\BlazorWASMCRUD\BlazorWASMCRUD\Client\Pages\EditEmployee.razor"
       
    [Parameter]
    public string id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        emp = await Http.GetFromJsonAsync<Employee>("http://localhost:34451/api/EmployeeInfoes/"+id);
    }

    Employee emp = new Employee();
    protected async Task UpdateEmployee()
    {
        await Http.PutAsJsonAsync("http://localhost:34451/api/EmployeeInfoes/"+id, emp);
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
