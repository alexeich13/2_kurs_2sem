﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos=transform.position;
        Vector3 npos=new Vector3(pos.x+0.1f,pos.y,pos.z);
        transform.position=npos;
	}
}