using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
}
