using UnityEngine;
using UnityEngine.SceneManagement;

public class meanm : MonoBehaviour
{
    public void play()
    {
        score.current_score = 0;
        score.live_num = 3;
        SceneManager.LoadScene("Level1");
    }


    public void exit()
    {
        Application.Quit();
    }

    public void restart()
    {
        score.current_score = 0;
        score.live_num = 3;
        SceneManager.LoadScene("Level1");
    }
}

