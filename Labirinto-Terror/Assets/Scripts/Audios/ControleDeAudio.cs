using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDeAudio : MonoBehaviour
{
    public AudioSource musicaDeFundo;
    public AudioClip[] audiosDeFundo;
    void Start()
    {
        AudioClip audiosDeFundoDessaFase = audiosDeFundo[0];
        musicaDeFundo.clip = audiosDeFundoDessaFase;
        musicaDeFundo.Play();
    }

    void Update()
    {
        
    }
}
