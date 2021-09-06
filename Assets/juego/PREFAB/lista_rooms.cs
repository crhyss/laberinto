using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lista_rooms : MonoBehaviour
{
    private roomtemplate template;
    void Start()
    {
        template = GameObject.FindGameObjectWithTag("Room").GetComponent<roomtemplate>();
        template.room.Add(this.gameObject);
    }


}
