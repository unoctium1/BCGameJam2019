using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneInit : MonoBehaviour {

    [SerializeField]
    private UnitySpeckle speckleManager;

	// Use this for initialization
	void Awake () {
        ServerManager.instance.SetSpeckleDetails(speckleManager);
        SetCursorLock();
	}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Cursor.lockState == CursorLockMode.Locked)
        {
            SetCursorVis();
        } else if(Input.GetKeyDown(KeyCode.Escape) && Cursor.lockState == CursorLockMode.Confined)
        {
            SetCursorLock();
        }
    }

    private void SetCursorLock()
    {
        Debug.Log("Cursor locked");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void SetCursorVis()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Confined;
    }

}
