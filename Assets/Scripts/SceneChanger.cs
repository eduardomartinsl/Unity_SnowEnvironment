using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Cancel")) {
            SceneManager.LoadScene("CharTEst");
            //SceneManager.LoadScene(1);
        }
	}

}
