using System;
using System.Net;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Please provide a URL as the first argument.");
            return;
        }

        string url = args[0];

        WebClient client = new WebClient();
        string html = client.DownloadString(url);

        Regex linkRegex = new Regex(@"<a\s+(?:[^>]*?\s+)?href=([""'])(.*?)\1", RegexOptions.IgnoreCase);
        MatchCollection linkMatches = linkRegex.Matches(html);

        foreach (Match match in linkMatches)
        {
            string linkUrl = match.Groups[2].Value;
            Console.WriteLine(linkUrl);
        }
    }
}
