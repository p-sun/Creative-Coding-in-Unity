using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

    public float rotateAroundSpeed = 1.0f; // Rotation speed around the spin axis
    public Vector3 spinSpeed = Vector3.zero; // Rotation speed in its local system

    Vector3 spinAxis = Vector3.up;

	// Use this for initialization
	void Start () {

        spinSpeed = new Vector3(Random.value, Random.value, Random.value);

        float randomVal = Random.value - Random.value; // A number from -1 to 1, inclusive
        spinAxis.x = randomVal * .1f;
	}
	
	// Update is called once per frame
	void Update () {
        
        this.transform.Rotate(spinSpeed);
        this.transform.RotateAround(Vector3.zero, spinAxis, rotateAroundSpeed);
	}

    public void SetScale(float size) {
        
        this.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
    }
}
