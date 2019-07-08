using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class time : MonoBehaviour
{
    public static float timer;
    public Text time_text;



    // Start is called before the first frame update
    void Start()
    {
        timer = 300;

    }

    // Update is called once per frame
    void Update()
    {
        //time_text.text = "time left "+ timer;
        time_text.text = "time left " + Mathf.RoundToInt(timer).ToString();
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            timer = 0;

            SceneManager.LoadScene(0);

            //af
            Debug.Log("af");

        }
    }
}
