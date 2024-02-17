using UnityEngine;
using UnityEngine.SceneManagement;

public class ToThree : MonoBehaviour
{
    public string ThirdOne = "ThirdOne";

    // Load the specified level
    public void OnToThreeButtonClick()
    {
        SceneManager.LoadScene(ThirdOne);
    }
}