using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetoMovible : MonoBehaviour,IMove
{   [SerializeField]GameObject pivot;
    public bool agarrado = false;
    public void drop()
    {
        agarrado = false;
        GetComponent<Rigidbody>().isKinematic = false;
    }

    public void pick()
    {
        agarrado = true;
        GetComponent<Rigidbody>().isKinematic=true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(agarrado)
        {
            transform.position = pivot.transform.position;
        }
    }
}
