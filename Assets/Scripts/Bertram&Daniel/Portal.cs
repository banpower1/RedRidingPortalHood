using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    bool teleported = false;
    private GameObject otherGameObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !teleported) 
        {
            if (OtherPortalIsActive())
            {
                collision.gameObject.transform.position = otherGameObject.transform.position;
                otherGameObject.GetComponent<Portal>().teleported = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        teleported = false;
    }

    bool OtherPortalIsActive()
    {
        Portal[] portals = Object.FindObjectsOfType<Portal>();
        for (int i = 0; i < portals.Length; i++)
        {
            if (portals[i].gameObject != gameObject)
            {
                otherGameObject = portals[i].gameObject;
                return true;
            }
        }
        return false;
    }
}
