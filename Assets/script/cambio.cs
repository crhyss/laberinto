using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambio : MonoBehaviour
{
    private Clase jobs;
    public Sprite sprite;
    public GameObject oficio;
    public int id;

    void Start()
    {
 
    }


    void Update()
    {
        jobs = GameObject.FindGameObjectWithTag("pj").GetComponent<Clase>();
    }
    void OnTriggerEnter2D(Collider2D cor) {

        if (cor.gameObject.tag == "pj") {
            if (id == 0) {
                Instantiate(oficio, jobs.transform.position,Quaternion.identity,jobs.transform);
                clon(5, 4, 2);
            }
            else if (id == 1)
            {
                Instantiate(oficio, jobs.transform.position, Quaternion.identity, jobs.transform);
                transform.position = new Vector2(jobs.transform.position.x, jobs.transform.position.y + 0.1f);
                clon(10,6,3);
            }
            Destroy(this);
        }

    }
    private void clon(float vida,float velocidad,int ataque) {
        jobs.vidaMAX = vida;
        jobs.velocidad = velocidad;
        jobs.daño = ataque;
        Destroy(this.gameObject);
        
    }
}
