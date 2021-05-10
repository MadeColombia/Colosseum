using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    public float  lookRadius = 10f;

    Transform target;
    NavMeshAgent agent;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
            animator.SetBool("IsRunning", true);

            if (distance <= agent.stoppingDistance){

                
               
                //Attack the target
                //Face the target
                FaceTarget();

                

            }

            else if (agent.stoppingDistance < 5)
            {
                animator.SetBool("IsRunning", false);
            }
        }
        
    }

    

    void FaceTarget(){
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    void OnDrawGizmosSelected(){

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
