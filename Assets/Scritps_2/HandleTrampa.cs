using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleTrampa : MonoBehaviour
{
    float tiempo_en_trigger;
    float tiempo_para_nuevo_enemigo;

    Transform spawn;

    int contador_enemigo_actual;
    [SerializeField] List<GameObject> lista_enemigos;
    // Start is called before the first frame update

    void Awake(){
        spawn = GameObject.Find("SpawnEnemigos").transform;
    }
    void Start()
    {
            tiempo_en_trigger = 1;
            contador_enemigo_actual = 3; //en funcion del numero se mueve el enemigo 
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Jugador")){
            StartCoroutine(corrutina());
        }
    }
    private void OnTriggerExit(Collider other){    
         if(other.CompareTag("Jugador")){
            StopCoroutine(corrutina());
        }
        }
    
    
    /*private void OnTriggerStay(Collider other){
        tiempo_en_trigger += Time.deltaTime;
        if(tiempo_en_trigger > tiempo_para_nuevo_enemigo){
            lista_enemigos[contador_enemigo_actual].transform.position = spawn.position;
             lista_enemigos[contador_enemigo_actual].GetComponent<Rigidbody>().AddForce( -1 * 3f* transform.up , ForceMode.Impulse);
            contador_enemigo_actual++;
            contador_enemigo_actual%= contador_enemigo_actual;
            //genera enemigo
            tiempo_en_trigger=0;
        }
    }*/

    IEnumerator corrutina(){
      tiempo_en_trigger += Time.deltaTime;
            lista_enemigos[contador_enemigo_actual].transform.position = spawn.position;
             lista_enemigos[contador_enemigo_actual].GetComponent<Rigidbody>().AddForce( -1 * 3f* transform.up , ForceMode.Impulse);
            contador_enemigo_actual++;
            contador_enemigo_actual%=contador_enemigo_actual; //checar luego
            tiempo_en_trigger=0;

        yield return new WaitForSeconds(tiempo_para_nuevo_enemigo);
    }
}
