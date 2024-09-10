using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class s9_contadorconcorrutina : MonoBehaviour
{
    int contador_segundos;
    [SerializeField] TextMeshProUGUI Texto_tiempo;
    // Start is called before the first frame update
    void Start()
    {
        contador_segundos=0;   
        StartCoroutine(corrutinatiempo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator corrutinatiempo(){
        while(true){
            Texto_tiempo.text=contador_segundos++.ToString();
            yield return new WaitForSeconds(1f);
        }
    }
}
