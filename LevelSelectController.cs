using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Author: Collin Van Brabant

public class LevelSelectController : MonoBehaviour
{
    //loads specified level, takes in name of scene from button calling this function
    public void loadlevel(string level) => SceneManager.LoadScene(level);

    //returns to main menu
    public void back(){
        SceneManager.LoadScene("Main Menu");
    }
}
