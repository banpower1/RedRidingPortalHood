using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour {

    // Script should go on player

    float move;
    public float maxSpeed = 0.1f;
    private Rigidbody2D playerRigidbody;
    
    // Use this for initialization
    void Start () {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        move = Input.GetAxis("Horizontal") * 0.2f;
        playerRigidbody.velocity = new Vector2(move * maxSpeed, playerRigidbody.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Enemy")
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }

}
