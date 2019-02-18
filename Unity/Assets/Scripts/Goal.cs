using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    [SerializeField]
    private GameObject goalObj;
    [SerializeField]
    private GameObject player;

    private Collider goalCol;
    private float distanceFromGoal = 1000;

	// Use this for initialization
	void Start () {
        goalCol = goalObj.GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
        distanceFromGoal = (goalObj.transform.position - player.transform.position).magnitude;
	}

    public float GetDistance()
    {
        return distanceFromGoal;
    }
}
