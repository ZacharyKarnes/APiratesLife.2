﻿using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class AnimatorHandler : MonoBehaviour

{

    private Animator anim;



    public bool canRotate = true;



    public void Initialize()

    {

        anim = GetComponentInChildren<Animator>();

    }



    public void UpdateAnimatorValues(float vMov, float hMov)

    {

        anim.SetFloat("vertical", vMov, .1f, Time.deltaTime);



    }



    public void StopRotation()

    {

        canRotate = false;

    }



    public void StartRotation()

    {

        canRotate = true;

    }



    public void UpdateJump(bool jumping)

    {

        anim.SetBool("Jump", jumping);

    }
    public void UpdateRAttack(bool RAttacking) {

        Debug.Log("SUCCESS");

        anim.SetBool("RightA", RAttacking);
    }
    public void UpdateLAttack(bool LAttacking)
    {
        anim.SetBool("LeftA", LAttacking);
    }
}