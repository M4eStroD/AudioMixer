using System.Collections.Generic;

public static class SoundsData
{
    public static readonly Dictionary<TypeSound, string> TypeVolume = new Dictionary<TypeSound, string>()
    {
        { TypeSound.MasterVolume, "MasterVolume" },
        { TypeSound.MusicVolume, "MusicVolume" },
        { TypeSound.EffectVolume, "EffectVolume" }
    };
}
