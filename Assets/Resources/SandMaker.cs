using UnityEngine;
using System.Collections;

public class SandMaker : MonoBehaviour {

    

	// Use this for initialization
	void Start () {

        for (int i = 0; i < 100; i++)
        {
            //instantiate the grain object
            GameObject grain = new GameObject("grain" + i);
            //add the script to the object
            grain.AddComponent<grainObject>();
        }
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
