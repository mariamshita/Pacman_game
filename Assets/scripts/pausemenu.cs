using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public GameObject panal;

    private void Awake()
    {
        panal.SetActive(false);
    }

    public void pause()
    {
        panal.SetActive(true);
        Time.timeScale = 0;
    }

    public void restart()
    {
        panal.SetActive(false);
        score.current_score = 0;
        score.live_num = 3;
        Time.timeScale = 1;
        SceneManager.LoadScene("Level1");
    }


    public void play()
    {
        panal.SetActive(false);
        score.current_score = 0;
        score.live_num = 3;
        Time.timeScale = 1;
        SceneManager.LoadScene("Level1");
    }


    public void resume()
    {
        panal.SetActive(false);
        Time.timeScale = 1;
    }

    public void exit()
    {
        Application.Quit();
    }
}
