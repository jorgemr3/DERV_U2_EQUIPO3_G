using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColissionDetects : MonoBehaviour
{
    private void onColissionEnter(Collision others){
        Debug.Log(""+others.gameObject.name);
    }

    private void onColissionStay(Collision others){
        Debug.Log(""+others.gameObject.name);
    }
    
    private void onColissionExit(Collision others){
        Debug.Log(""+others.gameObject.name);
    }
}
