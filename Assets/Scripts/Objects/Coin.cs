using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int coinValue = 1; // The value that the coin is worth

    /// <summary>
    /// On trigger enter we check if we hit the player and if so we collect the coin, send a message and destroy the game object
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Player>() != null)
        {
            // TODO: Event coin collected
            Destroy(gameObject);
        }
    }
}
