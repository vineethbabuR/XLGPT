using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using OpenAI;
using OpenAI.Chat;

namespace OpenAIUtility
{
    public class FunctionAssistant
    {
        public static List<string> GetAnswer(string question, string model, string apikey, float temp)
        {
            ChatClient client = new(model: model, apiKey: apikey);
            List<ChatMessage> messages = new List<ChatMessage> { new UserChatMessage($"You are an expert in Excel. " +
                $" {question} . " +
                $"Please proivde the explanation in the explanation property, " +
                $"but just provide  excel formula in the final_answer property. It is important that you exclude or remove all escape characters, line continuation characters, etc.. from the formula." +
                $"It is also important that theses  formula should be the most efficient ones. Unless otherwise" +
                $"mentioned by the user, assume the Excel version being used is Excel 2016. If the question is to provide VBA code, please add the VBA code in the " +
                $"final_answer property. If the question is to provide both excel VBA code and excel formula, please add them in the final_answer property as array items.") };
            ChatCompletionOptions options = new()
            {
                Temperature = temp,
                ResponseFormat = ChatResponseFormat.CreateJsonSchemaFormat(
                    jsonSchemaFormatName: "Advanced_Excel_Formulas",
                    jsonSchema: BinaryData.FromString(@"
                                        {
                                            ""type"": ""object"",
                                            ""properties"": {
                                                ""steps"": {
                                                    ""type"": ""array"",
                                                    ""items"": {
                                                        ""type"": ""object"",
                                                        ""properties"": {
                                                            ""explanation"": { ""type"": ""string"" },
                                                            ""output"": { ""type"": ""string"" }
                                                        },
                                                        ""required"": [""explanation"", ""output""],
                                                        ""additionalProperties"": false
                                                    }
                                                },
                                                ""final_answer"": {
                                                    ""type"": ""array"",
                                                    ""items"": { ""type"": ""string"" }
                                                }
                                            },
                                            ""required"": [""steps"", ""final_answer""],
                                            ""additionalProperties"": false
                                        }"
                    ),
                    jsonSchemaIsStrict:true)
                    
            };

            ChatCompletion completion = client.CompleteChat(messages, options);
            using JsonDocument structuredJson = JsonDocument.Parse(completion.Content[0].Text);

            List<string> finalAnswer = new();
           

            foreach (var stepElement in structuredJson.RootElement.GetProperty("final_answer").EnumerateArray())
            {
                finalAnswer.Add(stepElement.ToString());
            }

          

           /* var output = structuredJson.RootElement.GetProperty("final_answer").ToString()
                    .Replace("\\", "")
                    .Replace("\n", "")
                    .Replace("\r", "")
                    .Trim();
           */

            //foreach (var stepElement in structuredJson.RootElement.GetProperty("steps").EnumerateArray())
            //{
            //    output =  stepElement.GetProperty("output").ToString();
            //}

            return finalAnswer;
        }

        

        
    }

    public static class ResultStore
    {
        public static List<string>? Explanation { get; set; }
        public static List<string>? Result { get; set; }
    }
}
