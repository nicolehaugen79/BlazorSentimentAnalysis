#pragma checksum "D:\DevSpikes\ScalableSentimentAnalysisBlazorWebApp-Docker\BlazorSentimentAnalysis.Client\Pages\Review.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea70a1e5e31a92aaf926f42667768279e8900c26"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorSentimentAnalysis.Client.Pages
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
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Review : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 11 "D:\DevSpikes\ScalableSentimentAnalysisBlazorWebApp-Docker\BlazorSentimentAnalysis.Client\Pages\Review.razor"
            
    float happiness = 50; // 0=worst, 100=best

    async void UpdateScoreAsync(UIChangeEventArgs evt)
    {
        string targetText = (string)evt.Value;

        //Make a real call to Sentiment service
        happiness = await PredictSentimentAsync(targetText);
    }

    private async Task<float> PredictSentimentAsync(string targetText)
    {
        string url = $"api/Sentiment/sentimentprediction?sentimentText={targetText}";

        float percentage = await Http.GetJsonAsync<float>(url);

        return percentage;
    }

    // Sample test without ML.NET model
    //
    //void UpdateScore(UIChangeEventArgs evt)
    //{
    //    string targetText = (string)evt.Value;

    //    //Random percentage
    //    Random random = new Random();
    //    happiness = random.Next(0, 100);
    //}

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
