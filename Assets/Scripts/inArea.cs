using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inArea : MonoBehaviour
{
    public bool playerIn;
    // Start is called before the first frame update
    void Start()
    {
        playerIn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerIn = true;
        }

    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerIn = false;
        }
    }
}
