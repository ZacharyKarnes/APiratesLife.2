using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSheathingBehaviour : StateMachineBehaviour
{
    public string targetBool;
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool(targetBool, false);
    }
}
