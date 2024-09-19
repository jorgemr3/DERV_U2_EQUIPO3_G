using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersDetects : MonoBehaviour
{
    private void OnTriggersEnter(Collider others){
        Debug.Log(""+others.gameObject.name);
    }

    private void onTriggersStay(Collider others){
        Debug.Log(""+others.gameObject.name);
    }
    
    private void onTriggersExit(Collider others){
        Debug.Log(""+others.gameObject.name);
    }
}