using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambio : MonoBehaviour
{
    private Clase jobs;
    public Sprite sprite;
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        jobs = GameObject.FindGameObjectWithTag("pj").GetComponent<Clase>();
    }
    void OnTriggerEnter2D(Collider2D cor) {

        if (cor.gameObject.tag == "pj") {
            if (jobs.id == 0) {
                jobs.vidaMAX = 5;
                jobs.velocidad = 6;
                jobs.spriteP = sprite;
                Destroy(gameObject);
            }
        }
    }
}
