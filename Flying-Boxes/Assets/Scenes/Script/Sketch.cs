using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {

    public GameObject spinCube;

    void Start() {

        for (int i = 0; i < 3; i++) {

            // Position
            float x = 3.0f;
            float y = 5.0f;
            float z = 0.0f;

            // Create a new cube, set its initial position, rotation, scale, and speed of rotation.
            GameObject newCube = Instantiate(spinCube, new Vector3(x, y, z), Quaternion.identity);
            CubeScript cubeScript = newCube.GetComponent<CubeScript>();
            cubeScript.SetScale(3.0f);
            cubeScript.rotateAroundSpeed = Random.value;
        }
	}
	
	void Update () {
		
	}
}
