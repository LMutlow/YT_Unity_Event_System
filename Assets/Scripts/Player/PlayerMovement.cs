using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent (typeof(Player))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;

    private Player player = null;
    private Animator animator = null;
    private Rigidbody2D rb = null;

    private void Awake()
    {
        player = GetComponent<Player>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (player.isAlive)
        {
            if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
            {
                Walk(true);
            }
            else if (Input.GetKeyUp(KeyCode.D))
            {
                rb.velocity = new Vector2(0f, rb.velocity.y);
                animator.SetBool("isWalking", false);
            }

            if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            {
                Walk(false);
            }
            else if (Input.GetKeyUp(KeyCode.A))
            {
                rb.velocity = new Vector2(0f, rb.velocity.y);
                animator.SetBool("isWalking", false);
            }
        }
    }

    private void Walk(bool isRight)
    {
        animator.SetBool("isWalking", true);

        if (!isRight) transform.localScale = new Vector3(-1f, 1f, 1f);
        if (isRight) transform.localScale = new Vector3(1f, 1f, 1f);

        if (!isRight)
        {
            rb.velocity = new Vector2(-1f * moveSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(1f * moveSpeed, rb.velocity.y);
        }
    }
}