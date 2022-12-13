using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleAudio : MonoBehaviour
{
    [SerializeField] private Sprite vol1;
    [SerializeField] private Sprite vol2;
    [SerializeField] private Sprite vol3;
    [SerializeField] private Sprite vol4;
    [SerializeField] private bool _toggleMusic, _toggleEffects;
    [SerializeField] private Slider _slider;
    Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();
    }

    private void Update()
    {
        if (_toggleEffects)
        {
            if (_slider.value == 0)
                _button.image.sprite = vol1;
            if (_slider.value > 0 && _slider.value <= 0.33f)
                _button.image.sprite = vol2;
            if (_slider.value > 0.33f && _slider.value <= 0.67f)
                _button.image.sprite = vol3;
            if (_slider.value > 0.67f && _slider.value <= 1)
                _button.image.sprite = vol4;
        }
    }
    public void ToggleAudioSource()
    {
        if (_toggleEffects)
            AudioHandler.Instance.ToggleSoundEffects();
        if (_toggleMusic)
            AudioHandler.Instance.ToggleMusic();
    }
}
