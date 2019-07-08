using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class milkshake : enemies
{
   // public int health;

    public override void Start()
    {
        base.Start();
        startdis = 4.5f;
        enddis = 10;
        attackdis = 5;
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
        if(health <= 0)
        {
            Destroy(this.gameObject);

        }
    }
    public override void animationwalks()
    {
        base.animationwalks();
        an.SetBool("walks", true);

    }
    public override void animationwalks2()
    {
        base.animationwalks2();
        an.SetBool("walks", false);
        an.SetBool("idle", true);

    }
    public override void animationattack()
    {
        base.animationattack();
        an.SetBool("attacks", true);
    }
    public override void animationattack2()
    {
        base.animationattack2();
        an.SetBool("attacks", false);
        an.SetBool("idle", true);
    }
}
