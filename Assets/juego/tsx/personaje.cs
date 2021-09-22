using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class personaje : MonoBehaviour
{

    public float speed = 4f;
    public GameObject clase;
   


    Rigidbody2D rb2d;
    Vector2 mov;  // Ahora es visible entre los métodos


    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();



    }

    void Update()
    {

        // Detectamos el movimiento
        Movements();


    }

    void FixedUpdate()
    {
        // Nos movemos en el fixed por las físicas
        rb2d.MovePosition(rb2d.position + mov * speed * Time.deltaTime);
    }

    void Movements()
    {
        // Detectamos el movimiento en un vector 2D
        mov = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );
    }


}