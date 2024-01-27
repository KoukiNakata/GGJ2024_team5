using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inArea : MonoBehaviour
{
    public bool playerIn;
    public GameObject gameManager;
    private PanicPointManager PPM;
    private BGMManager BGMM;

    // Start is called before the first frame update
    void Start()
    {
        playerIn = false;
        PPM = gameManager.GetComponent<PanicPointManager>();
        BGMM = gameManager.GetComponent<BGMManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerIn = true;
            PPM.panic = true;
            BGMM.chase = true;
        }

    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Invoke("Exitmethod", 1.5f);
        }
    }
    private void Exitmethod()
    {
        playerIn = false;
        PPM.panic = false;
        BGMM.chase = false;
    }
}
