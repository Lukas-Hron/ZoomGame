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
    [SerializeField] private AudioSource audioSource, musicSource;

    private void Start()
    {
        //audioSource = GetComponent<AudioSource>();
        //musicSource = GetComponent<AudioSource>();
    }

    public void PlaySoundEffect(AudioClip _clip)
    {
        audioSource.PlayOneShot(_clip);
    }
    public void MenuButtonHover()
    {
        audioSource.PlayOneShot(audioClips[0]);
    }
    public void MenuButtonClick()
    {
        audioSource.PlayOneShot(audioClips[1]);
    }
    public void StartBackgroundMusic()
    {
        audioSource.PlayOneShot(audioClips[2]);
    }
    public void StartAudio()
    {
        audioSource.PlayOneShot(audioClips[3]);
    }
    public void ChangeEffectsVolume(float Value)
    {
        audioSource.volume = Value;
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