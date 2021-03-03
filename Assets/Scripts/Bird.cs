using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{  public GameManager gameManager;
    public float force;
    private new Rigidbody2D rigidbody2D;
    public AudioSource SoundJump;
    public AudioSource UpScore;
    public AudioSource Dead;
    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
       else
      {
           rigidbody2D.MoveRotation(rigidbody2D.velocity.y*5f);
      }
    }
    void Jump()
    {
        rigidbody2D.AddForce(Vector2.up * (force - rigidbody2D.velocity.y), ForceMode2D.Impulse);
        rigidbody2D.MoveRotation(rigidbody2D.velocity.y * 2F);
        SoundJump.Play();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "UpScore")
        {
            GameManager.score += 1;
            UpScore.Play();

        }
        if (collision.gameObject.tag == "Trump"|| collision.gameObject.tag == "Ground")
        {
            gameManager.DeadScrn();
            Dead.Play();
        }
    }
}
