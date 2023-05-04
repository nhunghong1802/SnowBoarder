
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void OnMenuButtonClicked()
    {
        SceneManager.LoadScene(0);
    }
    
}
