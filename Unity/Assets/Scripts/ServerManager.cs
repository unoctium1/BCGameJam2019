using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerManager : MonoBehaviour {

    [SerializeField]
    private string localserver;
    [SerializeField]
    private string localauth;
    [SerializeField]
    private string onlineserver;
    [SerializeField]
    private string onlineauth;

    [Header("Editor")]
    [SerializeField]
    private bool localEditor;

    private bool isLocal = false;

    public static ServerManager instance = null;

    // Use this for initialization
    void Awake () {
		if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetLocal(bool toSet)
    {
        isLocal = toSet;
    }

    public void SetSpeckleDetails(UnitySpeckle us)
    {
        if (Application.isEditor)
        {
            SetDetailsHelper(us, localEditor);
        }
        else
        {
            SetDetailsHelper(us, isLocal);
        }
    }

    private void SetDetailsHelper(UnitySpeckle us, bool toSet)
    {
        if (toSet)
        {
            us.ServerURL = localserver;
            us.StreamIDs.Add(localauth);
        }
        else
        {
            us.ServerURL = onlineserver;
            us.StreamIDs.Add(onlineauth);
        }
    }
        
}
