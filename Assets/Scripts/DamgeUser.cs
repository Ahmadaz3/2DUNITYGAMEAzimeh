using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamgeUser : MonoBehaviour
{
    Animator animator;
    MangeHealth mangeHealth;
    private void Start()
    {
        animator = GetComponent<Animator>();
        mangeHealth = FindObjectOfType<MangeHealth>();


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animator.SetBool("Damge", true);
            MainPlayerMovment playerScript = collision.GetComponent<MainPlayerMovment>();
            if (playerScript != null)
            {
                mangeHealth.takedamge();
                mangeHealth.UpdateHeart();
                playerScript.MoveToStartPosition();
            }

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("Damge", false);
    }
}
