using System.Collections;
using UnityEngine;

public class HandleTrigger : MonoBehaviour
{
    int contador;
    Vector3 nuevaEscalaGrande;
    private Transform spawn;

    Vector3 escalaOriginal;



    void Awake()
    {
        spawn = GameObject.Find("TriggerGrande").transform;

    }
    void Start()
    {
        contador = 5;
        nuevaEscalaGrande = new Vector3(3f, 3f, 3f);
        escalaOriginal = new Vector3(1f, 1f, 1f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            StartCoroutine(corrutinaGigante(other.gameObject));
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            StopCoroutine(corrutinaGigante(other.gameObject));
        }
    }



    IEnumerator corrutinaGigante(GameObject jugador)
    {
        jugador.transform.localScale = nuevaEscalaGrande;
        while (contador > 0 )
        {
            contador--;
            Debug.Log("Contador para hacerse grande: " + contador);
            yield return new WaitForSeconds(1);
        }
        contador =  5;  
        //devolver a escala original 
        jugador.transform.localScale = escalaOriginal;
    }


}
