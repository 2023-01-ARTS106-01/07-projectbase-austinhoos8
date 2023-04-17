using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp_Piano : MonoBehaviour
{
    public GameObject PickUpText;
    public GameObject PianoOnPlayer;
    public AudioSource playSound;


    // Start is called before the first frame update
    void Start()
    {
        PianoOnPlayer.SetActive(false);
        PickUpText.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            PickUpText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);

                PianoOnPlayer.SetActive(true);

                playSound.Play();

                PickUpText.SetActive(false);
            }

        }
            
    }

    private void OnTriggerExit(Collider other)
    {
        PickUpText.SetActive(false);
    }


}
