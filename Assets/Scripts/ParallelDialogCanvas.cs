using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallelDialogCanvas : MonoBehaviour {

    public Camera MainCamera;
    
    void Update () {
        Vector3 v = MainCamera.transform.position - transform.position;

        v.x = v.z = 0f;
        transform.LookAt(MainCamera.transform.position - v);
        transform.Rotate(0, 180, 0);
    }
}
