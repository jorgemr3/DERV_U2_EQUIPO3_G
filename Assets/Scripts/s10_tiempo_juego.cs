using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class s10_tiempo_juego : MonoBehaviour
{
    [SerializeField] DestruyeObjetoreportalo acceso_score;
    [SerializeField] CambioEscena aux; //ocupa vincular componente por inspector
    int contador_segundos;
    [SerializeField] TextMeshProUGUI Texto_tiempo;
    // Start is called before the first frame update
    void Start()
    {
        contador_segundos=5;   
        StartCoroutine(corrutinatiempo());
    }
    IEnumerator corrutinatiempo(){
        while(contador_segundos>0){
            Texto_tiempo.text=contador_segundos--.ToString();
            yield return new WaitForSeconds(0.25f);
        }
        Debug.Log("el juego terminó xd");
        int score = acceso_score.contador_enemigo;
        aux.cambiodeEscena(2,score); 
    }   
}