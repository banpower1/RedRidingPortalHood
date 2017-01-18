using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSteer : MonoBehaviour {
	Vector3 mousePosition;
	public GameObject bluePortalPrefab;
	public GameObject redPortalPrefab;

	private GameObject bluePortalInstance;
	private GameObject redPortalInstance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		mousePosition.z = 0;
		// Get Angle in Radians
		float AngleRad = Mathf.Atan2(mousePosition.y - transform.position.y, mousePosition.x - transform.position.x);
		// Get Angle in Degrees
		float AngleDeg = (180 / Mathf.PI) * AngleRad;
		// Rotate Object
		transform.rotation = Quaternion.Euler(0, 0, AngleDeg);

		if (Input.GetMouseButtonDown(0)) {
			// Spawn a red portal
			if (redPortalInstance == null) {
				redPortalInstance = Instantiate (redPortalPrefab, mousePosition, Quaternion.identity);
			} else {
				redPortalInstance.transform.position = mousePosition;
			}
		}

		if (Input.GetMouseButtonDown(1)) {
			// Spawn a blue portal
			if (bluePortalInstance == null) {
				bluePortalInstance = Instantiate (bluePortalPrefab, mousePosition, Quaternion.identity);
			} else {
				bluePortalInstance.transform.position = mousePosition;
			}
		}
	}
}
