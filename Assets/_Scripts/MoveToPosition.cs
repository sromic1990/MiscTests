using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPosition : MonoBehaviour 
{
    public Transform startPos, endPos;
    public GameObject objectToMove;
    public float timeToMove;
    float t = 0;

	
	// Update is called once per frame
	void Update () 
    {
        t += Time.deltaTime / timeToMove;
        objectToMove.transform.position = Vector3.Lerp(startPos.position, endPos.position, t);
        //objectToMove.transform.position = Vector3.Lerp(objectToMove.transform.position, endPos.position, t);
	}
}
