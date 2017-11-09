using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSeguindo : MonoBehaviour {

    public GameObject Personagem;
    Vector3 deslocamento;

	// Use this for initialization
	void Start () {
        deslocamento = transform.position - Personagem.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 posicaoDesejada = Personagem.transform.position + deslocamento;
        transform.position= posicaoDesejada;
        transform.LookAt(Personagem.transform.position);
	}
}
