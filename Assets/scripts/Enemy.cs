using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform enemy;
    public float speed = 2.5f;
    public float max_x = 3.89f;
    public float min_x = -4.34f;
    public bool move_right = false;
    private Rigidbody2D Rigidbody2D;
    public player Player;

    private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (move_right)
        {
            Rigidbody2D.MovePosition(Rigidbody2D.position + Vector2.right * speed * Time.deltaTime);
            if (transform.position.x >= max_x)
            {
                move_right = false;
            }
        }
        else
        {

            Rigidbody2D.MovePosition(Rigidbody2D.position + Vector2.left * speed * Time.deltaTime);
            if (transform.position.x <= min_x)
            {
                move_right = true;
            }
        }
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(score.Instance != null)
            {
                score.Instance.attack();
            }
            Player.Respawn();

        }
    }

}
