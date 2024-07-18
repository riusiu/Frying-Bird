using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
	Mariani Francesco Paolo
	-----------------------
*/

public class CameraScript : MonoBehaviour
{
    public Transform cameraPosition;

    void Update()
    {
        transform.position = cameraPosition.position;
    }
}
