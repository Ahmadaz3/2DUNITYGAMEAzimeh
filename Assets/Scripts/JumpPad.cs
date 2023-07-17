using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    private float Force = 20f;
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
         collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up*Force,ForceMode2D.Impulse);
            collision.gameObject.GetComponent<Animator>().SetBool("grounded", false);
        }
    }
}
