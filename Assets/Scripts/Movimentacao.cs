using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour {

    [Range(1, 5)]
    public float VelocidadeDeMovimento = 3;
    public float VelocidadeDeRotacao = 120;
    public Animator ControladorDeAnimacao;

    void Start() {
        ControladorDeAnimacao = GetComponent<Animator>();
    }

	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal") * VelocidadeDeRotacao * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);
        float vertical = Input.GetAxis("Vertical") * VelocidadeDeMovimento * Time.deltaTime;
        transform.Translate(0, 0, vertical);

        IniciaAnimacao(horizontal, vertical);
        if (Input.GetButton("Jump")){
            ControladorDeAnimacao.SetTrigger("Dancando");
        }
    }

    private void IniciaAnimacao(float horizontal, float vertical) {
        bool walking = horizontal != 0 || vertical != 0;
        ControladorDeAnimacao.SetBool("Andando", walking);
    }
}
