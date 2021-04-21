using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public enum AIState { PATROL, ATTACKING, FOLLOW};

    public AIState state = AIState.PATROL;

    public NavMeshAgent agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    public float health;

    //Patrolling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //Attacking
    public float timeBetweenAttacks;
    bool alreadyAttacked;
    public GameObject projectile;

    //States
    public float sightRange, attackRange;


    Animator anim;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();
    }


    private void Update()
    {
        //Check for sight and attack range
        switch (state)
        {
            case AIState.PATROL:
                Patrol();
                break;

            case AIState.FOLLOW:
                ChasePlayer();
                break;

            case AIState.ATTACKING:
                AttackPlayer();
                break;
        }

    }

    #region States
    private void Patrol()
    {
        //handle animation and speed
        agent.speed = 1;
        anim.SetFloat("vertical", .5f);

        if (!walkPointSet)
        {
            SearchWalkPoint();
        } else { 
            agent.SetDestination(walkPoint);
        }

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        //Walkpoint reached 
        if (distanceToWalkPoint.magnitude < 1f)
        {
            walkPointSet = false;
        }

        //state switch
        if (Physics.CheckSphere(transform.position, sightRange, whatIsPlayer)){
            state = AIState.FOLLOW;
        }
    }

    private void ChasePlayer()
    {
        //handle animation and speed
        agent.speed = 6;
        anim.SetFloat("vertical", 1f);

        agent.SetDestination(player.position);


        //state switch
        if(Physics.CheckSphere(transform.position, attackRange, whatIsPlayer))
        {
            state = AIState.ATTACKING;
        }
        else if (!Physics.CheckSphere(transform.position, sightRange, whatIsPlayer)){
            state = AIState.PATROL;
        }
    }

    private void AttackPlayer()
    {

        //handle animation and speed
        agent.speed = 1f;


        //make sure enemy doesn't move
        agent.SetDestination(transform.position);

        transform.LookAt(player);

        if (!alreadyAttacked)
        {
            ///AttackCode here
           // Rigidbody rb = Instantiate(projectile, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            //rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            //rb.AddForce(transform.up * 8f, ForceMode.Impulse);

            ///

            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }

        if (!Physics.CheckSphere(transform.position, attackRange, whatIsPlayer))
        {
            state = AIState.FOLLOW;
        }
    }
    #endregion


    #region HelperMethods
    private void SearchWalkPoint()
    {
        //Calculate random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
            walkPointSet = true; 
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0) Invoke(nameof(DestroyEnemy), 0.5f);
    }
    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }

    #endregion

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }
}

 