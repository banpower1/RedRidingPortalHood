using UnityEngine;
using System.Collections;

public class ConnectedPortal : MonoBehaviour {

    public Transform connectedPortal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.transform.position = connectedPortal.position;
        }
    }

}
