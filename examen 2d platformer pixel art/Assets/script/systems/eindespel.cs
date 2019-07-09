using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class eindespel : MonoBehaviour
{
    public levelsunlock levellocks;

    // Start is called before the first frame update
    void Start()
    {
        levellocks = GameObject.FindObjectOfType(typeof(levelsunlock)) as levelsunlock;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<player>())
        {
            //    levelsunlock.nummers(1);
            levelsunlock.nummer++;





            SceneManager.LoadScene(5);

            

        }
    }
}
