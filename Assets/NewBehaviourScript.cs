using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(onClick_ScrollView_Ghadimi);
    }

    

  
    public void onClick_ScrollView_Ghadimi()
    {
        this.gameObject.SetActive(true);
 
    }
}
