using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp_drums : MonoBehaviour
{
    public GameObject PickUpText;
    public GameObject DrumsOnPlayer;
    


    // Start is called before the first frame update
    void Start()
    {
        DrumsOnPlayer.SetActive(false);
        PickUpText.SetActive(false);
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            {
                PickUpText.SetActive(true);

                if (Input.GetKey(KeyCode.E))
                {
                    this.gameObject.SetActive(false);

                    DrumsOnPlayer.SetActive(true);

                    PickUpText.SetActive(false);
                }

            }

            
           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickUpText.SetActive(false);
    }


}
