using System.Net.Http.Headers;

namespace TetrGameAPI;

public class API
{
    private HttpClient _http = new HttpClient();

    public API(string token)
    {
        _http = new HttpClient();
        Func(token);
    }

    async void Func(string token)
    {
        _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        var response = await _http.GetAsync(EndPoints.Ribbon);
        Console.WriteLine(response.StatusCode);
        Console.WriteLine(response.Content);
    }
}