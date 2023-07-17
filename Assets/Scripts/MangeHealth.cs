using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MangeHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public int numofHearts;
    public Image[] hearts;
    public Sprite fullheart;
    public Sprite emptyHeart;
    void Start()
    {
        numofHearts = 4;
        health = 4;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHeart();
    }
   public void takedamge()
    {
        health--;
    }
    public void heal()
    {
        if(health<numofHearts)
        {
            health++;
        }
        
    }
    public void UpdateHeart()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < numofHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
            if (i < health)
            {
                hearts[i].sprite = fullheart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
        }
    }
}
