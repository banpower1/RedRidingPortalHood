using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileTimer : MonoBehaviour {

    public float Timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Timer -= Time.deltaTime;

        if(Timer < 0)
        {
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag != "Player")
        Destroy(gameObject);
    }

}
