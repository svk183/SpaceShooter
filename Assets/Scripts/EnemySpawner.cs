using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
	
	public GameObject EnemyObjectSpawner;

	public float enemyObjectSpeed = 1.0f;
	public bool isEnemySpawn = true;
	public float startingY = 12.0f;
	public float maxX = 18.0f;
	float randomX;

	void Start () {
		StartCoroutine (EnemySpawnerTimer());
	}
	 
	void Update () {
		
	}

	IEnumerator EnemySpawnerTimer(){
		while (isEnemySpawn) {
			EnemyInitiator ();
			yield return new WaitForSeconds (enemyObjectSpeed);
		}
	}

	void EnemyInitiator(){
		randomX = Random.Range (-maxX, maxX);
		Instantiate (EnemyObjectSpawner, new Vector3(randomX, startingY, 0), Quaternion.identity);
	}
}
