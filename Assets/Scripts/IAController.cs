using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class IAController: MonoBehaviour {
    public float speed = 1.4f;
    public float directionChangeInterval = 1;
    public float maxHeadingChange = 30;
    public float JumpStrgh = 3;

    CharacterController controller;
    float heading;
    Vector3 targetRotation;
    bool Initialized;
    bool ContactWithPlayer = false;

    void Awake() {
        Initialized = false;
        controller = GetComponent<CharacterController>();
        ApplyNewHeading();
        Initialized = !Initialized;
    }

    public void ApplyNewHeading() {
        heading = Random.Range(0, 360);
        transform.eulerAngles = new Vector3(0, heading, 0);

        StartCoroutine(NewHeading());
    }

    void Update() {
        transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, targetRotation, Time.deltaTime * directionChangeInterval);
        var forward = transform.TransformDirection(Vector3.forward);
        if (!ContactWithPlayer) {
            controller.SimpleMove(forward * speed);
        }

        //IMPLEMENTAR TESTE DE PULO DE IA

        //if (Controlador.isGrounded) {
        //    _direcaoDeMovimento = new Vector3(0, Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
        //    _direcaoDeMovimento = transform.TransformDirection(_direcaoDeMovimento);
        //    _direcaoDeMovimento *= Velocidade;
        //    if (Input.GetButton("Jump")/* && _animacao.GetBool ("Andando")*/) {
        //        _direcaoDeMovimento.y = Velocidade_Pulo;
        //        _animacao.SetTrigger("Pulando_Andando");

        //    }
        //}
        //_direcaoDeMovimento.y -= Gravidade * Time.deltaTime;
        //Controlador.Move(_direcaoDeMovimento * Time.deltaTime);
        //ExecutaAnimacaoDeAndar(_direcaoDeMovimento.x);

        //FIM DE CÓDIGO DE PULO

        //deu errado

        //if (Input.GetButton("Jump")) {
        //    Debug.Log("Pulou");
        //    var up = transform.TransformDirection(Vector3.up);
        //    controller.SimpleMove(up * JumpStrgh);
        //}
    }

    void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.gameObject.tag == "LimiteAcampamento" || hit.gameObject.tag == "PropsAcampamento" || hit.gameObject.tag == "CubeIA") { 
            ApplyNewHeading();
        }
    }

    IEnumerator NewHeading() {
        while (true) {
            NewHeadingRoutine();
            //yield return new WaitForSeconds(directionChangeInterval);
            yield return new WaitForSeconds(Random.Range(1, 3));

        }
    }
    
    void NewHeadingRoutine() {
        var floor = Mathf.Clamp(heading - maxHeadingChange, 0, 360);
        var ceil = Mathf.Clamp(heading + maxHeadingChange, 0, 360);
        heading = Random.Range(floor, ceil);
        targetRotation = new Vector3(0, heading, 0);
    }

    void OnTriggerEnter(Collider collider) {
        //Debug.Log("tag do objeto de colisão: " + collider.gameObject.tag);
        //Debug.Log("nome do objeto de colisão: " + collider.gameObject.name);

        if (collider.gameObject.tag == "Player") {
            ContactWithPlayer = true;
        }
    }

    void OnTriggerExit(Collider collider) {
        if (collider.gameObject.tag == "Player") {
            ContactWithPlayer = false;
        }
    }

}