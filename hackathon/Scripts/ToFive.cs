using UnityEngine;
using UnityEngine.SceneManagement;

public class ToFive : MonoBehaviour
{
    public string FifthOne = "FifthOne";

    // Load the specified level
    public void OnToFifthButtonClick()
    {
        SceneManager.LoadScene(FifthOne);
    }
}