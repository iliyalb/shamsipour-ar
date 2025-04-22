using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timing : MonoBehaviour
{
    float timeLeft = 10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        Screen.fullScreen = !Screen.fullScreen;

    }

    // Update is called once per frame
    void Update()
    {
        
        timeLeft -= Time.deltaTime;
        
        if (timeLeft <= 0)
        {


            StartCoroutine("Fade");
            
        }


    }
    void Fade()
    {
        GameObject.Find("Alert_Text").SetActive(false);
    }
}
