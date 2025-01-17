using UnityEngine;
using UnityEngine.UI;

public class VolumePercentage : MonoBehaviour
{
    [SerializeField] private string valueToStore;
    [SerializeField] private Text volumePercentageText;
    private Slider slider;

    private void Start()
    {
        slider = GetComponent<Slider>();
        if (PlayerPrefs.HasKey(valueToStore))
            slider.value = PlayerPrefs.GetFloat(valueToStore);
        else
            slider.value = 1;

        volumePercentageText.text = ((int)(slider.value * 100)).ToString() + "%";
    }

    public void UpdateVolumeValue()
    {
        volumePercentageText.text = ((int)(slider.value * 100)).ToString() + "%";
        PlayerPrefs.SetFloat(valueToStore, slider.value);
        PlayerPrefs.Save();
    }
}
