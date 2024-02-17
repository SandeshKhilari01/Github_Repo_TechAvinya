using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSix : MonoBehaviour
{
    public string SixthOne = "SixthOne";

    // Load the specified level
    public void OnToSixButtonClick()
    {
        SceneManager.LoadScene(SixthOne);
    }
}