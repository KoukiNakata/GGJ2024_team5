using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnbuttonSE : MonoBehaviour
{
    [SerializeField] Sounddiretctor soundDirector;
    // Start is called before the first frame update
    public void onClick()
    {
        soundDirector.UIbutton();
    }

}
