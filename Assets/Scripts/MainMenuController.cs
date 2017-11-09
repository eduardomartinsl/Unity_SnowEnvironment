using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {

    //public Image IniciarButton;
    //public Image SairButton;
    //public Sprite SelectDraw;

    // Use this for initialization
    void Start () {
        //IniciarButton = gameObject.GetComponent<Image>();
        //SairButton = gameObject.GetComponent<Image>();

        //SelectDraw.color = new Color(189, 189, 189, 255); //Setando a cor acinzentada do menu

	}

    public void OnPointerEnter()
    {
        Debug.Log("Entrou");
    }

    public void OnMouseEnter()
    {
        //this.gameObject.GetComponent<Image>().sprite = SelectDraw;
        Debug.Log("Entrou");
    }

    public void OnMouseExit()
    {
        //this.gameObject.GetComponent<Image>().sprite = null;
        Debug.Log("Saiu");

    }

    // Update is called once per frame
    void Update () {
		
	}

}
