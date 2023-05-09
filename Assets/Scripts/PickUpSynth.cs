using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSynth : MonoBehaviour
{
    public GameObject PickUpText;
    public GameObject SynthOnPlayer;
    public AudioSource playSound;



    // Start is called before the first frame update
    void Start()
    {
        SynthOnPlayer.SetActive(false);
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

                SynthOnPlayer.SetActive(true);

                PickUpText.SetActive(false);

                playSound.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickUpText.SetActive(false);
    }
}
