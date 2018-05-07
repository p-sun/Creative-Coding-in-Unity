using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.transform.position = new Vector3(0, 5, 0);
        this.transform.localScale = new Vector3(2, 2, 2);		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(.1f, .1f, .1f);
	}
}
