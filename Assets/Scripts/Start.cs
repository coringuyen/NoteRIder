﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour {

	// Update is called once per frame
	public void StartGame()
    {
            SceneManager.LoadScene("ourScene");
    }
}
