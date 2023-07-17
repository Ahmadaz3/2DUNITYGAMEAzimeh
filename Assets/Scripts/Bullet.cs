using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    //public bool win = false;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.right * 15f * Time.deltaTime);
    }
    public static int counter = 0;
    private bool collisionCounted = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (!collisionCounted && collision.gameObject.CompareTag("Ghost"))
        {
            Destroy(collision.gameObject);
            counter++;
            if(counter == 2)
            {
                int currentSceneindex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentSceneindex + 2);
            }
            Debug.Log(counter);
            Destroy(this.gameObject);
            collisionCounted = true;
        }
        Destroy(this.gameObject);
    }
}

    
