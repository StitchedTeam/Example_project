using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour {

    private static bool created = false;

	// Use this for initialization
	void Awake () {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            print(gameObject.transform.name + " was created and won't be destroyed on loading new scenes.");
        }
		
	}
}
