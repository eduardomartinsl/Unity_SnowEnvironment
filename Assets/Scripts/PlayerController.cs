using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float VelocidadMovimento = 3;
    public float VelocidadeRotacao = 120;

    void OnCollisionEnter(Collision other) {
        //Debug.Log(other.gameObject.name);
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * VelocidadeRotacao * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Vertical") * VelocidadMovimento * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }
}
