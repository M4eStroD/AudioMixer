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
        string typeSound = SoundsData.TypeVolume[TypeSound.MasterVolume];

        _audioMixer.GetFloat(typeSound, out float value);

        if (value == VolumeOff)
        {
            _audioMixer.SetFloat(typeSound, _lastMasterVolume);
        }
        else
        {
            _audioMixer.SetFloat(typeSound, VolumeOff);
            _lastMasterVolume = value;
        }
    }
}

