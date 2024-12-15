using OpenAI.Chat;
using System.Text.Json;

namespace OpenAIUtility
{
    public class FunctionAssistant
    {
        public static (List<(string explanation, string output)>, List<string>) GetAnswer(string question, string model,
                        string apikey, float temp, float freq_pen, float top_p)
        {
            if (string.IsNullOrWhiteSpace(question))
                throw new ArgumentException("Question cannot be null or empty.", nameof(question));
            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentException("Model cannot be null or empty.", nameof(model));
            if (string.IsNullOrWhiteSpace(apikey))
                throw new ArgumentException("API key cannot be null or empty.", nameof(apikey));
            if (temp < 0 || temp > 1)
                throw new ArgumentOutOfRangeException(nameof(temp), "Temperature must be between 0 and 1.");
            try
            {
                ChatClient client = new(model: model, apiKey: apikey);

                var prompt = @$"
                       You are an expert in all aspects of Microsoft Excel. Please answer the following question with precision and efficiency:

                        1. Provide a step-by-step explanation in the `steps` property.
                        2. Include only the final output (Excel formula, VBA code, DAX Expression, or Power Query M script) in the `final_answer` property.

                        Guidelines:
                        - Responses must strictly adhere to the functionality and syntax supported by Excel, Power BI, or related environments unless otherwise specified (e.g., Excel 2016, Excel 365, or Power BI Desktop).
                        - Exclude or remove all escape characters, line continuation characters, Unicode characters, or unnecessary formatting from the output.
                        - Do not include speculative or unverifiable information. Base all answers on documented Excel, Power BI, and Power Query features and syntax.
                        - Optimize all outputs (formulas, DAX expressions, M scripts, VBA code, etc.) for performance, readability, and clarity.
                        - When applicable, provide specific examples, assumptions, or use cases to illustrate the solution.
                        - If the question cannot be answered or is unclear, explicitly state this in the `steps` property without attempting to fabricate an answer.

                        Formatting:
                        - Format VBA code with proper indentation and clear comments to improve readability.
                        - Format Excel formulas for clarity by avoiding unnecessary nesting or redundancy.
                        - Format DAX expressions with line breaks and indentation to make complex calculations easier to read.
                        - Format Power Query M scripts with proper indentation and spacing to enhance readability and maintainability.

                        Format:
                        - If the question involves advanced Excel formulas, include the formula in the `final_answer` property.
                        - If the question involves VBA code, include the VBA code in the `final_answer` property.
                        - If the question involves DAX Expressions, include the DAX code in the `final_answer` property.
                        - If the question involves Power Query M scripts, include the M script in the `final_answer` property.
                        - If multiple outputs (e.g., VBA code and Excel formula, or DAX and Power Query M script) are required, include them as separate items in the `final_answer` array.

                        Note:
                        - Provide the most efficient and advanced solution available for the given context.
                        - Ensure consistency and accuracy across all outputs.

                        Here is the question:
                        \{question}\";

                List<ChatMessage> messages = new List<ChatMessage> { new UserChatMessage(prompt) };

                var jsonSchema = @"            {
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
            }";

                ChatCompletionOptions options = new()
                {
                    Temperature = temp,     
                    FrequencyPenalty = freq_pen,
                    TopP = top_p,
                    ResponseFormat = ChatResponseFormat.CreateJsonSchemaFormat(
                        jsonSchemaFormatName: "Advanced_Excel_Formulas",
                        jsonSchema: BinaryData.FromString(jsonSchema),
                        jsonSchemaIsStrict: true)
                };

                ChatCompletion completion = client.CompleteChat(messages, options);
                using JsonDocument structuredJson = JsonDocument.Parse(completion.Content[0].Text);

                var steps = new List<(string explanation, string output)>();
                var finalAnswer = new List<string>();

                foreach (var stepElement in structuredJson.RootElement.GetProperty("steps").EnumerateArray())
                {
                    var explanation = stepElement.GetProperty("explanation").GetString();
                    var output = stepElement.GetProperty("output").GetString();
                    steps.Add((explanation, output));
                }

                foreach (var answerElement in structuredJson.RootElement.GetProperty("final_answer").EnumerateArray())
                {
                    finalAnswer.Add(answerElement.ToString());
                }

                return (steps, finalAnswer);

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
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

    public static class ResultStore
    {
        public static List<string>? Explanation { get; set; }
        public static (List<(string, string)>, List<string>) Result { get; set; }
    }
}