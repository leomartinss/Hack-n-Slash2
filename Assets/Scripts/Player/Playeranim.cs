using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playeranim : MonoBehaviour
{
    public Player playerjump;
    public Animator anim;



    void Start()
    {
        playerjump = GetComponent<Player>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        AnimaRun();

    }

    void AnimaRun()
    {
        if (playerjump.isGround == false)
        {
            anim.SetBool("jump", true);
            anim.SetBool("move", false);
        }
        else if (playerjump.isGround == true)
        {
            anim.SetBool("jump", false);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            anim.SetBool("move", true);
        }
        else
        {
            anim.SetBool("move", false);
        }
    }
}
