using UnityEngine; 
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 
 
public class SettingsManager : MonoBehaviour 
{ 
    public AudioSource backgroundMusic; 
 
    public Slider animalVolumeSlider; 
    public Slider musicVolumeSlider; 
 
    private void Start() 
    { 
        animalVolumeSlider.value = PlayerPrefs.GetFloat("AnimalVolume", 1f); 
        musicVolumeSlider.value = PlayerPrefs.GetFloat("MusicVolume", 1f); 
 
        animalVolumeSlider.onValueChanged.AddListener(SetAnimalVolume); 
        musicVolumeSlider.onValueChanged.AddListener(SetMusicVolume); 
    } 
 
    public void SetAnimalVolume(float volume) 
    { 
        foreach (var animal in FindObjectsOfType<AnimalSound>()) 
        { 
            animal.SetVolume(volume); 
        } 
        PlayerPrefs.SetFloat("AnimalVolume", volume); 
    } 
 
    public void SetMusicVolume(float volume) 
    { 
        backgroundMusic.volume = volume; 
        PlayerPrefs.SetFloat("MusicVolume", volume); 
    } 
 
    public void GoToMenu() 
    { 
        SceneManager.LoadScene("Menu"); 
    } 
}