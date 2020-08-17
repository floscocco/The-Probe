using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterDoor : MonoBehaviour
{
    [SerializeField] GameObject PivotOfHands;
    [SerializeField] public bool emptyHands;
    public GameObject door;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Mouse0))
        {
            print("intento agarrar apretando mouse");
            if (door != null)
            {
                print("tengo un item:" + door.name);

                door.GetComponent<door>().EnterDoor();

            }

        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        print("entro en colision" + other.gameObject.name);
        if (other.gameObject.CompareTag("Puerta"))
        {
            door = other.gameObject;
        }
       
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Puerta"))
        {
            door = null;
        }
       
    }
}
