﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    player player;
   // sounds soundss;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<player>();
       // soundss = GetComponent<sounds>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<player>())
        {
            col.gameObject.GetComponent<player>().coins += 1;
           // soundss.coins();
            this.gameObject.GetComponent<sounds>().coins();



            //player.coins += 1;
            Destroy(this.gameObject);
            Debug.Log("ti");

        }
    }
}
