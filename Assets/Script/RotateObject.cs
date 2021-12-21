﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public GameObject objectRotate;

	public float rotateSpeed = 50f;
	bool rotateStatus = false;

	//rotate object function
	public void RotateObjects()
	{

		if (rotateStatus == false)
		{
			rotateStatus = true;
		}
		else
		{
			rotateStatus = false;
		}
	}

	void Update()
	{
		if (rotateStatus == true)
		{
			//rotate object with speed
			objectRotate.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
		}
	}
}
