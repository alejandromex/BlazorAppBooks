#pragma checksum "C:\Users\USUARIO\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\FilmDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b733389cdd731598ecb283e18dc78c886dfbd416"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\USUARIO\source\repos\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USUARIO\source\repos\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USUARIO\source\repos\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\USUARIO\source\repos\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\USUARIO\source\repos\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\USUARIO\source\repos\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\USUARIO\source\repos\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\USUARIO\source\repos\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using BlazorCRUD.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\USUARIO\source\repos\BlazorCRUD\BlazorCRUD.UI\_Imports.razor"
using BlazorCRUD.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USUARIO\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\FilmDetails.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\USUARIO\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\FilmDetails.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/filmdetails")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/filmdetails/{id:int}")]
    public partial class FilmDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>FilmDetails</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\USUARIO\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\FilmDetails.razor"
                 film

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table");
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "tr");
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.AddMarkupContent(10, "<td>Title:</td>\r\n            ");
                __builder2.OpenElement(11, "td");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "type", "text");
                __builder2.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\USUARIO\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\FilmDetails.razor"
                                          film.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => film.Title = __value, film.Title));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenElement(18, "tr");
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.AddMarkupContent(20, "<td>Director:</td>\r\n            ");
                __builder2.OpenElement(21, "td");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "type", "text");
                __builder2.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\USUARIO\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\FilmDetails.razor"
                                          film.Director

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => film.Director = __value, film.Director));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "tr");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.AddMarkupContent(30, "<td>Release Date:</td>\r\n            ");
                __builder2.OpenElement(31, "td");
                __builder2.OpenElement(32, "input");
                __builder2.AddAttribute(33, "type", "datetime");
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\USUARIO\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\FilmDetails.razor"
                                              film.ReleaseDate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => film.ReleaseDate = __value, film.ReleaseDate));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenElement(38, "tr");
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.OpenElement(40, "td");
                __builder2.AddAttribute(41, "colspan", "2");
                __builder2.AddAttribute(42, "style", "text-align: center;");
                __builder2.AddMarkupContent(43, "\r\n                ");
                __builder2.OpenElement(44, "input");
                __builder2.AddAttribute(45, "type", "submit");
                __builder2.AddAttribute(46, "value", "Save");
                __builder2.AddAttribute(47, "class", "btn btn-primary");
                __builder2.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\USUARIO\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\FilmDetails.razor"
                                                                                     SaveFilm

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                ");
                __builder2.OpenElement(50, "input");
                __builder2.AddAttribute(51, "type", "button");
                __builder2.AddAttribute(52, "value", "Cancel");
                __builder2.AddAttribute(53, "class", "btn btn-danger");
                __builder2.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\USUARIO\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\FilmDetails.razor"
                                                                                      CancelFilm

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\USUARIO\source\repos\BlazorCRUD\BlazorCRUD.UI\Pages\FilmDetails.razor"
       

    [Parameter]
    public int id { get; set; }

    Film film = new Film();

    protected void CancelFilm()
    {

    }

    protected async Task SaveFilm()
    {
        await FilmService.SaveFilm(film);
    }

    protected async override Task OnInitializedAsync()
    {
        if(id == 0)
        {
            film.ReleaseDate = DateTime.Now;
        }
        else
        {
            film = await FilmService.GetDetails(id);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFilmService FilmService { get; set; }
    }
}
#pragma warning restore 1591
