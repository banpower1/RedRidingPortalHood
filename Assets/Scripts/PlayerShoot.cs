using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public float Force = 100f;

    public GameObject Projectile;

    public float LifeTime = 2f;

    public KeyCode ShootButton = KeyCode.RightShift;

    public int Ammo = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(ShootButton) && Ammo > 0)
        {

            Ammo--;

            GameObject temp = Instantiate(Projectile, transform.position, transform.rotation);

            temp.GetComponent<ProjectileTimer>().Timer = LifeTime;

            if (transform.localScale.x < 0)
            {
                temp.GetComponent<Rigidbody2D>().AddForce((-transform.right) * Force);
            }
            else
            {
                temp.GetComponent<Rigidbody2D>().AddForce((transform.right) * Force);
            }

        }

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ammo")
        {

            Ammo++;

            Destroy(collision.gameObject);

        }
    }
}
