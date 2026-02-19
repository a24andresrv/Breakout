using UnityEngine; 
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0); // Cargar la escena inicial (índice 0)
        }
    }
}