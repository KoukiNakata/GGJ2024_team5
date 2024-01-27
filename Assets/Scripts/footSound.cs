using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footSound : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject moveObj;
    moveSpeedMonitor msm;
    public AudioClip audioClip;
    AudioSource audioSource;
    public float muteDeadZone;




    void Start()
    {
        moveObj = this.gameObject;
        msm = GetComponent<moveSpeedMonitor>();
        audioSource = moveObj.GetComponent<AudioSource>();
        audioSource.loop = true;

    }

    // Update is called once per frame
    void Update()
    {
        if(msm.monitorSpeed>=muteDeadZone)
        {
            Debug.Log("Play");
            if (audioSource.isPlaying == true)
                return;

            audioSource.clip = audioClip;
            audioSource.Play();
        }
        else
        {
            Debug.Log("Stop");
            audioSource.Stop();
        }
    }
}
