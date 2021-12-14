 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetLimits : MonoBehaviour
{
    float xRange = 50f;
    float zRange = 25f;
    private float inicialPos = 0.5f;
    private float inicialPos2 = 0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(x: inicialPos2, y: inicialPos, z: inicialPos2);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += Vector3.back;
        }
    }
}
