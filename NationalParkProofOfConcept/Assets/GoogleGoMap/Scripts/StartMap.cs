using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMap : MonoBehaviour {
    bool start;
    GoogleStaticMap goog;
	// Use this for initialization
	void Start () {
        onEnterScene(start);
	}
	
    void onEnterScene(bool flag)
    {
        if (flag)
        {
            goog = new GoogleStaticMap();
            goog.initialize();
            goog.DrawMap();
        }
    }
}
