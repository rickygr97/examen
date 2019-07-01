using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hamburger : enemies
{
    public override void Start()
    {
        base.Start();
     startdis = 1.1f;
     enddis = 10;
     attackdis = 1.5f;
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
    }
    public override void animationattack2()
    {
        base.animationattack2();
        an.SetBool("attacks", false);
    }
}
