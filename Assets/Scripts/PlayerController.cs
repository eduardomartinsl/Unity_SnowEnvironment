using UnityEngine;

public class PlayerController : MonoBehaviour {

    [Space]
    [Range(1, 5)]
    public float VelocidadeMovimento = 3;
    [Space]
    public float VelocidadeRotacao = 120;
    public Animator ControladorDeAnimação;

    public void Start() {
        ControladorDeAnimação = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * VelocidadeRotacao * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Vertical") * VelocidadeMovimento * Time.deltaTime;
        transform.Translate(0, 0, vertical);

        Animating(horizontal, vertical);
    }

    private void Animating(float horizontal, float vertical) {
        bool walking = horizontal != 0 || vertical != 0;
        ControladorDeAnimação.SetBool("Andando", walking);
    }
}
