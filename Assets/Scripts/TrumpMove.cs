using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrumpMove : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * Time.deltaTime*1.5f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TriggerTrump")
        {
           
            float rndY = Random.Range(-3.5f, 1.5f);
            transform.position = new Vector2(10, rndY);
        }
    }
}
