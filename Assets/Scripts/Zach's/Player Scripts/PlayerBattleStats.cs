using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBattleStats : MonoBehaviour
{

    private AnimatorHandler animatorHandler;


    //player variables
    public int health;
    public int stamina;


    //damage variables
    public bool damageTaken;
    public int amountOfDamageTaken;
    public bool damageDealt;
    public int amountOfDamageDealt;
    // Start is called before the first frame update
    void Start()
    {
        animatorHandler = GetComponentInChildren<AnimatorHandler>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

