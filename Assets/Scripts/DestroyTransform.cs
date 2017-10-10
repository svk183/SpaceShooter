using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTransform : MonoBehaviour {
	ScoreLogic addToScore;
	public GameObject ParticleObject;

	void OnCollisionEnter2D(Collision2D transformCollision){
		if(transformCollision.gameObject.tag == "Collision"){
			spawnParticles (transformCollision.gameObject.transform.position);
			Destroy (transformCollision.gameObject);
			addToScore = GameObject.FindGameObjectWithTag ("GUI").GetComponent<ScoreLogic> ();
			addToScore.addToScoreVOID ();
		}
	}

	void spawnParticles(Vector3 position){
		Instantiate (ParticleObject, position, Quaternion.identity);
	}
}
