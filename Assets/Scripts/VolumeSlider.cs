using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeSlider : MonoBehaviour
{
    
    public Slider backgroundVolumeSlider; 
    public Slider animalVolumeSlider; 
    public Slider fontSizeSlider; 

    
    public TextMeshProUGUI backgroundVolumeText; 
    public TextMeshProUGUI animalVolumeText; 
    public TextMeshProUGUI fontSizeText; 

    void Start()
    {
        
        UpdateBackgroundVolumeText(backgroundVolumeSlider.value);
        UpdateAnimalVolumeText(animalVolumeSlider.value);
        UpdateFontSizeText(fontSizeSlider.value);

        
        backgroundVolumeSlider.onValueChanged.AddListener(UpdateBackgroundVolumeText);
        animalVolumeSlider.onValueChanged.AddListener(UpdateAnimalVolumeText);
        fontSizeSlider.onValueChanged.AddListener(UpdateFontSizeText);
    }

    
    void UpdateBackgroundVolumeText(float value)
    {
        float adjustedValue = value * 100; 
        backgroundVolumeText.text = adjustedValue.ToString("0");
        
    }

    
    void UpdateAnimalVolumeText(float value)
    {
        float adjustedValue = value * 100; 
        animalVolumeText.text = adjustedValue.ToString("0");
        
    }

    
    void UpdateFontSizeText(float value)
    {
        fontSizeText.text = value.ToString("0");
        
    }
}
