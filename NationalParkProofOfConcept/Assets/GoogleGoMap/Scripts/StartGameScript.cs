using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour {

    int sceneNum;
    Button button;
    SceneManager loader;
    // Use this for initialization
    void Start () {
        sceneNum = 0;
        button = button.GetComponent<Button>();
        loader = new SceneManager();
	}
	
	// Update is called once per frame
	void Update () {
        button.onClick.AddListener(ChangeScene);
	}

    public void ChangeScene()
    {
        SceneManager.LoadScene("MainGame");
        
    }

   
}
