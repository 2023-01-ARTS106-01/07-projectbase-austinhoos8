using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SynthPutDown : MonoBehaviour
{

    public GameObject SynthOnPlayer;
    public GameObject PutDownText;
    public GameObject SynthPlaced;
    public GameObject SynthDest;
    public AudioSource playSound;
    public GameObject RecoverText;

    void Start()
    {
        SynthOnPlayer.SetActive(false);

        SynthDest.SetActive(true);

        PutDownText.SetActive(false);

        SynthPlaced.SetActive(false);

        RecoverText.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (SynthOnPlayer.activeInHierarchy)
            {
                PutDownText.SetActive(true);

                if (Input.GetKey(KeyCode.E))
                {
                    this.gameObject.SetActive(true);

                    SynthOnPlayer.SetActive(false);

                    PutDownText.SetActive(false);

                    SynthPlaced.SetActive(true);

                    SynthDest.SetActive(false);

                    playSound.Play();

                }

            }

            else
            {
                RecoverText.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PutDownText.SetActive(false);
        RecoverText.SetActive(false);
    }
}