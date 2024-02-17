using UnityEngine;
using UnityEngine.SceneManagement;

public class ToFour : MonoBehaviour
{
    public string FourthOne = "FourthOne";

    // Load the specified level
    public void OnToFourButtonClick()
    {
        SceneManager.LoadScene(FourthOne);
    }
}
