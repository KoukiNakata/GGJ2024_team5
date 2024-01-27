using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    public moveSpeedMonitor MSM;
    public Animator anim;
    public bool walk;

    // Start is called before the first frame update
    void Start()
    {
        walk = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (MSM.monitorSpeed >= 0.1)
        {
            walk = true;
            anim.SetBool("walk", true);
        }
        else
        {
            walk = false;
            anim.SetBool("walk", false);
        }
            
    }
}
