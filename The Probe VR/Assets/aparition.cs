using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aparition : MonoBehaviour
{
    [SerializeField] GameObject referencia;

    public void Aparecer()
    {
        referencia.SetActive(true);
    }
}
