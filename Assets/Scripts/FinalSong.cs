using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalSong : MonoBehaviour
{

    public GameObject Speaker;
    public GameObject GuitarPlaced;
    public GameObject DrumPlaced;
    public GameObject SynthPlaced;
    public GameObject PianoPlaced;
    public AudioSource Song;
    public AudioSource Rumble;


    // Start is called before the first frame update
    void Start()
    {
        Speaker.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (DrumPlaced.activeInHierarchy && GuitarPlaced.activeInHierarchy && SynthPlaced.activeInHierarchy && PianoPlaced.activeInHierarchy)
        {
            Speaker.SetActive(true);

            GuitarPlaced.SetActive(false);
            DrumPlaced.SetActive(false);
            SynthPlaced.SetActive(false);
            PianoPlaced.SetActive(false);

            Song.Play();

            Rumble.Play();



        }
    }
}
