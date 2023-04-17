using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceGuitarText : MonoBehaviour
{
    public GameObject PutDownText;
    


    // Start is called before the first frame update
    void Start()
    {
        
        PutDownText.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            PutDownText.SetActive(true);

          
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PutDownText.SetActive(false);
    }
}
