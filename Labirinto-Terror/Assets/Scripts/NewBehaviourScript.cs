using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Light luz;
    public GameObject obj;
    public AudioSource audioSource;
    public AnimationCurve animationCurve;
    public WrapMode wrapmode = WrapMode.PingPong;

    void Start()
    {
        this.animationCurve.postWrapMode = this.wrapmode;

    }

  
    void Update()
    {
        float value = animationCurve.Evaluate(Time.time);
        this.luz.intensity = value;

        if(value >= 0.6 && this.audioSource.isPlaying)
        {
            this.audioSource.Play();
        }
    }
}
