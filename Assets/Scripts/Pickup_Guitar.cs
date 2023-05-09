using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_Guitar : MonoBehaviour
{
    public GameObject PickUpText;
    public GameObject GuitarOnPlayer;
    public AudioSource PlaySound;
    


    // Start is called before the first frame update
    void Start()
    {
        GuitarOnPlayer.SetActive(false);
        PickUpText.SetActive(false);
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {

            PickUpText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);

                GuitarOnPlayer.SetActive(true);

                PickUpText.SetActive(false);

                PlaySound.Play();

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickUpText.SetActive(false);
    }
   
}

