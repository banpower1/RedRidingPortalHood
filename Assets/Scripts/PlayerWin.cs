using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerWin : MonoBehaviour {

    public int BasketsToCollect = 1;

    public int BasketsCollected = 0;

    public bool GetToExit = false;

    private bool playerHasWon = false;

    public int NextScene = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (!GetToExit && BasketsCollected == BasketsToCollect)
        {

            playerHasWon = true;

        }

        if (playerHasWon)
        {
            SceneManager.LoadScene(NextScene);
        }


	}

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag == "PickUp")
        {

            BasketsCollected++;

            Destroy(collision.gameObject);
        }


        if(collision.tag == "Goal" && BasketsCollected >= BasketsToCollect)
        {

            playerHasWon = true;

        }

    }

}
