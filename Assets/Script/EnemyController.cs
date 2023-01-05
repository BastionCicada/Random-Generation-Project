using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    NavMeshAgent NavMesh;
    public Transform target;

    

    
    // Start is called before the first frame update
    void Start()
    {
        NavMesh = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        NavMesh.SetDestination(target.position);
    }
}
