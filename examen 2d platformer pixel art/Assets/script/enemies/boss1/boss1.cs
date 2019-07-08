using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


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

        health -= Time.deltaTime;

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<player>())
        {
            col.gameObject.GetComponent<player>().health--;

        }
    }
}
