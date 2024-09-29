using System.Collections;
using TMPro;
using UnityEngine;

public class TriggerAumentarVida : MonoBehaviour
{
    Transform objAumentarVida;
    TextMeshProUGUI textoVida;

    Transform spawn;

    int vida;

    bool aumentarVida = false;

    void Start()
    {
        vida = int.Parse(textoVida.text);
    }

    void Awake()
    {
        objAumentarVida = GameObject.Find("AumentarVida").transform;
        textoVida = GameObject.Find("TextVida").GetComponent<TextMeshProUGUI>();
        spawn = GameObject.Find("spawn").transform;


    }


    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Jugador") && !aumentarVida)
        {
            StartCoroutine(AumentarVida(other));
        }
    }

    IEnumerator AumentarVida(Collider other)
    {
        aumentarVida = true;

        if (vida != 5)
        {
            vida++;
            textoVida.text = vida.ToString();
        }
        yield return new WaitForSeconds(1f);
        aumentarVida = false;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            StopAllCoroutines();
            aumentarVida = false;
        }

    }

    void Update()
    {
        vida = int.Parse(textoVida.text);
    }


}
