using UnityEngine;
using UnityEngine.Audio;

public class SliderSound : MonoBehaviour
{
    [SerializeField] private AudioMixer _mixer;
    [SerializeField] private TypeSound _type;

    public void ChangeVolume(float volume)
    {
        if (SoundsData.TypeVolume.ContainsKey(_type))
            _mixer.SetFloat(SoundsData.TypeVolume[_type], Mathf.Log10(volume) * 20);
    }
}
