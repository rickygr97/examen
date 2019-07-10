using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pause : MonoBehaviour
{
    public Canvas canvaspause;
    public Canvas canvasmain;
    bool pausese;



    // Start is called before the first frame update
    void Start()
    {
        canvaspause.enabled = false;
        pausese = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&& pausese)
        {
            Time.timeScale = 0;
            canvaspause.enabled = true;
            canvasmain.enabled = false;
            pausese = false;




        }else if(Input.GetKeyDown(KeyCode.Escape)&& pausese == false)
        {
            Time.timeScale = 1;
            canvaspause.enabled = false;
            canvasmain.enabled = true;
            pausese = true;

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
    public void option()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);

    }
}
