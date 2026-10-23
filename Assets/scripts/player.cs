using NUnit.Framework.Constraints;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    public float speed = 3;
    private Collider2D Collider2D;
    private Rigidbody2D Rigidbody2D;
    private Vector3 direction = Vector3.forward;
    private SpriteRenderer SpriteRenderer;
    private Vector3 start_position;
    public AudioClip respawnn;
    private void Awake()
    {
        Collider2D = GetComponent<Collider2D>();
        Rigidbody2D = GetComponent<Rigidbody2D>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        start_position = transform.position;
}

    private void FixedUpdate()
    {
       
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            direction = Vector3.right; 
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            direction = Vector3.left;
        }
        if (Keyboard.current.upArrowKey.isPressed)
        {
            direction = Vector3.up;
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            direction = Vector3.down;  
        }
        

        transform.position = transform.position + direction * speed * Time.deltaTime;

    }

    public void Respawn()
    {
        AudioSource.PlayClipAtPoint(respawnn, transform.position);
        StartCoroutine(respawn());
    }

    private IEnumerator respawn()
    {
        SpriteRenderer.enabled = false;
       
        Collider2D.enabled = false;
        Rigidbody2D.linearVelocity = Vector2.zero;
        Rigidbody2D.simulated = false;
        this.enabled = false;

        yield return new WaitForSeconds(1.5f);

        transform.position = start_position;
        Rigidbody2D.linearVelocity = Vector2.zero;
        Rigidbody2D.simulated = true;

        SpriteRenderer.enabled = true;
        Collider2D.enabled = true;
        this.enabled = true;

    }
}
