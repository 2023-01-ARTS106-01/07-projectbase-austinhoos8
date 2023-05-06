using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    public GameObject source;
    public GameObject instrument;
    

    void Awake()
    {
        source.SetActive(false);

    }
    private void OnTriggerStay(Collider other)
    {
        if (instrument.activeInHierarchy)
        {
            source.SetActive(true);
        }

        else 
        {
            source.SetActive(false);
        }
          

        
    }
   
    private void OnTriggerExit(Collider other)
    {
        source.SetActive(false);
    }
    
   

    
        
}
