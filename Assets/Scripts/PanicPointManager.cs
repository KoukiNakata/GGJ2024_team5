using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanicPointManager : MonoBehaviour
{
    public inArea[] serchArea;
    public bool panic;
    public float panicPlusPoint;
    public float panicMinusPoint;
    public float panicPoint;
    public float panicPointMax;
    // Start is called before the first frame update
    void Start()
    {
        panicPoint = 0;
        panic = false;
    }

    // Update is called once per frame
    void Update()
    {
        //パニック状態の時プラスそれ以外マイナス
        if(panic==true)
        {
            panicPoint += panicPlusPoint;
        }
        else
        {
            panicPoint -= panicMinusPoint;
            if(panicPoint<0)
            {
                panicPoint = 0;
            }
        }
    }
}
