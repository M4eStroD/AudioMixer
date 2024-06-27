using UnityEngine;
using UnityEngine.Audio;

public class ButtonSounds : MonoBehaviour
{
    private const int VolumeOff = -80;

    [SerializeField] private AudioSource _sound;
    [SerializeField] private AudioMixer _audioMixer;

    private float _lastMasterVolume = 0;

    public void OnOffSound()
    {
        if (_sound.isPlaying)
            _sound.Stop();
        else
            _sound.Play();
    }

    public void OffAllSound()
    {
        _audioMixer.GetFloat(SoundsData.Params.MasterVolume, out float value);

        if (value == VolumeOff)
        {
            _audioMixer.SetFloat(SoundsData.Params.MasterVolume, _lastMasterVolume);
        }
        else
        {
            _audioMixer.SetFloat(SoundsData.Params.MasterVolume, VolumeOff);
            _lastMasterVolume = value;
        }
    }
}

