﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class StartScreensController : MonoBehaviour {

    public GameObject firstScreen;

    public void call () {
        if (File.Exists(Application.persistentDataPath + "/playerData.dat"))
        {
            firstScreen = transform.GetChild(0).gameObject;
            firstScreen.SetActive(false);
        }
    }
	
	
}