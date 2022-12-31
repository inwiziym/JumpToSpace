using UnityEngine;

public class RandomMusic : MonoBehaviour
{
    public AudioClip[] sounds;
    private AudioSource source;

    public void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = sounds[Random.Range(0, sounds.Length)];
        source.PlayOneShot(source.clip);
    }
}
