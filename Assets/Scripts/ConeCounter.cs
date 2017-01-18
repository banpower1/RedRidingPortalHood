using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConeCounter : MonoBehaviour {


    private PlayerShoot ps;

	// Use this for initialization
	void Start () {

        ps = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerShoot>();

	}
	
	// Update is called once per frame
	void Update () {

        GetComponent<Text>().text = ps.Ammo.ToString();

	}
}
