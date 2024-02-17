
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tochatbot : MonoBehaviour
{
    public string chatbot = "chatbot";

    // Load the specified level
    public void OnchatbotButtonClick()
    {
        SceneManager.LoadScene(chatbot);
    }
}