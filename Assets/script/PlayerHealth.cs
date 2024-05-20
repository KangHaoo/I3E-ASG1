using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;

    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public GameObject gameOverPanel ;


    void Start()
    {
        health = maxHealth;

       
    }
    //code to show takedamage and minus away the hp
    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
    //game over panel shows after death
            if (gameOverPanel != null)
            {
                gameOverPanel.SetActive(true);
            }
    //hide hearts after death
            foreach (Image heart in hearts)
            {
                heart.enabled = false;
            }

            Destroy(gameObject);
        }
    }

    void Update()
    {
        //show health for user by using ui
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
