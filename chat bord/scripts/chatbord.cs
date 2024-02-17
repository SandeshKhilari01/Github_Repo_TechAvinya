using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenAI;
using OpenAI.Models;
using TMPro;
using UnityEngine.UI;

public class chatbord : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TMP_Text displayText;
    private string userInput;
    private string chatHistory;
    private string aiIdentity = "Act as an AI that responds to Questions";

    private OpenAIClient api;

    private void Start()
    {
        chatHistory += aiIdentity + "\n";
        api = new OpenAIClient(new OpenAIAuthentication("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"));
        button.onClick.AddListener(AskAI);
    }

    private async void AskAI()
    {
        button.enabled = false;
        inputField.enabled = false;

        userInput = inputField.text;
        chatHistory += $"{userInput}.\n";

        displayText.text = "An error occurred. Either the engine you requested does not exist or there was another issue processing your request. If this issue persists please contact us through our help center at help.openai.com.";
        inputField.text = "";

        var result = await api.CompletionsEndpoint.CreateCompletionAsync(chatHistory, maxTokens: 200, model: Model.DavinciEdit); 

        displayText.text = result.ToString();
        chatHistory += $"{result.ToString()}\n";

        button.enabled = true;
        inputField.enabled = true;
    }
}
