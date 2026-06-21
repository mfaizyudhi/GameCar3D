using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public AudioSource musicSource;
    public Slider volumeSlider;

    void Start()
    {
        volumeSlider.value = musicSource.volume;

        volumeSlider.onValueChanged.AddListener(delegate
        {
            musicSource.volume = volumeSlider.value;
        });
    }
}