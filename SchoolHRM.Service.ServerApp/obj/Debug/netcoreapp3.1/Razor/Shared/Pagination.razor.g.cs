#pragma checksum "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\Shared\Pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b5fefb5f11d97dbe2b3cbeb71308733f6945a46"
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
    public partial class Pagination : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "aria-label", "Page navigation example");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "pagination justify-content-center");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 3 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\Shared\Pagination.razor"
         foreach (var link in linkModels)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\Shared\Pagination.razor"
                             () => SelectedPageInternal(link)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "style", "cursor:pointer;");
            __builder.AddAttribute(10, "class", "page-item" + " " + (
#nullable restore
#line 7 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\Shared\Pagination.razor"
                                   link.Enabled ? null : "disabled"

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 7 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\Shared\Pagination.razor"
                                                                       link.Active ? "active" :null

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "span");
            __builder.AddAttribute(13, "class", "page-link");
            __builder.AddAttribute(14, "href", "#");
            __builder.AddContent(15, 
#nullable restore
#line 8 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\Shared\Pagination.razor"
                                                  link.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 10 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\Shared\Pagination.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\avinash.bobba\source\repos\school-service-web-app\SchoolHRM.Service.ServerApp\Shared\Pagination.razor"
       
    [Parameter] public int PageNumber { get; set; } = 1;
    [Parameter] public int PageCount { get; set; }
    [Parameter] public int Radius { get; set; } = 3;
    [Parameter] public EventCallback<int> SelectedPage { get; set; }
    List<LinkModel> linkModels;

    protected override void OnParametersSet()
    {
        LoadPages();
    }

    private async Task SelectedPageInternal(LinkModel link)
    {
        if(link.Page == PageNumber)
        {
            return;
        }
        if(!link.Enabled)
        {
            return;
        }
        PageNumber = link.Page;
        await SelectedPage.InvokeAsync(link.Page);
    }

    private void LoadPages()
    {
        linkModels = new List<LinkModel>();
        var isPreviousPageLinkEnabled = PageNumber != 1;
        var previousPage = PageNumber - 1;
        linkModels.Add(new LinkModel(previousPage, isPreviousPageLinkEnabled, "Previous"));

        for (int i = 1; i < PageCount; i++)
        {
            if(i >= PageNumber - Radius && i <= PageNumber + Radius)
            {
                linkModels.Add(new LinkModel(i) { Active = PageNumber == i });
            }
        }
        var isNextPageLinkEnabled = PageNumber != PageCount;
        var nextPage = PageNumber + 1;
        linkModels.Add(new LinkModel(nextPage, isNextPageLinkEnabled, "Next"));
    }

    class LinkModel
    {
        public LinkModel(int page)
            : this(page, true) { }


        public LinkModel(int page, bool enabled)
            : this(page, enabled, page.ToString())
        {

        }

        public LinkModel(int page, bool enabled, string text)
        {
            Page = page;
            Enabled = enabled;
            Text = text;
        }

        public string Text { get; set; }

        public int Page { get; set; }

        public bool Enabled { get; set; } = true;

        public bool Active { get; set; } = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
