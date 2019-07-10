using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    public GameObject splash;

    // Start is called before the first frame update
    void Start()
    {
        
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
            Instantiate(splash,col.gameObject.transform.position,Quaternion.identity);

            



            Destroy(this.gameObject);

        }
        if(col.gameObject.GetComponent<boss1>())
        {
col.gameObject.GetComponent<boss1>().health--;
            Instantiate(splash,col.gameObject.transform.position,Quaternion.identity);

            Destroy(this.gameObject);

        }
    }
}
