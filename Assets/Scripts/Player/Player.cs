using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isAlive = true;

    [SerializeField] private float health = 100f;

    private void TakeDamage(float damageTaken)
    {
        health -= damageTaken;
        if(health <= 0)
        {
            health = 0;
            isAlive = false;
            // TODO: OnDeath
        }

        // TODO: Update HP bar
    }
}