#nullable disable
using OpenAI.Chat;
using OpenAI.Moderations;
using System.ClientModel;

ChatClient client = new(model: "gpt-4o", apiKey: "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");

string input = Console.ReadLine();
UserChatMessage userChatMessage = new(input);

CollectionResult<StreamingChatCompletionUpdate> chatCompletion = client.CompleteChatStreaming(userChatMessage);

foreach (var update in chatCompletion)
{
	if (update.ContentUpdate.Count > 0)
	{
		Console.Write(update.ContentUpdate[0].Text);
	}
}
