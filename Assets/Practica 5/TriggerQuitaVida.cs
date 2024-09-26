using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerQuitaVida : MonoBehaviour
{
    private Transform objQuitaVida;

    void Awake()
    {
        objQuitaVida = GameObject.Find("QuitaVida").transform;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
