using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeDirection : MonoBehaviour
{
    [SerializeField] Animator animator;
    private string flagName = "fadeFlag";

    public void fadeoutDirection()
    {
        animator.SetBool(flagName, true);
    }
}