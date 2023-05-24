using System.Net;
using System.Text.Json;

namespace BlazorApp.Data;

public class QuoteService
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    // public Task<Quotes> GetQuoteAsync(DateOnly startDate)
    // {
    //     using (WebClient wc = new WebClient())
    //     {
    //         var json = wc.DownloadString("https://gist.github.com/nasrulhazim/54b659e43b1035215cd0ba1d4577ee80");
    //         JsonSerializer.Deserialize(json)
    //     }
    //     return Task.FromResult();
    // }
}
