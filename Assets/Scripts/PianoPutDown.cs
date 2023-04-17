using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoPutDown : MonoBehaviour
{

    public GameObject PianoOnPlayer;
    public GameObject PutDownText;
    public GameObject PianoPlaced;
    public GameObject PianoDest;
    public AudioSource playSound;

    void Start()
    {
        PianoOnPlayer.SetActive(false);

        PianoDest.SetActive(true);

        PutDownText.SetActive(false);

        PianoPlaced.SetActive(false);

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            PutDownText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(true);

                PianoOnPlayer.SetActive(false);

                PutDownText.SetActive(false);

                PianoPlaced.SetActive(true);

                PianoDest.SetActive(false);

                playSound.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PutDownText.SetActive(false);
    }

}