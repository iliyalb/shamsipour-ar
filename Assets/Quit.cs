using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{

    private bool isQuiting;
    public GameObject quitMessageGameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isQuiting == true)
        {
            if (Input.GetKeyDown (KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Escape pressed time 02");
                Application.Quit(); 
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Escape pressed time 01");
            quitMessageGameObject.SetActive(true);
            isQuiting = true;
            StartCoroutine(QuitingTimer());
            //Application.Quit();
        }
    }


    IEnumerator QuitingTimer()
    {
        yield return new WaitForSeconds(1);
        isQuiting = false;
        Debug.Log("No response");
        quitMessageGameObject.SetActive(false);
    }
}
