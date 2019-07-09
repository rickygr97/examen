using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class einde : MonoBehaviour
{
    player player;
    //public Text textcoins;
    //public Image coins;
    public GameObject blok1;
    public GameObject blok2;
    public GameObject blok3;
    public GameObject blok4;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<player>();

    }

    // Update is called once per frame
    void Update()
    {
        //.text = "" + player.coins + " /8 ";
        //if(player.coins == 8)
        //{
        //    Destroy(blok1);
        //    Destroy(blok2);
        //    Destroy(blok3);
        //    Destroy(blok4);

        //}

    }
    public void end()
    {
        Destroy(blok1);
        Destroy(blok2);
        Destroy(blok3);
        Destroy(blok4);
    }
}
