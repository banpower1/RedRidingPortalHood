using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Projectile" || col.tag == "Player")
        {

            Destroy(this.gameObject);

            col.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 300));

            Collider2D[] enemyCollider = GetComponents<Collider2D>();

            for (int i = 0; i < enemyCollider.Length; i++)
            {
                enemyCollider[i].enabled = false;
            }

            transform.Rotate(Vector3.forward * 180);
            GetComponent<EnemyWalk>().enabled = false;
            GetComponentInChildren<Animator>().enabled = false;


        }
    }




}
