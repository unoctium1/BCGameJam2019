using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour {

    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Text distanceText;
    [SerializeField]
    private GameObject particles;

    private Collider goalCol;
    private float distanceFromGoal = 1000;

	// Use this for initialization
	void Start () {
        goalCol = this.GetComponent<Collider>();
        particles.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        distanceFromGoal = (this.transform.position - player.transform.position).magnitude;
        distanceText.text = distanceFromGoal.ToString();
	}

    public float GetDistance()
    {
        return distanceFromGoal;
    }

    public void OnTriggerEnter(Collider other)
    {
        particles.SetActive(true);
    }
}
