using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAnimator : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateChasePlayer(bool chasing) {
        anim.SetBool("following", chasing);
        anim.SetBool("attacking", false);
        anim.SetBool("patrol", false);
      
       
    }


    public void UpdateAttack(bool attacking) {
        anim.SetBool("attacking", attacking);
        anim.SetBool("following", false);
        anim.SetBool("patrol", false);


    }

    public void UpdatePatrol(bool patrol)
    {
        anim.SetBool("patrol", patrol);
        
        anim.SetBool("following", false);
        anim.SetBool("attacking", false);
    }
}
