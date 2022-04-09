using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    [SerializeField] private float damagePerTick = 35f; // How much damage will be applied to the player per tick
    private Coroutine damageCoroutine = null; // Ref to the damage coroutine to stop if needed

    /// <summary>
    /// Starts the damage tick when the player enters the trigger
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Player>() != null)
        {
            damageCoroutine = StartCoroutine(DamageOverTime(collision.GetComponent<Player>()));
        }
    }

    /// <summary>
    /// Stops the damage tick when the player leaves the lava
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
        {
            if (damageCoroutine != null) StopCoroutine(damageCoroutine);
        }
    }

    /// <summary>
    /// Damages the player every 0.5s using the collision player as a reference meaning we dont need an event
    /// </summary>
    /// <param name="player"></param>
    /// <returns></returns>
    private IEnumerator DamageOverTime(Player player)
    {
        while (player.isAlive)
        {
            yield return new WaitForSeconds(1f);
            player.TakeDamage(damagePerTick);
        }
    }
}
