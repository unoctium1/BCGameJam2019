using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    private SceneController instance = null;

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

    public void SetSceneAsync(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }

    public void SetSceneAsync(int sceneIndex)
    {
        SceneManager.LoadSceneAsync(sceneIndex);
    }

    public void IncrementSceneAysnc()
    {
        int curIndex = SceneManager.GetActiveScene().buildIndex;
        if(curIndex != SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadSceneAsync(curIndex+1);
        }
    }
    public void DecrementSceneAysnc()
    {
        int curIndex = SceneManager.GetActiveScene().buildIndex;
        if (curIndex != 0)
        {
            SceneManager.LoadSceneAsync(curIndex - 1);
        }
    }
}
