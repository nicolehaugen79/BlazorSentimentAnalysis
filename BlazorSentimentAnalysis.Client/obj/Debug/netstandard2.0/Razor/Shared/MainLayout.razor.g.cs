#pragma checksum "D:\DevSpikes\ScalableSentimentAnalysisBlazorWebApp-Docker\BlazorSentimentAnalysis.Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4d4ef6a2acd02575f1bffd426c77bcb182965e3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSentimentAnalysis.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using BlazorSentimentAnalysis.Client;
    using BlazorSentimentAnalysis.Client.Shared;
    public class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "main");
            builder.AddMarkupContent(2, "\r\n    ");
            builder.OpenElement(3, "div");
            builder.AddAttribute(4, "class", "content px-4");
            builder.AddMarkupContent(5, "\r\n        ");
            builder.AddContent(6, Body);
            builder.AddMarkupContent(7, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(8, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
