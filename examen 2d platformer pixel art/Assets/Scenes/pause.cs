using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pause : MonoBehaviour
{
    public Canvas canvaspause;
    public Canvas canvasmain;


    // Start is called before the first frame update
    void Start()
    {
        canvaspause.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            canvaspause.enabled = true;
            canvasmain.enabled = false;



        }
    }
   public void contiue()
    {
        Time.timeScale = 1;

        canvaspause.enabled = false;
        canvasmain.enabled = true;

    }
    public void mainmenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);

    }
}
