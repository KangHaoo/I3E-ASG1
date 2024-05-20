using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Lava : MonoBehaviour
{
    public int damageAmount = 2; // Damage amount per tick
    public float tickInterval = 10f; // Interval between damage ticks
    private float timer = 0f; // Timer to track interval
    private bool playerInsideLava = false; // Flag to track if player is inside the lava

    private void Update()
    {
        // If player is inside the lava, start counting the time
        if (playerInsideLava)
        {
            timer += Time.deltaTime;

            // Check if it's time for another damage tick
            if (timer >= tickInterval)
            {
                // Reset the timer
                timer = 0f;

                // Deal damage to the player
                DamagePlayer();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Player enters the lava, set the flag to true
            playerInsideLava = true;

            // Start damaging the player immediately
            DamagePlayer();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Player exits the lava, set the flag to false
            playerInsideLava = false;

            // Reset the timer
            timer = 0f;
        }
    }

    private void DamagePlayer()
    {
        // Deal damage to all objects within the trigger area
        Collider[] colliders = Physics.OverlapBox(transform.position, transform.localScale / 2f);
        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("Player"))
            {
                // If the collider belongs to a player, deal damage
                PlayerHealth playerHealth = collider.GetComponent<PlayerHealth>();
                if (playerHealth != null)
                {
                    playerHealth.TakeDamage(damageAmount);
                }
            }
        }
    }

    // For visualization purposes, you can draw the trigger area in the Scene view
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, transform.localScale);
    }
}
