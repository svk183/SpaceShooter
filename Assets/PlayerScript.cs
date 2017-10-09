using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public GameObject projectile;

    public float playerSpeed = 0.5f;
    public float ProjectileSpeed = 0.5f;
    public bool isShooting = true;

    float maximumXPosition = 25.0f;

	void Start () {
        StartCoroutine(projectileShooterTimer());
	}
	
	void Update () {
        updatePlayerPosition();
        spawnProjectile();
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
        if (isShooting)
        {
            yield return new WaitForSeconds(ProjectileSpeed);
        }
    }

    void spawnProjectile()
    {
        Instantiate(projectile, transform.position, Quaternion.identity);
    }
}
