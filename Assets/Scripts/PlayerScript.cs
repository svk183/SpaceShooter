using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

    public GameObject projectile;

    public float playerSpeed = 0.5f;
    public float ProjectileSpeed = 1.0f;
    public bool isShooting = true;

    float maximumXPosition = 20.0f;

	void Start () {
        StartCoroutine(projectileShooterTimer());
	}
	
	void Update () {
        updatePlayerPosition();
    }

    void updatePlayerPosition()
    {
        if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -maximumXPosition)
            transform.Translate(-playerSpeed, 0, 0);

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < maximumXPosition)
            transform.Translate(playerSpeed, 0, 0);
    }

    IEnumerator projectileShooterTimer()
    {
        while (isShooting)
        {
            spawnProjectile();
            yield return new WaitForSeconds(ProjectileSpeed);
        }
    }

    void spawnProjectile()
    {
		Instantiate(projectile, new Vector3(transform.position.x, transform.position.y + 3.0f, 0), Quaternion.identity);
    }

	void OnCollisionEnter2D(Collision2D transformCollision){
		if(transformCollision.gameObject.tag == "Collision"){
			SceneManager.LoadScene ("Game");
		}
	}
}
