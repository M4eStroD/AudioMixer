using UnityEngine;
using UnityEngine.Audio;

public class SliderSound : MonoBehaviour
{
    [SerializeField] private AudioMixer _mixer;

    [SerializeField] private TypeSound _type;

    public void ChangeVolume(float volume)
    {
        switch (_type)
        {
            case TypeSound.MasterVolume:
                _mixer.SetFloat(SoundsData.Params.MasterVolume, Mathf.Log10(volume) * 20);
                break;

            case TypeSound.MusicVolume:
                _mixer.SetFloat(SoundsData.Params.MusicVolume, Mathf.Log10(volume) * 20);
                break;

            case TypeSound.EffectVolume:
                _mixer.SetFloat(SoundsData.Params.EffectVolume, Mathf.Log10(volume) * 20);
                break;

            default:
                break;
        };
    }
}
