using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] normaltarget;
    public int targetID;
    public GameObject Playertarget;
    private NavMeshAgent agent;
    public GameObject SerchArea;
    private inArea inarea;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        inarea = SerchArea.GetComponent<inArea>();
        targetID = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(inarea.playerIn==true)
            agent.destination = Playertarget.transform.position;
        
        else
        {
            if (normaltarget.Length == 0)
                return;
            agent.destination = normaltarget[targetID].transform.position;
        }
            
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name==normaltarget[targetID].name)
        {
            targetID += 1;
            if (targetID == normaltarget.Length)
            {
                targetID = 0;
            }
        }
    }
}
