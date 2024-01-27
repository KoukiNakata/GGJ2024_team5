using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inArea : MonoBehaviour
{
    public bool playerIn;
    public GameObject gameManager;
    private PanicPointManager PPM;
    // Start is called before the first frame update
    void Start()
    {
        playerIn = false;
        PPM = gameManager.GetComponent<PanicPointManager>();
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
            PPM.panic = true;
        }

    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerIn = false;
            PPM.panic = false;
        }
    }
}
