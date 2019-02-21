using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : MonoBehaviour {

	public void SetLocalWarning(bool isLocal)
    {
        this.gameObject.SetActive(!isLocal);
    }
}
