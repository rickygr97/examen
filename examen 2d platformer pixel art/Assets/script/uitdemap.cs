using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uitdemap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<player>())
        {
            col.gameObject.GetComponent<player>().health--;
            Debug.Log("af");
        }
    }
    //void OnColliderEnter2D(Collision2D col)
    //{
    //    if (col.gameObject.GetComponent<player>())
    //    {
    //        col.gameObject.GetComponent<player>().health -= 3;
    //        Debug.Log("af");

    //    }
    //}
}
