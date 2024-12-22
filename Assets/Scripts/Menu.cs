﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string level1;
    public string controlScene;
    public string menuScene;
    public string level2;
    public string level3;
    public string levelSelect;
    public void SelectLevel()
    {

        SceneManager.LoadScene(levelSelect);
    }

    public void StartLevel1()
        
    {

        SceneManager.LoadScene(level1);
    }
public void StartLevel2()
     {
     
        SceneManager.LoadScene(level2);
    }
    public void StartLevel3()
     {

        SceneManager.LoadScene(level3);
    }

public void Controls()
    {
        SceneManager.LoadScene(controlScene);

    }


    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(menuScene);
    }








}
