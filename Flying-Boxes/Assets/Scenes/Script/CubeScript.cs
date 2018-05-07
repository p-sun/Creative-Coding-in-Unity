using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

    Vector3 spinSpeed = Vector3.zero;

	// Use this for initialization
	void Start () {

        this.transform.position = new Vector3(0.0f, 5.0f, 3.0f);
        SetScale(2);
        spinSpeed = new Vector3(Random.value, Random.value, Random.value);
	}
	
	// Update is called once per frame
	void Update () {
        
        this.transform.Rotate(spinSpeed);
        this.transform.RotateAround(Vector3.zero, Vector3.up, 1.0f);
	}

    public void SetScale(float size) {
        
        this.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
    }
}
