using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 40f;
    float horizontalMove = 0f;
    float verticalMove = 0f;
    public Rigidbody2D player;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        verticalMove = Input.GetAxisRaw("Vertical") * speed;
    }

    void FixedUpdate()
    {
        player.AddForce(new Vector2(horizontalMove,verticalMove));
    }
}
