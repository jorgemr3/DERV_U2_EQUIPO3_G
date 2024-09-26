using System.Transactions;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    //GameObject ola;
    public AudioClip newTrack;
    private AudioSource audioSource;

    Transform spawn;


     void Awake()
    {
        spawn = GameObject.Find("TriggerSonido").transform;  //nombre del trigger
    }
    
    void Start()
    {
        //ola.transform.localScale = new Vector3(1f, 1f, 1f);
        //newTrack = GetComponent<AudioClip>();
        audioSource = FindObjectOfType<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jugador") && newTrack != null)
        {
            audioSource.clip = newTrack;
            audioSource.Play();
        }
    }
}
