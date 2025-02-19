using UnityEngine;
using UnityEngine.UI; 

public class AnimalSound : MonoBehaviour 
{ 
    private AudioSource audioSource; 
    private bool isMouseOver = false; 

    // Добавляем ссылку на текстовую подсказку
    public GameObject tooltip; 

    void Start() 
    { 
        audioSource = GetComponent<AudioSource>(); 
        audioSource.volume = PlayerPrefs.GetFloat("AnimalVolume", 1f);  
        
        if (tooltip != null)
        {
            tooltip.SetActive(false);
        }
    } 

    void OnMouseOver() 
    { 
        isMouseOver = true;


        if (tooltip != null)
        {
            tooltip.SetActive(true);
            tooltip.GetComponent<Text>().text = "Крутите, чтобы увидеть с разных сторон"; 
        }
    }

    void OnMouseExit() 
    { 
        isMouseOver = false;

        if (tooltip != null)
        {
            tooltip.SetActive(false);
        }
    }

    void Update() 
    { 
        if (isMouseOver)
        {
            if (tooltip != null)
            {
                Vector3 mousePos = Input.mousePosition;
                tooltip.transform.position = new Vector3(mousePos.x, mousePos.y + 30, 0); 
            }

            if (Input.GetMouseButton(0)) 
            { 
                float mouseX = Input.GetAxis("Mouse X"); 
                transform.Rotate(Vector3.up, mouseX * 5); 

                if (tooltip != null)
                {
                    tooltip.SetActive(false);
                }
            }
        }
    } 

    public void SetVolume(float volume) 
    { 
        if (audioSource != null) 
        { 
            audioSource.volume = volume; 
        } 
    } 
}
