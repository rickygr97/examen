using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : StateMachineBehaviour
{
    public float timer;
    public float mintime;
    public float maxtime;
    private Transform playerpos;
    public int speed;
   Rigidbody2D rb;
    int jumps = 10;




    //animatie maken op een plek en in script laten springen
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer = Random.Range(mintime, maxtime);
        playerpos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        //rb.gameObject.GetComponent<Rigidbody2D>();

        rb = GameObject.FindGameObjectWithTag("boss1").GetComponent<Rigidbody2D>();
rb.velocity = Vector2.up * jumps;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(timer <= 0)
        {
            animator.SetTrigger("idle");

        }
        else
        {
            timer -= Time.deltaTime;

        }
        Vector2 player = new Vector2(playerpos.position.x, animator.transform.position.y);
        animator.transform.position = Vector2.MoveTowards(animator.transform.position, player, speed * Time.deltaTime);
        


    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Implement code that processes and affects root motion
    }

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
