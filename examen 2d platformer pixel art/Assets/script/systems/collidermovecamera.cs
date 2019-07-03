using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidermovecamera : MonoBehaviour
{
    public float yhight;
    public camera camara;
    public GameObject player;
   public bool locks;
    public camera cameras;





    // Start is called before the first frame update
    void Start()
    {
        //locks = false;
        cameras = GetComponent<camera>();


    }

    // Update is called once per frame
    void Update()
    {
        //var newpos = new Vector3(this.transform.position.x, yhight, this.transform.position.z);
        //this.transform.position = Vector3.Lerp(this.transform.position, newpos, 1);
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<player>())
        {
            Debug.Log("hi");
            var oldpos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.y);

            var newpos = new Vector3(this.transform.position.x, yhight, this.transform.position.z);
            camara.transform.position = Vector3.Lerp(this.transform.position, newpos, 10);
            //if(player.transform.position.y != newpos.y)
            //{
            //    camara.transform.position = Vector3.Lerp(this.transform.position, oldpos, 0.05f);
            //}
            if (locks)
            {
                camara.GetComponent<camera>().lockcamera = true;
                camara.GetComponent<camera>().playerfollow = false;

            }if(locks == false)
            {
                camara.GetComponent<camera>().lockcamera = false;
                camara.GetComponent<camera>().playerfollow = true;
            }
        }
    }
}
