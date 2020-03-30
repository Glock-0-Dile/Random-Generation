using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class westSpawner : MonoBehaviour
{
  public int randomRoom;
  public float roomX;
  public float roomY;
  public float roomZ;
  public GameObject doorPos;
  public GameObject player;
  public float PxPos;
  public float PyPos;
  public float PzPos;
  public Vector3 playerPos;

  public bool doorTouched;

  public GameObject room0;
  public GameObject room1;
  public GameObject room2;
  public GameObject room3;
  public GameObject room4;
  public GameObject room5;
  public GameObject room6;
  public GameObject room7;
  public GameObject room8;
  public GameObject room9;

  public GameObject door;
  public bool roomSpawned;

  void Start()
  {
    getDoorPosition();
    getRandomNumber();
  }

  void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag ("player"))
    {
      randomRoom = 1;
    }
  }

  void Update()
  {
    getDoorPosition();
    if(randomRoom >= 20)
    {
      Instantiate(room0, new Vector3(PxPos + roomX, PyPos + roomY, PzPos + roomZ ), Quaternion.identity);
      randomRoom = 0;
      door.SetActive(false);
    }
    if(randomRoom < 20)
    {
      roomSpawned = false;
    }
  }

  void getDoorPosition()
  {
    playerPos = doorPos.transform.position;
    PxPos = doorPos.transform.position.x;
    PyPos = doorPos.transform.position.y;
    PzPos = doorPos.transform.position.z;
  }
  void getRandomNumber()
  {
    randomRoom = Random.Range(0, 100);
  }
}
