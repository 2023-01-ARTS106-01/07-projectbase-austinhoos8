using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumPutDown : MonoBehaviour
{

    public GameObject DrumOnPlayer;
    public GameObject PutDownText;
    public GameObject DrumPlaced;
    public GameObject DrumDest;
    public AudioSource playSound;

    void Start()
    {
        DrumOnPlayer.SetActive(false);

        DrumDest.SetActive(true);

        PutDownText.SetActive(false);

        DrumPlaced.SetActive(false);

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            PutDownText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(true);

                DrumOnPlayer.SetActive(false);

                PutDownText.SetActive(false);

                DrumPlaced.SetActive(true);

                DrumDest.SetActive(false);

                playSound.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PutDownText.SetActive(false);
    }

}
