using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;
public class Clase : MonoBehaviour
{
    public int id;
    public string nombre;
    public Image BarraVida;
    public float vidaActual;
    public float vidaMAX;
    public int estamina;
    public int daño;
    public float velocidad = 4f;
    public Sprite spriteP;
    public SortingLayer layer;


//    Animator anim;
Rigidbody2D rb2d;
Vector2 mov;

// Start is called before the first frame update
void Start()
{

        //        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
}

// Update is called once per frame
void Update()
{
    mov = new Vector2(
        Input.GetAxisRaw("Horizontal"),
        Input.GetAxisRaw("Vertical")
        );
        this.gameObject.GetComponent<SpriteRenderer>().sprite = spriteP;
        BarraVida.fillAmount = vidaActual / vidaMAX;
        rb2d.MovePosition(rb2d.position + mov * velocidad * Time.deltaTime);
    }
    
}
