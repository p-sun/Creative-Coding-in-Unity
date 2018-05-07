using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {

    public GameObject spinCube;

	void Start () {

        // Create a new cube, set its initial position, rotation, and scale.
        GameObject newCube = Instantiate(spinCube, new Vector3(3, 5, 0), Quaternion.identity);

        Instantiate(spinCube, new Vector3(3, 5, 0), Quaternion.identity);
        newCube.GetComponent<CubeScript>().SetScale(3.0f);
	}
	
	void Update () {
		
	}
}
