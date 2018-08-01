using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollowing : MonoBehaviour {
    public Vector3 offset;
    public Transform target;
	// Use this for initialization
	void Start () {
        transform.position = target.position + offset;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * 3f);
	}
}
