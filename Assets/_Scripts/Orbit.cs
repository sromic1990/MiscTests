using System;
using System.Collections;
using UnityEngine;

public class Orbit : MonoBehaviour 
{

    public Transform orbitingObject;
    public Ellipse orbitPath;
    [Range(0, 1)]
    public float orbitProgress = 0.0f;
    public float orbitPeriod = 3f;
    public bool orbitActive = true;
    public int direction = 1;

	// Use this for initialization
	void Start () 
    {
	    if(orbitingObject == null)
        {
            orbitActive = false;
            return;
        }

        SetOrbitingObjectPosition();
        StartCoroutine(AnimateOrbit());
	}

    private IEnumerator AnimateOrbit()
    {
        orbitPeriod = Mathf.Abs(orbitPeriod) < 0.1f ? 0.1f : orbitPeriod;
        orbitPeriod *= direction;

        float orbitSpeed = 1f / orbitPeriod;

        while(orbitActive)
        {
            orbitProgress += Time.deltaTime * orbitSpeed;
            orbitProgress %= 1f;
            SetOrbitingObjectPosition();
            yield return null;
        }
    }

    private void SetOrbitingObjectPosition()
    {
        Vector2 orbitPos = orbitPath.Evaluate(orbitProgress);
        orbitingObject.localPosition = new Vector3(orbitPos.x, orbitingObject.transform.localPosition.y, orbitPos.y);
    }
}
