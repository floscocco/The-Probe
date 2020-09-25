using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abrible : MonoBehaviour
{

    [SerializeField] gotkey reference;
    [SerializeField] GameObject ownreference;
    private void Update()
    {
        if(reference!=null )
        {
            if(reference.key==true)
            {
                ownreference.active = false;
            }
        }
    }
}
