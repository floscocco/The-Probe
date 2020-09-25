using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    [SerializeField]Material myMaterial;
    [SerializeField] string scene;
    Color myColour;
    private void Start()
    {
        myColour = myMaterial.color;
    }

    private void Update()
    {
       myMaterial.color =  new Color(1,0,0, Mathf.Sin(Time.time));
        //print(Mathf.Sin(Time.time));

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(scene);
        }
    }
}
