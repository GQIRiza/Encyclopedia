using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextManager : MonoBehaviour
{
    public TMP_Text[] descriptionTexts;
    public Slider textSizeSlider; 

    private void Start()
    {
        float savedSize = PlayerPrefs.GetFloat("TextSize", 36f); 
        textSizeSlider.value = savedSize; 
        textSizeSlider.onValueChanged.AddListener(SetTextSize); 
        SetTextSize(savedSize); 
    }

    public void SetTextSize(float size)
    {

        foreach (TMP_Text text in descriptionTexts)
        {
            text.fontSize = size; 
        }
        PlayerPrefs.SetFloat("TextSize", size); 
    }
}
