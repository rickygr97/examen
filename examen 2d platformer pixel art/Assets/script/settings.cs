using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class settings : MonoBehaviour
{
    public AudioMixer audiomixer;
    Resolution[] resolutions;
    public Dropdown resdropdown;



    public void setvolume(float sounds)
    {
        Debug.Log(sounds);
        audiomixer.SetFloat("sounds", sounds);

    }
    public void setgrafics(int graficsnumber)
    {
        QualitySettings.SetQualityLevel(graficsnumber);

    }
    public void setscreen(bool screen)
    {
        Screen.fullScreen = screen;

    }
    public void setres(int resnumber)
    {
        Resolution res = resolutions[resnumber];

        Screen.SetResolution(res.width, res.height, Screen.fullScreen);

    }
    // Start is called before the first frame update
    void Start()
    {
       resolutions = Screen.resolutions;
        resdropdown.ClearOptions();
       // resdropdown.AddOptions();
        List<string> options = new List<string>();
        int curresnumber = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);
            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                curresnumber = i;

            }

        }
        resdropdown.AddOptions(options);
        resdropdown.value = curresnumber;
        resdropdown.RefreshShownValue();



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
