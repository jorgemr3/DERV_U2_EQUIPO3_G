using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruyeobjeto : MonoBehaviour
{
    private void OnCollisionEnter(Collision other){
        GameObject obj = other.gameObject;
        if(obj.CompareTag("Enemy")){
            Destroy(obj);
        }
    }
}
