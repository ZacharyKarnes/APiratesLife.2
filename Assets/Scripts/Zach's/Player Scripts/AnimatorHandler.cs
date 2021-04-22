using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class AnimatorHandler : MonoBehaviour

{

    public Animator anim;
    
        



    public bool canRotate = true;
    public bool daggerDrawn = false;
    public bool swordDrawn = false;



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

       

        anim.SetBool("RightA", RAttacking);
        

    }
   
    public void UpdateLAttack(bool LAttacking)
    {
        
        anim.SetBool("LeftA", LAttacking);
       
    }


    public void UpdateDodge(bool dodging) {
        anim.SetBool("Dodge", dodging);
        
        
        

    }

    public void UpdateAttack(bool attacking) {
        anim.SetBool("Attacking", attacking);
    }

    public void UpdateDeath(bool death) {
        anim.SetBool("Dead", death);
    }
}