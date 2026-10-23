using UnityEngine;

public class points : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (score.Instance != null)
            {
                score.Instance.Score(); 
            }
            Destroy(gameObject);
        }
    }
}
