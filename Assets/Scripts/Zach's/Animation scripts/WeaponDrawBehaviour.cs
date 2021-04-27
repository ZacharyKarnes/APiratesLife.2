using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDrawBehaviour : StateMachineBehaviour
{
    public string targetBool;
    
   override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
   {
        animator.SetBool(targetBool, true);
       
        
   }


}
