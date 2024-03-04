using System.Net.Http;

WriteLine("Connecting...");
// string url = ReadLine();
// string r = url ??= "https://www.microsoft.com/?";
// WriteLine(r);

HttpClient clinet = new();
HttpResponseMessage response = await clinet.GetAsync("https://www.microsoft.com");
WriteLine("Microsoft's home page has {0:N0} bytes.", response.Content.Headers.ContentLength);