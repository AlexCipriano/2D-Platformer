using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Hud : MonoBehaviour {

    public Slider healthBar;
    public Text endGameText;
    public bool isGameOver;

	// Use this for initialization
	void Start () {
        endGameText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!isGameOver)
            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 10f, 0, 0);
    }

}
