using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject target;
    private NavMeshAgent agent;
    public GameObject SerchArea;
    private inArea inarea;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        inarea = SerchArea.GetComponent<inArea>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inarea.playerIn == false)
            return;
            agent.destination = target.transform.position;
    }

}
