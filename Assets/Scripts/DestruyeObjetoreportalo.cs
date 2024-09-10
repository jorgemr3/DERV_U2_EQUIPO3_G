using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DestruyeObjetoreportalo : MonoBehaviour
{
    public int contador_enemigo;
    [SerializeField] TextMeshProUGUI contadorenemigo;
    // Start is called before the first frame update
    void Start()
    {
     contador_enemigo=0;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other){
        GameObject obj = other.gameObject;
        if(obj.CompareTag("TypeEnemy")){
            Destroy(obj);
            contador_enemigo++;
            contadorenemigo.text="enemigos: "+contador_enemigo.ToString();
        }
    }
}
