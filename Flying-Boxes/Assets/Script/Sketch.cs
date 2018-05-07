using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {

    void Start() {

        createCentralCube();

        int totalCubes = 30;

        // The distance between the position of the first and last cube
        float totalDistance = 2.9f;

        // SIN DISTRIBUTION
        for (int i = 0; i < totalCubes; i++)
        {

            float percentage = i / (float)totalCubes; // increases as i increases

            // Sin in the first 90 degrees of the circle to calculate curveEaseOut
            // Which is a number from 0 to 1, that quickly increases at first, then slows down.
            // This makes the distance between the first cubes longer than the distance between the last cubes.
            float curveEaseOut = Mathf.Sin(percentage * Mathf.PI / 2);

            // Positions
            float x = 1.8f + curveEaseOut * totalDistance;
            float y = 5.0f;
            float z = 0.0f;

            Vector3 position = new Vector3(x, y, z);
            float scale = .45f * (1.0f - percentage);
            float rotateAroundSpeed = .2f + curveEaseOut * 4.0f;
            createNewSpinCube(position, scale, rotateAroundSpeed);
        }
	}
	
	void Update () {
		
	}

    private void createCentralCube() {
        Vector3 position = new Vector3(0, 5, 0);
        float scale = 1.5f;
        float rotateAroundSpeed = 1;
        createNewSpinCube(position, scale, rotateAroundSpeed);
    }

    // Create a new cube, set its initial position, rotation, scale, and speed of rotation.
    private void createNewSpinCube(Vector3 position, float scale, float rotateAroundSpeed) {

        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = position;
        cube.transform.localScale = new Vector3(scale, scale, scale);

        cube.AddComponent<CubeScript>();
        cube.GetComponent<CubeScript>().rotateAroundSpeed = rotateAroundSpeed;
    }
}
