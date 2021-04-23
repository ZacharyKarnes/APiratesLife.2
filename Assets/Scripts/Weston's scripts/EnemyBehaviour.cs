
using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{
    NavMeshAgent agent;

    public Transform target;
    /*If you need guidance see the manual.txt, and if that didn't help you can email me at gustavbok@gmail.com!*/

    /*Here you can add and remove states for the enemy, see the manual.txt for guidance!*/
    public enum EnemyState
    {
        initializing,
        idle,
        sawPlayer,
        chasing,
        attacking,
        fleeing
    }
    /*This is the currentState of the Enemy, this is what you'll change in the child-Class*/
    public EnemyState currentState;

    public GameObject playerReference;

    void Start()
    {
        currentState = EnemyState.initializing;
        agent = GetComponent<NavMeshAgent>();
    }

    /*In here there is a switch-statement which handles which method that is going
    * to be updating, this is chosen by the currentState of the enemy.
     It is in here that you will add your own EnemyState.yourState-case and call for your own method below*/
    public virtual void Update()
    {

        switch (currentState)
        {
            case EnemyState.initializing:
                /*filling in the player reference for easier access*/
                playerReference = GameObject.Find("Player");
                currentState = EnemyState.idle;
                break;
            case EnemyState.idle:
                Idle();
                break;
            case EnemyState.chasing:
                Follow();
                break;
            case EnemyState.attacking:
                Attacking();
                break;
            case EnemyState.fleeing:
                Fleeing();
                break;
            default:
                break;
        }
    }

    /*When you add your own methods here they need to be virtual, this is so you can in override them in your own
     class*/

    public virtual void Idle()
    {

        agent.Move(target.position);

    }
    
    public virtual void Follow()
    {
    }
    public virtual void Attacking()
    {
    }
    public virtual void Fleeing()
    {
    }
}
