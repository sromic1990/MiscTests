using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour 
{

    public float time;
    public float delay;
    public iTween.EaseType easeType;
    public iTween.LoopType loopType;


	// Use this for initialization
	void Start () 
    {
        StartAnimation();
        delay = 5;
	}

    private void StartAnimation()
    {
        iTween.MoveTo(gameObject, iTween.Hash("z", transform.position.z - 50, "time", time, "easetype", easeType, "looptype", loopType, "onupdate", "TestUpdate"));
    }

    private void TestUpdate()
    {
        
    }
}
