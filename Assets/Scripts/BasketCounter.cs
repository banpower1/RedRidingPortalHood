using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketCounter : MonoBehaviour {

    private PlayerWin pw;

    // Use this for initialization
    void Start()
    {

        pw = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerWin>();

    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Text>().text = pw.BasketsCollected.ToString() + "/" + pw.BasketsToCollect.ToString();

    }
}
