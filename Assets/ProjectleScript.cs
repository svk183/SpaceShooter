using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectleScript : MonoBehaviour {
    public float projectileSpeed = 0.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, projectileSpeed, 0);
	}
}
