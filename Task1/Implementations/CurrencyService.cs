using Newtonsoft.Json;
using Task1.Interfaces;

namespace Task1.Implementations;

public class CurrencyService : ICurrencyService
{
    public async Task<decimal> LoadCurrencyRate()
    {
        using var client = new HttpClient();
        using var response = await client.GetAsync(
            $"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?valcode=USD&date={DateTime.Now:yyyyMMdd}&json)");
        var json = await response.Content.ReadAsStringAsync();
        dynamic parsedJson = JsonConvert.DeserializeObject(json);
        return parsedJson[0].rate;
    }
}