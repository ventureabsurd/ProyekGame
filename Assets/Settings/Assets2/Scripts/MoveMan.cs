using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMan : MonoBehaviour
{
    private Rigidbody2D rb;
    private float dirX, moveSpeed;

    void Start(){

    rb = GetComponent<Rigidbody2D>();
    moveSpeed =  5f;

    }
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal") * moveSpeed;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, rb.velocity.y);
    }
        
}

