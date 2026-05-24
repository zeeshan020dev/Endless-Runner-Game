using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class MainMenu : MonoBehaviour
{
    //public TextMeshProUGUI highScoreText;
    //public TextMeshProUGUI gemsText;

    //public Animator messageAnim;

    private void Start()
    {
        Time.timeScale = 1;
    }
    
    public void PlayGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}