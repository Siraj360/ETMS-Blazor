#pragma checksum "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Course\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "818f2fb2ae05b4478e0c54252652b67af693d9c6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ETMS_Blazor.Pages.Course
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using ETMS_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using ETMS_Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using ETMS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using ETMS.Data.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editemployee/{id}")]
    public partial class EditEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Course\EditEmployee.razor"
       

    [Parameter]
    public string id { get; set; }

    Employee employee = new Employee();

    protected override async Task OnInitializedAsync()
    {
        employee = await EmployeeService.SingleEmployee(id);
    }

    protected async Task UpdateEmployee()
    {
        await EmployeeService.EditEmployee(id, employee);
        NavigationManager.NavigateTo("listemployees");
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("listemployees");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmployeeService EmployeeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
