using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrollview_close : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameObject.FindWithTag("Scroll_tag").SetActive(false);
        }
    }

}
