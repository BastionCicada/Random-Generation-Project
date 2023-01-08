using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    NavMeshAgent NavMesh; //This looks for the navmesh agent and calls it as NavMesh
    public Transform target; // This designates the target

    

    
    // Start is called before the first frame update
    void Start()
    {
        NavMesh = GetComponent<NavMeshAgent>(); // This defines NavMash as the component NavMeshAgent
        
    }

    // Update is called once per frame
    void Update()
    {
        NavMesh.SetDestination(target.position); // This looks for the targets position and sets the navmesh towards it
    }
}
