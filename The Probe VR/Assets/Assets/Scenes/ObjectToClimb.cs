using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToClimb : MonoBehaviour, ITrepable
{
    [SerializeField] Transform pivot;
    public Transform Trepar()
    {
        return pivot;
    }
}
