using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutonomousObject : MonoBehaviour 
{
    public Camera MainCamera;
    public Vector2 offset;

	// Update is called once per frame
	void Update () 
    {
        Vector3 mousePos = Input.mousePosition;
        Ray castPoint = MainCamera.ScreenPointToRay(mousePos);
        RaycastHit hit;
        if(Physics.Raycast(castPoint, out hit, 100))
        {
            transform.position = new Vector3(hit.point.x - offset.x, transform.position.y, hit.point.z - offset.y);
        }
	}
}
