using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListadeObjetos : MonoBehaviour
{
    [SerializeField] public List<string> objectsToFind;
    [SerializeField] GameObject portal;
    [SerializeField] Text hud;

    // Start is called before the first frame update
    private void Update()
    {
        var texto = "Lista de Objetos:\n";
        for (int i = 0; i < objectsToFind.Count; i++)
        {
            texto = texto + objectsToFind[i] + "\n";
        }
        
        hud.text = texto;
        if(objectsToFind.Count==0)
        {
            portal.SetActive(true);
            hud.text = "Ingresa en el portal para volver a el subconsiente";
          
        }
    }
}
