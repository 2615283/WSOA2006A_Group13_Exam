using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigbody;
    private Vector3 inputMovement;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        inputMovement = Vector3.zero;

        inputMovement.x = Input.GetAxisRaw("Horizontal");
        inputMovement.y = Input.GetAxisRaw("Vertical");

        

        rigbody.velocity = inputMovement * speed;

        UpdateAnims();
    }

    private void UpdateAnims()
    {
        if (inputMovement != Vector3.zero)
        {
            anim.SetFloat("Xmove", inputMovement.x);
            anim.SetFloat("Ymove", inputMovement.y);
            anim.SetBool("move", true);
        }
        else
        {
            anim.SetBool("move", false);
        }
    }
}
