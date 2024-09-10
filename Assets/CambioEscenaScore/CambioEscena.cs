using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI texto_score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int escenaactiva=SceneManager.GetActiveScene().buildIndex;
        if(escenaactiva==0){
        if(Input.GetKeyDown(KeyCode.Space)){
            cambiodeEscena(1);
        }   
    }
    if(escenaactiva==2){
        texto_score.text= PlayerPrefs.GetInt("Score",0).ToString();
    }
    }

    public void cambiodeEscena(int index){
        SceneManager.LoadScene(index);
    }

    public void cambiodeEscena(int index, int score){
        PlayerPrefs.SetInt("Score",score);
        cambiodeEscena(index);
    }
}
