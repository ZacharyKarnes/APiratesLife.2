using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStats : MonoBehaviour
{
  


    public int enemyHealth;
    public int damageDealt = 0;
    public int playerHealth = 100;
    public bool isPlayerAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerLife();
    }

    private void PlayerLife() {
        if (playerHealth == 0) {
            isPlayerAlive = false;
        } else if(playerHealth != 0){
            isPlayerAlive = true;
        }
    }
}
