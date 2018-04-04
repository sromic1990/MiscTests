using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPositionIenum : MonoBehaviour 
{
    public Transform startPos, endPos;
    public GameObject objectToMove;
    public float timeToMove;
    float t = 0;

	// Use this for initialization
	void Start () 
    {
        StartCoroutine(MoveOverSeconds(objectToMove, startPos.position, endPos.position, timeToMove));
	}
	
    public IEnumerator MoveOverSeconds(GameObject objectToMove, Vector3 startingPos, Vector3 end, float seconds)
    {
        float elapsedTime = 0;
        while (elapsedTime < seconds)
        {
            objectToMove.transform.position = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        objectToMove.transform.position = end;
    }
}
