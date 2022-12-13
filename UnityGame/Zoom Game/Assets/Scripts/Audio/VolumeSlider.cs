using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private bool _musicVolume, _effectsVolume;


    private void Awake()
    {
        AudioHandler.Instance.ChangeEffectsVolume(_slider.value);
        AudioHandler.Instance.ChangeMusicVolume(_slider.value);
    }
    void Start()
    {

        if (_effectsVolume)
            _slider.onValueChanged.AddListener(value => AudioHandler.Instance.ChangeEffectsVolume(value));
        
        if (_musicVolume)
            _slider.onValueChanged.AddListener(value => AudioHandler.Instance.ChangeMusicVolume(value));
        
    }
}

