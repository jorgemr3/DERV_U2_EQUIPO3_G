using System.Collections;
using UnityEngine;

public class HandleTriggerPeque : MonoBehaviour
{   
    int conta;
    Vector3 escalaOriginal;
    private Transform spawn;
    Vector3 nuevaEscalaPequeña;

    void Awake()
    {
        spawn = GameObject.Find("TriggerPeque").transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        conta=5;
        nuevaEscalaPequeña = new Vector3(0.5f,0.5f,0.5f);
        escalaOriginal = new Vector3(1f,1f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            StartCoroutine(corrutinaChiquito(other.gameObject));
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            StopCoroutine(corrutinaChiquito(other.gameObject));
        }
    }

    IEnumerator corrutinaChiquito(GameObject jugador){
        jugador.transform.localScale = nuevaEscalaPequeña;
         while(conta > 0){
            conta--;
            Debug.Log("Contador para hacerse grande: " + conta);
             yield return new WaitForSeconds(1); 
        }
        conta = 5;
        // Espera 5 segundos
        //devolver a escala original 
        jugador.transform.localScale = escalaOriginal;
    }
}
