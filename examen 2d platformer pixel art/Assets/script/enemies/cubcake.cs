using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubcake : enemies
{
    public GameObject ise;
    public Transform iseposition;
    public int isespeed = 30;
    bool leftorright;
    bool spawn;




  public override void Start()
    {
        base.Start();
        startdis = 4.5f;
        enddis = 10;
        attackdis = 5;
        spawn = true;

    }
    public override void Update()
    {
        base.Update();
       // base.Update();
        if (target.transform.position.x < this.gameObject.transform.position.x && facingleft == false)
        {
            flipcharacter();
            leftorright = true;

        }
        if (target.transform.position.x > this.gameObject.transform.position.x && facingleft == true)
        {
            flipcharacter();
            leftorright = false;

        }
    }
    public override void animationwalks()
    {
        base.animationwalks();
        an.SetBool("walks", true);
        an.SetBool("idle", false);

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
        if(leftorright == false && spawn == true)
        {
            StartCoroutine(waitfornextspawnise());

            var isepre2 = Instantiate(ise, iseposition.position, Quaternion.identity);
            isepre2.GetComponent<Rigidbody2D>().velocity = Vector2.right * isespeed;
        }
        else if(leftorright == true && spawn == true)
        {
            StartCoroutine(waitfornextspawnise());

       var isepre =  Instantiate(ise, iseposition.position, Quaternion.identity);
        isepre.GetComponent<Rigidbody2D>().velocity = Vector2.left * isespeed;
        }


        an.SetBool("attacks", true);
        an.SetBool("idle", false);

    }
    public override void animationattack2()
    {
        base.animationattack2();
        an.SetBool("attacks", false);
        an.SetBool("idle", true);
    }
    IEnumerator waitfornextspawnise()
    {
        spawn = false;
        yield return new WaitForSeconds(0.5f);
        spawn = true;

    }
}
