using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform playerposition;
    //bool golow;
    //bool gohigh;
    //bool gogrond;




    // Start is called before the first frame update
    void Start()
    {
        //golow = true;
        //gohigh = true;
        //gogrond = true;



    }

    // Update is called once per frame
    void Update()
    {
        var newpos = new Vector3(playerposition.position.x, this.transform.position.y, this.transform.position.z);
        this.transform.position = Vector3.Lerp(this.transform.position, newpos, 1);

        //float dis = Vector2.Distance(transform.position, playerposition.position);
        //var posy = new Vector3(transform.position.x, playerposition.position.y, transform.position.z);

        //if(posy.y <= -6 && golow && gohigh ==false&& gogrond ==false)
        //{
        //    golow = false;
        //    gohigh = false;
        //    gogrond = true;



        //    var newpos1 = new Vector3(playerposition.position.x, this.transform.position.y -10, this.transform.position.z);
        //    this.transform.position = Vector3.Lerp(this.transform.position, newpos1, 1);
        //}
        //if(posy.y >= -6 && gogrond && gohigh==false && golow ==false)
        //{
        //    gogrond = false;
        //    golow = true;
        //    gohigh = true;

        //    var newpos3 = new Vector3(playerposition.position.x, this.transform.position.y + 10, this.transform.position.z);
        //    this.transform.position = Vector3.Lerp(this.transform.position, newpos3, 1);
        //}
        //if (posy.y >= 4.5 && gohigh && golow ==false&& gogrond ==false)
        //{
        //    gohigh = false;
        //    golow = false;
        //    gogrond = true;



        //    var newpos2 = new Vector3(playerposition.position.x, this.transform.position.y + 10, this.transform.position.z);
        //    this.transform.position = Vector3.Lerp(this.transform.position, newpos2, 1);
        //}
        //if(posy.y <= 4.5 && gogrond && golow == false&& gohigh == false)
        //{
        //    gogrond = false;
        //    golow = true;
        //    gohigh = true;

        //    var newpos4 = new Vector3(playerposition.position.x, this.transform.position.y - 10, this.transform.position.z);
        //    this.transform.position = Vector3.Lerp(this.transform.position, newpos4, 1);
        //}
    }
}
