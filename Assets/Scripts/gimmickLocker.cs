using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gimmickLocker : gimicBase, Igimic
{
    [SerializeField] Animator animator;
    [SerializeField] Sounddiretctor sounddiretctor;
    private string flagName = "openFlag";

    void Start()
    {
        changeTag();
    }

    public override void getedGimic()
    {
        animator.SetBool(flagName, true);
    }
}