using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class boss1 : MonoBehaviour
{
   public Slider slider;
    public float health;


    // Start is called before the first frame update
    void Start()
    {
        slider.value = health;

    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health;

       // health -= Time.deltaTime;
       if(health <= 0)
        {

            SceneManager.LoadScene(0);

            Destroy(this.gameObject);

        }

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<player>())
        {
            col.gameObject.GetComponent<player>().health--;

        }
    }
}
