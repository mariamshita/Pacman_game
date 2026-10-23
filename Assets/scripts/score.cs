using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

//using UnityEngine.UIElements;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static score Instance;
    public TextMeshProUGUI Score_TEXT;
    public static int live_num = 3;
    public static int current_score ;
    public Image l1;
    public Image l2;
    public Image l3;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        if (Score_TEXT != null)
        Score_TEXT.text = current_score.ToString();
        if (l1 != null) l1.enabled = live_num >= 3; 
        if (l2 != null) l2.enabled = live_num >= 2;
        if (l3 != null) l3.enabled = live_num >= 2;
    }

    public void Score()
    {
        current_score += 10;
        if (Score_TEXT != null)
        Score_TEXT.text = current_score.ToString();

        if (current_score == 3350)
        {
            SceneManager.LoadScene("Level2");
        }

        if (current_score >= 6702)
        {
            SceneManager.LoadScene("Winner");
        }
    }

    public void attack()
    {
        StartCoroutine(Attack());
    }

    private IEnumerator Attack()
    {
        if (l1 != null && l2 != null && l3 != null)
        {
            if (live_num <= 0) yield break;
            live_num -= 1;
            if (live_num == 2)
            {
                l1.enabled = false;
            }
            else if (live_num == 1)
            {
                l2.enabled = false;
            }
            else if (live_num == 0)
            {
                l3.enabled = false;
                yield return new WaitForSeconds(1);
                SceneManager.LoadScene("GameOver");
            }
        }

    
}
        
}
