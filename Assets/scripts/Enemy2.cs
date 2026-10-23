using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public Transform enemy;
    public float speed = 2.5f;
    public float max_y = 3.76f;
    public float min_y = -4.52f;
    public bool move_up = false;
    private Rigidbody2D Rigidbody2D;
    public player Player;

    private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (move_up)
        {
            Rigidbody2D.MovePosition(Rigidbody2D.position + Vector2.up * speed * Time.deltaTime);
            if (transform.position.y >= max_y)
            {
                move_up = false;
            }
        }
        else
        {

            Rigidbody2D.MovePosition(Rigidbody2D.position + Vector2.down * speed * Time.deltaTime);
            if (transform.position.y <= min_y)
            {
                move_up = true;
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (score.Instance != null)
            {
                score.Instance.attack();
            }
            if (Player != null)
                Player.Respawn();

        }
    }

}
