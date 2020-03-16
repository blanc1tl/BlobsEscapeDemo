using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

//Author: Collin Van Brabant

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenu;     //Gets the container for the main menu
    public GameObject optionsMenu;  //Gets the container for the options menu
    public Slider musicVolume;
    public AudioMixer mixer;

    void Start()
    {
        musicVolume.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
    }

    public void updateMusicVolume()
    {
        float value = musicVolume.value;
        PlayerPrefs.SetFloat("MusicVolume", value);
        mixer.SetFloat("MusicVol", Mathf.Log10(value) * 20);
    }

    //loads level select, also used to quit during a level
    public void playGame(){
        Time.timeScale = 1; //this fixes a bug: quitting midlevel leaves time frozen
        SceneManager.LoadScene("Level Select");
    }

    //switches to options screen by switching active container
    public void options(){
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    //switches back to main menu screen
    public void back(){
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }

    //exits the game
    public void exitGame(){
        Application.Quit();
    }
}