using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomtemplate : MonoBehaviour
{
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    public GameObject closedRoom;
    public List<GameObject> room;
    public GameObject boss;

    private void Start()
    {
        Invoke("SpawnEnemigos",3f);
    }
    void SpawnEnemigos() {
        Instantiate(boss, room[room.Count - 1].transform.position,Quaternion.identity);
    }
}
