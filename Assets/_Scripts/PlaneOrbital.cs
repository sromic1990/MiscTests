using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneOrbital : MonoBehaviour 
{
    public float speed, radius;

    private float timeElasped = 0.0f;

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        timeElasped += Time.deltaTime;

        float x = Mathf.Cos(timeElasped * radius);
        float z = Mathf.Sin(timeElasped * radius);

        transform.position = new Vector3(x, transform.position.y, z);
	}
}
