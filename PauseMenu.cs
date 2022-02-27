using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;
    //Oyun içi sesler
    public AudioSource beach;
    private float beachV = 1f;
    public AudioSource forest;
    private float forestV = 1f;
    public AudioSource mountain;
    private float mountainV = 1f;
    public AudioSource desert;
    private float desertV = 1f;
    public AudioSource garden;
    private float gardenV = 1f;
    void Start()
    {
        pauseMenu.SetActive(false);    
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else if (!isPaused)
            {
                PauseGame();
            }
        }
        beach.volume = beachV;
        forest.volume = forestV;
        mountain.volume = mountainV;
        desert.volume = desertV;
        garden.volume = gardenV;
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        Cursor.lockState = CursorLockMode.Confined;
        
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        isPaused = false;
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main menu");
    }

    public void SetVolumeBeach(float volume)
    {
        beachV = volume;
    }
    public void SetVolumeForest(float volume)
    {
        forestV = volume;
    }
    public void SetVolumeMountain(float volume)
    {
        mountainV = volume;
    }
    public void SetVolumeDesert(float volume)
    {
        desertV = volume;
    }
    public void SetVolumeGarden(float volume)
    {
        gardenV = volume;
    }
}
