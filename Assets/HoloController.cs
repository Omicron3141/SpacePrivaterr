﻿using UnityEngine;
using System.Collections;

public class HoloController : MonoBehaviour {


	public Vector3 rotation;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (rotation*Time.deltaTime, Space.World);
	}

}
