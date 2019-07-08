using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hamburger : enemies
{
    public GameObject player;
    bool attackbool;
    public GameObject righthit;
    public GameObject lefthit;
    //public int health;




    public override void Start()
    {
        base.Start();
     startdis = 1.1f;
     enddis = 10;
     attackdis = 1.5f;
        //player = GetComponent<player>();
        // player = GameObject.FindObjectOfType<player>();
        player = GameObject.FindGameObjectWithTag("Player");
        righthit.gameObject.active = true;
        lefthit.gameObject.active = true;
        attackbool = true;
        health = 3;






}
    public override void Update()
    {
        base.Update();
        if (target.transform.position.x > this.gameObject.transform.position.x && facingleft == false)
        {
            flipcharacter();
        }
        if (target.transform.position.x < this.gameObject.transform.position.x && facingleft == true)
        {
            flipcharacter();
        }
        if (attackbool)
        {
            StartCoroutine(attacksplayer());

        }
        if (health <= 0)
        {
            Destroy(this.gameObject);

        }

    }
    //public override void flipcharacter()
    //{
    //    base.flipcharacter();
    //}
    public override void animationwalks()
    {
        base.animationwalks();
        an.SetBool("walks", true);
        
    }
    public override void animationwalks2()
    {
        base.animationwalks2();
        an.SetBool("walks", false);
        
    }
    public override void animationattack()
    {
        base.animationattack();
        an.SetBool("attacks", true);
        if(attackbool == true)
        {
            //player.GetComponent<player>().health--;
            righthit.gameObject.active = true;
            lefthit.gameObject.active = true;
            StartCoroutine(attacksplayer());

        }
        


    }
    public override void animationattack2()
    {
        base.animationattack2();
        an.SetBool("attacks", false);
    }
    IEnumerator attacksplayer()
    {
        attackbool = false;
        righthit.gameObject.active = false;
        lefthit.gameObject.active = false;


        yield return new WaitForSeconds(0.5f);
        attackbool = true;
        righthit.gameObject.active = true;
        lefthit.gameObject.active = true;

    }
}
