using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{

    void FixedUpdate()
    {
        transform.Translate(Vector2.left * Time.deltaTime*1.5f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            transform.position = new Vector2(9f, -4.5f);
        }
    }
}
