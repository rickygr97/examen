using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveing_platform : MonoBehaviour
{
    public Transform startpos;
    public Transform endpos;
    public int speed;
    //bool endposdone;
    //bool startposdone;
    //bool waittime;
    Vector3 nextpos;






    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
        //endposdone = false;
        //startposdone = false;
        //waittime = true;
        nextpos = startpos.position;





    }

    // Update is called once per frame
    void Update()
    {
       float dis = Vector2.Distance(startpos.position, endpos.position);

        //if(dis > 1 && endposdone == true)
        //{
        //    //ga naar de endpos of startpos.
        //    this.transform.position = Vector2.MoveTowards(this.transform.position, endpos.position, speed * Time.deltaTime);

        //}
        //if(dis > 3 && startposdone == true)
        //{
        //    //stop en ga weer naar startpos.

        //    this.transform.position = Vector2.MoveTowards(this.transform.position, startpos.position, speed * Time.deltaTime);
        //}
        //if (waittime)
        //{
        //    StartCoroutine(waitfornextpos());

        //}
        if(transform.position == startpos.position)
        {
            nextpos = endpos.position;

        }
        if(transform.position == endpos.position)
        {
            nextpos = startpos.position;

        }
        transform.position = Vector3.MoveTowards(transform.position, nextpos, speed * Time.deltaTime);

    }
    //IEnumerator waitfornextpos()
    //{
    //    waittime = false;

    //    endposdone = true;
    //    startposdone = false;

    //    yield return new WaitForSeconds(1);
    //    startposdone = true;
    //    endposdone = false;
    //    waittime = true;



    //}
}
