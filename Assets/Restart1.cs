using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart1 : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
