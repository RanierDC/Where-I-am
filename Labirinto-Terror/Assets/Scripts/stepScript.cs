using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stepScript : MonoBehaviour
{
    public AudioSource audio;
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            audio.Play();
        }
        if (Input.GetKeyUp("w"))
        {

            audio.Stop();
        }
        if (Input.GetKeyDown("s"))
        {

            audio.Play();
        }
        if (Input.GetKeyUp("s"))
        {

            audio.Stop();
        }
    }
}
