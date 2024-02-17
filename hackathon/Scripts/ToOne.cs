using UnityEngine;
using UnityEngine.SceneManagement;

public class ToOne : MonoBehaviour
{
    public string Firstone = "Firstone";

    // Load the specified level
    public void OnToOneButtonClick()
    {
        SceneManager.LoadScene(Firstone);
    }
}