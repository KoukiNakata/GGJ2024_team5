using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounddiretctor : MonoBehaviour
{
    [SerializeField] AudioSource SE;
    [SerializeField] AudioClip GetKey_SE, OpenKey_SE, Exit_SE, UIbutton_SE;
    // Start is called before the first frame update

    public void GetKey()
    {
        SE.PlayOneShot(GetKey_SE);
    }
    public void OpenKey()
    {
        SE.PlayOneShot(OpenKey_SE);
    }
    public void Exit()
    {
        SE.PlayOneShot(Exit_SE);
    }
    public void UI_button()
    {
        SE.PlayOneShot(UIbutton_SE);
    }

}
