﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBowMovement : MonoBehaviour {
    private GameObject archer;
	// Use this for initialization
	void Start () {
        archer = GameObject.Find("archer");
	}
	
	// Update is called once per frame
	void Update () {
       

        Vector3 vectorToTarget = -archer.transform.position + transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 100);
    }
}
