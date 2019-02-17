using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UDPManager : MonoBehaviour {

    private float lastSentDist;
    [SerializeField]
    private Goal goal;
    private const float THRESHOLD = 0.05f;

    // Use this for initialization
    void Start () {
        lastSentDist = goal.GetDistance();
	}
	
	// Update is called once per frame
	void Update () {
		if(Math.Abs(goal.GetDistance() - lastSentDist) > THRESHOLD)
        {

        }
	}
}
