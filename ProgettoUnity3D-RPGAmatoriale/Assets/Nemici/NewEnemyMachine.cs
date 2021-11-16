using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewEnemyMachine : MonoBehaviour
{
    public EnemyLF meEnemy;
    public float pullRadius = 35;
    public float aggroRadius = 55;
    public bool isRanged;

    Transform target;
    NavMeshAgent agent;

    public enum EnemyState
    {
        IDLE,
        FOLLOWING,
        ATTACKING,
        DEATHANIMATION
    }

    public EnemyState State;

    void Awake ()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.Player.transform;
        agent = GetComponent<NavMeshAgent>();
        State = EnemyState.IDLE;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        switch (State)
        {
            case (EnemyState.IDLE):
                if (distance <= pullRadius)
                {
                    State = EnemyState.FOLLOWING;
                }

                if (distance <= aggroRadius && meEnemy.cur_lifepoints != meEnemy.lifepoints)
                {
                    State = EnemyState.FOLLOWING;
                }
                break;

            case (EnemyState.FOLLOWING):
                transform.LookAt(target);
                agent.SetDestination(target.position);
                break;

            case (EnemyState.ATTACKING):
                break;

            case (EnemyState.DEATHANIMATION):
                break;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, pullRadius);
    }

    void OnDrawGizmosSelectedAggro()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, aggroRadius);
    }

    void AttackingMelee()
    {

    }

    void AttackingRanged()
    {

    }
}
