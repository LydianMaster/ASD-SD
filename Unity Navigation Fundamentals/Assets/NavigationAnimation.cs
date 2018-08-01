﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationAnimation : MonoBehaviour
{
    NavMeshAgent agent;
    Animator anim;

	// Use this for initialization
	void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        anim.SetFloat("Forward", agent.velocity.sqrMagnitude);
	}
}
