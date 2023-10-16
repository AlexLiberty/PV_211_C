using Lesson_16_10;
using System;
using System.Net.Http;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json;

Console.OutputEncoding = System.Text.Encoding.UTF8;

//static async void GetData()
//{
//    string url = @"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json";
//    HttpClient client = new HttpClient();
//    var responce = await client.GetAsync(new Uri(url));
//    if (responce.IsSuccessStatusCode)
//    {
//        Console.WriteLine(responce);
//    }
//}
//GetData();
//Console.ReadLine();

static async void GetData()
{
    double sum = GiveMoney();
    string url = @"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json";
    HttpClient client = new HttpClient();
    var responce = await client.GetAsync(new Uri(url));
    if (responce.IsSuccessStatusCode)
    {
       string jsonContent=await responce.Content.ReadAsStringAsync();
        List<Currency> data=JsonConvert.DeserializeObject<List<Currency>>(jsonContent);
        //Console.WriteLine(data.Count);
        foreach(Currency currency in data)
        {
            if(currency.r030==840.ToString())
            {
                Console.WriteLine(sum/currency.rate);
            }
            //Console.WriteLine($"{currency.r030} {currency.cc} {currency.rate}");
        }
    }
}
static int GiveMoney()
{
    Console.WriteLine("Сума у гривні: ");
    return (int)Convert.ToDouble(Console.ReadLine());
}

GetData();
Console.ReadLine();

