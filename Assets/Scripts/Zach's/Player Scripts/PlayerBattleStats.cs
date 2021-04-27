using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBattleStats : MonoBehaviour
{
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
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerHealth();
    }

    private void PlayerHealth() {
        health = 100;
        if (damageTaken)
        {
            TakeDamage();
        }
        else if (!damageTaken) {
            
        }
    }
    private void DealDamage() {

    }
    private void TakeDamage()
    {
        amountOfDamageTaken = 1;
    }
    }
