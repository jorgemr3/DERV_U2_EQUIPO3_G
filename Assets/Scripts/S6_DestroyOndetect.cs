using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S6_DestroyOndetect : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI texto_corto;
    
    int contador;
    // Start is called before the first frame update
    void Start()
    {
     contador =0;   
    }

    // Update is called once per frame
    void Update(){
    }

    private void OnCollisionEnter(Collision other){
        GameObject obj = other.gameObject;
        if(obj.CompareTag("TypeEnemy")){
            Destroy(obj);
            contador++;
            texto_corto.text= contador.ToString();
        }
    }
    
}
