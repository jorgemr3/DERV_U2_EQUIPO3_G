using System.Collections;
using UnityEngine;

public class HandleTriggerPeque : MonoBehaviour
{   
    [SerializeField] int conta;
    Vector3 escalaOriginal;
    Transform spawn;
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
            StartCoroutine("corrutinaChiquito(other.gameObject)");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            StopCoroutine("corrutinaChiquito(other.gameObject)");
        }
    }

    IEnumerator corrutinaChiquito(GameObject jugador){
        jugador.transform.localScale = nuevaEscalaPequeña;
         while(conta > 0){
            jugador.GetComponent<Renderer>().material.color = Color.green;
            conta--;
            Debug.Log("Contador para hacerse grande: " + conta);
             yield return new WaitForSeconds(1); 
        }
        jugador.GetComponent<Renderer>().material.color = Color.red;
        conta = 5;
        jugador.transform.localScale = escalaOriginal;
    }
}
