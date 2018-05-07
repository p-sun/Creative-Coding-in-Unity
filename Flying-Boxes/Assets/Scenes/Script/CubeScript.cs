using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

    Vector3 spinSpeed = Vector3.zero;

	// Use this for initialization
	void Start () {
        
        this.transform.position = new Vector3(0f, 5f, 0f);
        this.transform.localScale = new Vector3(2f, 2f, 2f);

        spinSpeed = new Vector3(Random.value, Random.value, Random.value);
	}
	
	// Update is called once per frame
	void Update () {
        
        this.transform.Rotate(spinSpeed);
	}
}
