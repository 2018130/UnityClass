using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip[] audioClips;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void VolumeControl(float newVolume)
    {
        audioSource.volume = newVolume;
        Debug.Log("volume : " + audioSource.volume);
    }

    public void SoundCall(string name)
    {
        switch (name)
        {
            case "Siren":
                audioSource.clip = audioClips[0];
                break;
            case "Explosion":
                audioSource.clip = audioClips[1];
                break;
            case "Magic":
                audioSource.clip = audioClips[2];
                break;
        }

        if (audioSource.clip != null)
        {
            audioSource.Play();
            Debug.Log(audioSource.clip + " 재생중");
        }
    }
}
