#pragma checksum "C:\work\Dotnet\DotnetLab2\Server\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d52409c3b8ef94ea2e1bdf91ad8d63c664f7ebf5"
// <auto-generated/>
#pragma warning disable 1591
namespace DotnetLab2.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\work\Dotnet\DotnetLab2\Server\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\work\Dotnet\DotnetLab2\Server\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\work\Dotnet\DotnetLab2\Server\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\work\Dotnet\DotnetLab2\Server\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\work\Dotnet\DotnetLab2\Server\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\work\Dotnet\DotnetLab2\Server\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\work\Dotnet\DotnetLab2\Server\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\work\Dotnet\DotnetLab2\Server\Client\_Imports.razor"
using DotnetLab2.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\work\Dotnet\DotnetLab2\Server\Client\_Imports.razor"
using DotnetLab2.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world! Today is DotNet Lab Feb.</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<DotnetLab2.Client.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
