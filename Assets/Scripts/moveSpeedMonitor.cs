using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSpeedMonitor : MonoBehaviour
{
    public float monitorSpeed;
    private Vector3 prevPos;
    private Vector3 nowPos;

    void Start()
    {
        prevPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Approximately(Time.deltaTime, 0))
            return;

        nowPos = transform.position;
        var velocity = (nowPos - prevPos) / Time.deltaTime;
        monitorSpeed = velocity.magnitude;

        prevPos = transform.position;

    }
}
