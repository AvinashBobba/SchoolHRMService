#pragma checksum "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d19038430af35f72a451463d2a218469476c6c1"
// <auto-generated/>
#pragma warning disable 1591
namespace SchoolHRM.Service.ServerApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\_Imports.razor"
using SchoolHRM.Service.ServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\_Imports.razor"
using SchoolHRM.Service.ServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\_Imports.razor"
using SchoolHRM.Service.ServerApp.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\_Imports.razor"
using SchoolHRM.Service.ComponentsLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\_Imports.razor"
using SchoolHRM.Service.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\_Imports.razor"
using SchoolHRM.Service.ServerApp.Helpers;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-light");
            __builder.AddAttribute(2, "id", "sidebar-wrapper");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "menu list-group list-group-flush");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(7);
            __builder.AddAttribute(8, "class", "list-group-item list-group-item-action bg-light");
            __builder.AddAttribute(9, "href", "/");
            __builder.AddAttribute(10, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 3 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\Shared\NavMenu.razor"
                                                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n            <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(14);
            __builder.AddAttribute(15, "class", "list-group-item list-group-item-action bg-light");
            __builder.AddAttribute(16, "href", "/employeeoverview");
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "\r\n            <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Employees\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "list-group-item list-group-item-action bg-light");
            __builder.AddAttribute(22, "href", "/employeeedit");
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "\r\n            <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Add new employee\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(26);
            __builder.AddAttribute(27, "class", "list-group-item list-group-item-action bg-light");
            __builder.AddAttribute(28, "href", "/studentoverview");
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "\r\n            <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Students\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(32);
            __builder.AddAttribute(33, "class", "list-group-item list-group-item-action bg-light");
            __builder.AddAttribute(34, "href", "/studentedit");
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(36, "\r\n            <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Add new student\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(38);
            __builder.AddAttribute(39, "class", "list-group-item list-group-item-action bg-light");
            __builder.AddAttribute(40, "href", "/gallery");
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(42, "\r\n            <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Gallery\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
