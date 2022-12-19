using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour
{
    public void RestartGame()
    {
        // Load the scene with the name "NextScene"
        SceneManager.LoadScene("Level01");
    }
}