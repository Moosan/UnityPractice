using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {
    public float rotateSpeed;
    private float thisAngle;
    void Start()
    {
        thisAngle = 0;
    }
	void Update () {
        thisAngle += Time.deltaTime * rotateSpeed;
        transform.rotation= Quaternion.Euler(new Vector3(0,thisAngle,0));
	}
}
