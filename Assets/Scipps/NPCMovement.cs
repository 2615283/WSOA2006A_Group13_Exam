using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public float speed = 5;

    private Rigidbody2D RB;

    public bool isWalk;

    public float walk;
    private float walkCount;
    public float stand;
    private float standCount;

    private int direction;

    private int lastDirection;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();

        walkCount = walk;
        standCount = stand;

        ChooseDirection();
    }

    // Update is called once per frame
    void Update()
    {
        if (isWalk == true)
        {
            walkCount -= Time.deltaTime;            

            switch (direction)
            {
                case 0:
                    RB.velocity = new Vector2(0, speed);

                    break;

                case 1:
                    RB.velocity = new Vector2(speed, 0);

                    break;

                case 2:
                    RB.velocity = new Vector2(0, -speed);

                    break;

                case 3:
                    RB.velocity = new Vector2(-speed, 0);

                    break;
            }

            if (walkCount < 0)
            {
                isWalk = false;
                standCount = stand;
            }
        }
        else
        {
            standCount -= Time.deltaTime;

            RB.velocity = Vector2.zero;

            if (standCount < 0)
            {
                ChooseDirection();
            }
        }

        UpdateAnims();
    }

    public void ChooseDirection()
    {
        direction = Random.Range(0, 4);
        isWalk = true;
        walkCount = walk;
    }

    private void UpdateAnims()
    {
        if (direction == 0 && RB.velocity != Vector2.zero)
        {
            anim.SetFloat("MoveX", 0);
            anim.SetFloat("MoveY", 1);
            anim.SetBool("isWalk", true);
        }
        else if (direction == 1 && RB.velocity != Vector2.zero)
        {
            anim.SetFloat("MoveX", 1);
            anim.SetFloat("MoveY", 0);
            anim.SetBool("isWalk", true);
        }
        else if (direction == 2 && RB.velocity != Vector2.zero)
        {
            anim.SetFloat("MoveX", 0);
            anim.SetFloat("MoveY", -1);
            anim.SetBool("isWalk", true);
        }
        else if (direction == 3 && RB.velocity != Vector2.zero)
        {
            anim.SetFloat("MoveX", -1);
            anim.SetFloat("MoveY", 0);
            anim.SetBool("isWalk", true);
        }
        else
        {
            anim.SetBool("isWalk", false);
        }
    }
}
