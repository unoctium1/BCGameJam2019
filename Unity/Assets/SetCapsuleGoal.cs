using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SetCapsuleGoal : MonoBehaviour {

    [SerializeField]
    private GameObject destination;

    private NavMeshAgent agent;

    // Use this for initialization
    void Start () {
        agent = this.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        agent.destination = destination.transform.position;
	}
}
