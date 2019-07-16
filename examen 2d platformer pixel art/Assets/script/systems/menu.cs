using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class menu : MonoBehaviour
{
    public Canvas canvas;
    public Canvas canvas1;

    // Start is called before the first frame update
    void Start()
    {
        canvas.enabled = false;
        canvas1.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void klick(int sceneint)
    {
        SceneManager.LoadScene(sceneint);

    }
    public void quit()
    {
        quit();

    }
    public void options()
    {
        SceneManager.LoadScene(2);

    }
    public void uitleg()
    {
        canvas.enabled = true;

    }
    public void uitleg1()
    {
        canvas1.enabled = true;
    }
}
