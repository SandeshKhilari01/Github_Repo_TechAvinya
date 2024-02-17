using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSeven : MonoBehaviour
{
    public string SeventhOne = "SeventhOne";

    // Load the specified level
    public void OnToSevenButtonClick()
    {
        SceneManager.LoadScene(SeventhOne);
    }
}