#pragma checksum "C:\Users\Sferis\source\repos\Randomem\Randomem\Pages\Meme.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bfecf856cd5a71d68a3b01f5111666b07e66aa3"
// <auto-generated/>
#pragma warning disable 1591
namespace Randomem.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Sferis\source\repos\Randomem\Randomem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sferis\source\repos\Randomem\Randomem\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sferis\source\repos\Randomem\Randomem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sferis\source\repos\Randomem\Randomem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sferis\source\repos\Randomem\Randomem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Sferis\source\repos\Randomem\Randomem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Sferis\source\repos\Randomem\Randomem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Sferis\source\repos\Randomem\Randomem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Sferis\source\repos\Randomem\Randomem\_Imports.razor"
using Randomem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Sferis\source\repos\Randomem\Randomem\_Imports.razor"
using Randomem.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Meme : MemeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "meme");
            __builder.OpenElement(2, "img");
            __builder.AddAttribute(3, "src", 
#nullable restore
#line 5 "C:\Users\Sferis\source\repos\Randomem\Randomem\Pages\Meme.razor"
              memeUrl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591