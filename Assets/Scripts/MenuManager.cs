using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject contentPage;
    public GameObject contentPage2;
    public GameObject settingsPage;
    public GameObject[] animalPages; 

    private int currentAnimalIndex = 0;

    void Start()
    {
        ShowMainMenu(); 
    }

    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        contentPage.SetActive(false);
        contentPage2.SetActive(false);
        settingsPage.SetActive(false);

        foreach (GameObject page in animalPages)
        {
            page.SetActive(false);
        }
    }

    public void ShowContentPage()
    {
        mainMenu.SetActive(false);
        contentPage.SetActive(true);
        contentPage2.SetActive(false);
        settingsPage.SetActive(false);

        foreach (GameObject page in animalPages)
        {
            page.SetActive(false);
        }
    }

    public void ShowContentPage2()
    {
        mainMenu.SetActive(false);
        contentPage.SetActive(false);
        contentPage2.SetActive(true);
        settingsPage.SetActive(false);

        foreach (GameObject page in animalPages)
        {
            page.SetActive(false);
        }
    }

    public void ShowSettings()
    {
        mainMenu.SetActive(false);
        contentPage.SetActive(false);
        contentPage2.SetActive(false);
        settingsPage.SetActive(true);

        foreach (GameObject page in animalPages)
        {
            page.SetActive(false);
        }
    }

    public void StartGame()
    {
        mainMenu.SetActive(false);
        currentAnimalIndex = 0;
        ShowAnimalPage(currentAnimalIndex);
    }

    public void ShowAnimalPage(int index)
    {
        if (index < 0 || index >= animalPages.Length) return;

        foreach (GameObject page in animalPages)
        {
            page.SetActive(false);
        }

        contentPage.SetActive(false);
        contentPage2.SetActive(false);
        settingsPage.SetActive(false);

        animalPages[index].SetActive(true);
        currentAnimalIndex = index;
    }

    public void NextAnimal()
    {
        if (currentAnimalIndex < animalPages.Length - 1)
        {
            currentAnimalIndex++;
            ShowAnimalPage(currentAnimalIndex);
        }
    }

    public void PreviousAnimal()
    {
        if (currentAnimalIndex > 0)
        {
            currentAnimalIndex--;
            ShowAnimalPage(currentAnimalIndex);
        }
    }

    public void ReturnToMainMenu()
    {
        currentAnimalIndex = 0;
        ShowMainMenu();
    }

    public void ExitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
