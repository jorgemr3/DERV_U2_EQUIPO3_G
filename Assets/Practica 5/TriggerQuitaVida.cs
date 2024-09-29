using System.Collections;
using TMPro;
using UnityEngine;


public class TriggerQuitaVida : MonoBehaviour
{
    Transform objQuitaVida;
    TextMeshProUGUI textoVida;
    Transform spawn;
    int vida;
    bool quitarVida = false;

    void Start()
    {
        vida = int.Parse(textoVida.text);
    }

    void Awake()
    {
        objQuitaVida = GameObject.Find("QuitaVida").transform;
        textoVida = GameObject.Find("TextVida").GetComponent<TextMeshProUGUI>();
        spawn = GameObject.Find("spawn").transform;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Jugador") && !quitarVida)
        {
            StartCoroutine(QuitarVida(other));
        }
    }

    IEnumerator QuitarVida(Collider other)
    {
        quitarVida = true;

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
        yield return new WaitForSeconds(1f);
        quitarVida = false;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            StopAllCoroutines();
            quitarVida = false;
        }

    }

    void Update()
    {
        vida = int.Parse(textoVida.text);
    }

}
