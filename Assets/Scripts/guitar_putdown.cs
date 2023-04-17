using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guitar_putdown : MonoBehaviour
{
    
    public GameObject GuitarOnPlayer;
    public GameObject PutDownText;
    public GameObject GuitarPlaced;
    public GameObject GuitarDest;
    public AudioSource playSound;

    // Start is called before the first frame update
    void Start()
    {
        GuitarOnPlayer.SetActive(false);

        GuitarDest.SetActive(true);

        PutDownText.SetActive(false);

        GuitarPlaced.SetActive(false);

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            PutDownText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(true);

                GuitarOnPlayer.SetActive(false);

                PutDownText.SetActive(false);

                GuitarPlaced.SetActive(true);

                GuitarDest.SetActive(false);

                playSound.Play();


            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PutDownText.SetActive(false);
    }

}
