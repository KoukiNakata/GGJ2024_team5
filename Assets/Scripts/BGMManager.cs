using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool chase;
    public AudioClip normalClip;
    public AudioClip chaseClip;
    private AudioSource aSource;
    private bool prevChaseState;

    void Start()
    {
        chase = false;
        aSource = GetComponent<AudioSource>();
        aSource.clip = normalClip;
        aSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(chase==false)
        {
            if (prevChaseState == true)
            {
                aSource.clip = normalClip;
                aSource.Play();
            }
            else
                return;
        }
        else
        {
            if (prevChaseState == false)
            {
                aSource.clip = chaseClip;
                aSource.Play();
            }
            else
                return;
        }
        prevChaseState = chase;
    }
}
