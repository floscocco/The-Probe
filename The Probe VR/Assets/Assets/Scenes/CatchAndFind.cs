using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchAndFind : MonoBehaviour
{
    [SerializeField] GameObject PivotOfHands;
    [SerializeField] public bool emptyHands;
    public GameObject item;
    public GameObject lugarATrepar;
    [SerializeField]GameObject player;


    // Update is called once per frame
    void Update()
    {
       
            if (Input.GetKey(KeyCode.Mouse0))
            {
                print("intento agarrar apretando mouse");
                if (item != null)
                {
                     print("tengo un item:"+item.name);
                     if (emptyHands == true)
                     {
                         print("tengo manos vacias" + item.name);
                         item.GetComponent<objetoMovible>().pick();
                         emptyHands = false;
                     }

                }
                                                
            }


        if (Input.GetKeyUp(KeyCode.Mouse0) )
        {
            print("suelto mouse y dropeo");
            if (item != null)
            {
                item.GetComponent<objetoMovible>().drop();
            }
            emptyHands = true;
            
            
        }

        if (Input.GetKey(KeyCode.F) && emptyHands==false)
        {
           
            var aux=item.GetComponent<IFindeable>();
            if(aux!=null)
            {
                aux.Finded();

            }
        }
        player.GetComponent<CharacterController>().enabled = true;
        if (Input.GetKey(KeyCode.Space) && lugarATrepar!=null)
        {
            print("intento trepar" );
            var aux = lugarATrepar.GetComponent<ObjectToClimb>();
            if (aux != null )
            {
                print("hay aux");
                print("player antes:"+player.transform.position);
                print("nueva pos:" + aux.Trepar().position);
                player.GetComponent<CharacterController>().enabled = false;
                player.transform.position=aux.Trepar().position;
                print("player despues:" + player.transform.position);

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        print("entro en colision" + other.gameObject.name);
        if((other.gameObject.CompareTag("Agarrable")||other.gameObject.CompareTag("AgarrableyTrepable"))&& emptyHands==true)
        {
            item = other.gameObject;
        }
        if (other.gameObject.CompareTag("AgarrableyTrepable") || other.gameObject.CompareTag("Trepable"))   
        {
            lugarATrepar = other.gameObject;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        //print("salio de colision" + collision.gameObject.name);
        if ((other.gameObject.CompareTag("Agarrable")|| other.gameObject.CompareTag("AgarrableyTrepable")) && emptyHands == true)
        {
            item = null;
        }
        if (other.gameObject.CompareTag("AgarrableyTrepable") || other.gameObject.CompareTag("Trepable"))
        {
            lugarATrepar = null;
        }
    }

}
