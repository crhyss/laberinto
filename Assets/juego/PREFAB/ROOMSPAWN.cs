using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROOMSPAWN : MonoBehaviour
{
    public int openSide;
    private roomtemplate template;
    private int rand;
    private bool spawned = false;
    void Start()
    {
        template = GameObject.FindGameObjectWithTag("Room").GetComponent<roomtemplate>();
        Invoke("Spawn", 0.1f);
    }

    void Spawn() {
        if (spawned == false) {

            if (openSide == 1)
            {
                //Need Bottom door
                rand = Random.Range(0, template.bottomRooms.Length);
                Instantiate(template.bottomRooms[rand], transform.position, template.bottomRooms[rand].transform.rotation);
            }
            else if (openSide == 2)
            {
                //Top
                rand = Random.Range(0, template.topRooms.Length);
                Instantiate(template.topRooms[rand], transform.position, template.topRooms[rand].transform.rotation);
            }
            else if (openSide == 3)
            {
                //leftRooms
                rand = Random.Range(0, template.leftRooms.Length);
                Instantiate(template.leftRooms[rand], transform.position, template.leftRooms[rand].transform.rotation);
            }
            else if (openSide == 4)
            {
                //rightRooms
                rand = Random.Range(0, template.rightRooms.Length);
                Instantiate(template.rightRooms[rand], transform.position, template.rightRooms[rand].transform.rotation);
            }
            spawned = true;
        }
    }
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("spawn")) 
        {
            if (other.GetComponent<ROOMSPAWN>().spawned==false && spawned==false) {
                Instantiate(template.closedRoom, transform.position, Quaternion.identity);
                Destroy(other.gameObject);
            }
            spawned = true;
        }
    }
}
