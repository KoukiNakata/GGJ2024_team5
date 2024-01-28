using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TochGameOver : MonoBehaviour
{
    [SerializeField] GameObject gameDirectorObj;
    Gamedirector gameDirector;
    private string PlayertagName="Player";

    // Start is called before the first frame update
    void Start()
    {
        gameDirector=gameDirectorObj.GetComponent<Gamedirector>();
    }


    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == PlayertagName)
        {
            gameDirector.gameOver();
        }
    }
}
