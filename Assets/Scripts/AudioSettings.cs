using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    private const float MaxVolume = 0f;
    private const float MinVolume = -80.0f;
    private const string SoundsVolume = nameof(SoundsVolume);
    private const string MasterVolume = nameof(MasterVolume);
    private const string MusicVolume = nameof(MusicVolume);

    [SerializeField] private AudioMixer _mixer;
    [SerializeField] private Slider _masterVolume;

    private bool _isMasterEnabled = true;

    public void SetSoundsVolume(float amount)
    {
        _mixer.SetFloat(SoundsVolume, Mathf.Lerp(MinVolume, MaxVolume, amount));
    }

    public void SetMusicVolume(float amount)
    {
        _mixer.SetFloat(MusicVolume, Mathf.Lerp(MinVolume, MaxVolume, amount));
    }

    public void SetMasterVolume(float amount)
    {
        if (_isMasterEnabled)
        {
            _mixer.SetFloat(MasterVolume, Mathf.Lerp(MinVolume, MaxVolume, amount));
        }
    }

    public void ToggleMaster(bool isEnabled)
    {
        _isMasterEnabled = isEnabled;

        if (_isMasterEnabled)
        {
            SetMasterVolume(_masterVolume.value);
        }
        else
        {
            _mixer.SetFloat(MasterVolume, MinVolume);
        }
    }
}
