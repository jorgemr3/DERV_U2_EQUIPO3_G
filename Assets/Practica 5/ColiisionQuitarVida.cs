using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColiisionQuitarVida : MonoBehaviour
{
    Transform objQuitaVida;
    TextMeshProUGUI textoVida;
    Transform spawn;
    int vida;
    bool quitarVida = false;

    void Awake()
    {
        objQuitaVida = GameObject.Find("QuitaVida").transform;
        textoVida = GameObject.Find("TextVida").GetComponent<TextMeshProUGUI>();
        spawn = GameObject.Find("spawn").transform;

        vida = int.Parse(textoVida.text);

    }

    void OnCollisionEnter(Collision other)
    {
        if (vida != 1)
        {
            vida--;
            textoVida.text = vida.ToString();
        }
        else
        {
            other.transform.position = spawn.position;
            vida = 5;
            textoVida.text = vida.ToString();
        }
    }

    void Update()
    {
        vida = int.Parse(textoVida.text);
    }

}
