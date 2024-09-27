using System.Transactions;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    public AudioClip newTrack;
    private AudioSource audioSource;

    Transform spawn;


     void Awake()
    {
        spawn = GameObject.Find("TriggerSonido").transform;  //nombre del trigger
    }
    
    void Start()
    {

        audioSource = GetComponent<AudioSource>();
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
