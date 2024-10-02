using Azure;
using System;
using Azure.AI.TextAnalytics;
using System.Collections.Generic;
using SentimentAnalysis;

namespace Example
{
    class Program
    {
        static string languageKey = "e61d1f94050a4679ab56c6a55d8ecf08";
        static string languageEndpoint = "https://mmsentimentanalysis.cognitiveservices.azure.com/";

        private static readonly AzureKeyCredential credentials = new AzureKeyCredential(languageKey);
        private static readonly Uri endpoint = new Uri(languageEndpoint);

        
        static void Main(string[] args)
        {
            var client = new TextAnalyticsClient(endpoint, credentials);
            SentimentCalculation.SentimentAnalysisWithOpinionMiningExample(client);

            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }

    }
}