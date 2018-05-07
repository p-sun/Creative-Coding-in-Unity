using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {

    public GameObject spinCube;

    void Start() {

        int totalCubes = 8;

        // The distance between the position of the first and last cube
        int totalDistance = 5;

        // LINEAR DISTRIBUTION
        for (int i = 0; i < totalCubes; i++) {
            
            float percentage = i / (float)totalCubes; // increases as i increases
            float inversePercentage = 1.0f - percentage; // decreases as i increases

            // Positions
            float x = percentage * totalDistance;
            float y = 6.0f;
            float z = 0.0f;

            // Create a new cube, set its initial position, rotation, scale, and speed of rotation.
            GameObject newCube = Instantiate(spinCube, new Vector3(x, y, z), Quaternion.identity);
            CubeScript cubeScript = newCube.GetComponent<CubeScript>();
            cubeScript.SetScale(inversePercentage);
            cubeScript.rotateAroundSpeed = 0;
        }

        // SIN DISTRIBUTION
        for (int i = 0; i < totalCubes; i++)
        {

            float percentage = i / (float)totalCubes; // increases as i increases
            float inversePercentage = 1.0f - percentage; // decreases as i increases

            // Sin in the first 90 degrees of the circle to calculate curveEaseOut
            // Which is a number from 0 to 1, that quickly increases at first, then slows down.
            // This makes the distance between the first cubes longer than the distance between the last cubes.
            float curveEaseOut = Mathf.Sin(percentage * Mathf.PI / 2);

            // Positions
            float x = curveEaseOut * totalDistance;
            float y = 3.0f;
            float z = 0.0f;

            // Create a new cube, set its initial position, rotation, scale, and speed of rotation.
            GameObject newCube = Instantiate(spinCube, new Vector3(x, y, z), Quaternion.identity);
            CubeScript cubeScript = newCube.GetComponent<CubeScript>();
            cubeScript.SetScale(inversePercentage);
            cubeScript.rotateAroundSpeed = 0;
        }
	}
	
	void Update () {
		
	}
}
