using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isAlive = true;

    [SerializeField] private float health = 100f;

    public void TakeDamage(float damageTaken)
    {
        health -= damageTaken;
        if(health <= 0)
        {
            health = 0;
            isAlive = false;
            // TODO: OnDeath
        }

        Debug.Log("Player damaged " + damageTaken + " points, remaining health is " + health);
        // TODO: Update HP bar
    }
}