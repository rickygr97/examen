﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    public GameObject splash;
    player player;


    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.GetComponent<player>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<enemies>())
        {
            col.gameObject.GetComponent<enemies>().health--;
           var clone =  Instantiate(splash,col.gameObject.transform.position,Quaternion.identity);
            Destroy(clone, 0.4f);
            Destroy(this.gameObject);
           player.gameObject.GetComponent<player>().smak();






            

        }
        if(col.gameObject.GetComponent<boss1>())
        {
col.gameObject.GetComponent<boss1>().health--;
            var clone = Instantiate(splash,col.gameObject.transform.position,Quaternion.identity);
            Destroy(clone, 0.4f);
            Destroy(this.gameObject);
           player.gameObject.GetComponent<player>().smak();


           

        }
    }
}
