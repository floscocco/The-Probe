using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetToFind : MonoBehaviour,IFindeable
{
    [SerializeField]ListadeObjetos ReferenceToList;
    [SerializeField] string objectName;
    [SerializeField] AudioSource mysound;
    [SerializeField] GameObject newReference;

    public void Finded()
    {
        print("encontrado" + this.name);
        if(ReferenceToList.objectsToFind.Remove(objectName))
        {
            mysound.Play();
            gameObject.SetActive(false);

            if(objectName=="Llave")
            {
                ReferenceToList.objectsToFind.Add("Cofre");
            }
            if (objectName == "Cofre")
            {
                ReferenceToList.objectsToFind.Add("Teclado");
                newReference.GetComponent<aparition>().Aparecer();
            }
        }

    }

   
}
