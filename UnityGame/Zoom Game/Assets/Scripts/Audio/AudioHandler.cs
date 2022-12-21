using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AudioHandler : MonoBehaviour
{
    public static AudioHandler Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    [SerializeField] private List<AudioClip> audioClips;
    [SerializeField] private AudioSource audioSource, musicSource, pitchedAudioSource, narratorSource;

    public void PlaySoundEffect(AudioClip _clip)
    {
        audioSource.pitch = 1;
        audioSource.PlayOneShot(_clip);
    }
    public void PlayNarration(AudioClip _clip)
    {
        narratorSource.PlayOneShot(_clip);
    }
    public void PlaySoundRandomPitch(AudioClip _clip, float minPitch, float maxPitch)
    {
        pitchedAudioSource.pitch = Random.Range(minPitch, maxPitch);
        pitchedAudioSource.PlayOneShot(_clip);
    }
    public void ChangeEffectsVolume(float Value)
    {
        audioSource.volume = Value;
        pitchedAudioSource.volume = Value;
    }
    public void ChangeMusicVolume(float Value)
    {
        musicSource.volume = Value;
    }
    public void ToggleSoundEffects()
    {
        audioSource.mute = !audioSource.mute;
    }
    public void ToggleMusic()
    {
        musicSource.mute = !musicSource.mute;
    }
}