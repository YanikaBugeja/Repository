﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print(Input.mousePosition.x);
        float mousePositionInUnits = ((Input.mousePosition.x / Screen.width) * 16) -8;
        Vector3 newPaddlePosition = new Vector3(mousePositionInUnits, gameObject.transform.position.y,
                                                gameObject.transform.position.z);

        this.transform.position = newPaddlePosition;
    }
}
