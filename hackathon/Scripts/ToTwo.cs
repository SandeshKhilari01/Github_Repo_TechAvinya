using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTwo : MonoBehaviour
{
    public string SecondOne = "SecondOne";

    // Load the specified level
    public void OnToTwoButtonClick()
    {
        SceneManager.LoadScene(SecondOne);
    }
}