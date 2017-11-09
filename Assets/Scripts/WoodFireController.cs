using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodFireController : MonoBehaviour {

    private Light FirePitLight;
    float ActualValue;

	// Use this for initialization
	void Start () {
        FirePitLight = gameObject.GetComponent<Light>();
    }

    void Update(){
        ActualValue = Random.Range(3f, 4f);
        if(ActualValue < FirePitLight.intensity) { 
            FirePitLight.intensity -= Random.Range(3f, 4f) * Time.deltaTime;
        }
        else
        {
            FirePitLight.intensity += Random.Range(3f, 4f) * Time.deltaTime;

        }
    }


}
