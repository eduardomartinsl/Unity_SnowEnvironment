using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject Personagem;
    //float SuavicacaoDeMovimento = 1f;
    Vector3 deslocamento;

    void Start(){
        deslocamento = transform.position - Personagem.transform.position;
    }

    void LateUpdate(){
        Vector3 PosicaoDesejada = Personagem.transform.position + deslocamento;
        //Vector3 Posicao = Vector3.Lerp(transform.position, PosicaoDesejada, SuavicacaoDeMovimento * Time.deltaTime);
        transform.position = PosicaoDesejada;

        transform.LookAt(Personagem.transform.position);
    }
}
