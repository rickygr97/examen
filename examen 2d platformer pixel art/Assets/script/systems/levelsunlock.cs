using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelsunlock : MonoBehaviour
{
    public GameObject level2;
    public GameObject level3;
    public static int nummer;


    // Start is called before the first frame update
    void Start()
    {
        nummer = 1;
        if (PlayerPrefs.HasKey("nummer"))
        {
            nummer = PlayerPrefs.GetInt("nummer");

        }

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(nummer);

        switch (nummer)
        {
            case 1:
                break;
            case 2:
                level2.active = false;
                break;
            case 3:
                level3.active = false;
                break;

        }
    }
    public static void nummers(int nummererbij)
    {
        nummer += nummererbij;

    }
}
