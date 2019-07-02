using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidermovecamera2 : MonoBehaviour
{
    public float yhight;
    public camera camara;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onTriggerExit(Collider2D col)
    {
        if (col.gameObject.GetComponent<player>())
        {
            Debug.Log("hi");
            var oldpos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.y);

            var newpos = new Vector3(this.transform.position.x, yhight, this.transform.position.z);
            camara.transform.position = Vector3.Lerp(this.transform.position, newpos, 10);
            StartCoroutine(waitforon());

        }
    }
    IEnumerator waitforon()
    {
        this.gameObject.SetActive(false);

        yield return new WaitForSeconds(1);

        this.gameObject.SetActive(true);

    }
}
