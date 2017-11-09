using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CilindroCollider : MonoBehaviour {

    MeshRenderer renderizador;
    public Rigidbody RigidBodyEsfera;
    //public IAController controladorDeIa;

	// Use this for initialization
	void Start () {
        renderizador = GetComponent<MeshRenderer>();
        //controladorDeIa.speed = 12;
	}

    void OnTriggerEnter(Collider outro) {
        if(outro.gameObject.tag == "Player") {
            renderizador.enabled = false;
            RigidBodyEsfera.useGravity = true;
        }
    }

    void OnTriggerExit(Collider outro) {
        if (outro.gameObject.tag == "Player") {
            renderizador.enabled = true;
            //esfera.SetActive(true);
        }
    }

}
