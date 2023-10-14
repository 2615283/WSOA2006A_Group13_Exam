using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigbody;
    private Vector2 inputMovement;

    private void Update()
    {
        inputMovement.x = Input.GetAxisRaw("Horizontal");
        inputMovement.y = Input.GetAxisRaw("Vertical");

        inputMovement.Normalize();

        rigbody.velocity = inputMovement * speed;
    }
}
