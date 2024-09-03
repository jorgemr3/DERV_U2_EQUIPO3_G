using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S2_movlocal : MonoBehaviour
{
    [SerializeField] float velocidad = 0.001f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.W)){
            transform.position+=transform.forward * velocidad * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(transform.forward * velocidad *-1 * Time.deltaTime);
        }
        /*
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.back * velocidad * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }*/
    }
}
