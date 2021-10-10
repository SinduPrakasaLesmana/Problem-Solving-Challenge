using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameButton : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene(0);
        
    }

    public void Problem1()
    {
        SceneManager.LoadScene(1);
        
    }

    public void Problem2()
    {
        SceneManager.LoadScene(2);
    }

    public void Problem3()
    {
        SceneManager.LoadScene(3);
        
    }

    public void Problem4()
    {
        SceneManager.LoadScene(4);
    }

    public void Problem5()
    {
        SceneManager.LoadScene(5);
        
    }

    public void Problem6()
    {
        SceneManager.LoadScene(6);
    }

    public void Problem7()
    {
        SceneManager.LoadScene(7);
        
    }

    public void Problem8()
    {
        SceneManager.LoadScene(8);
    }

    public void Problem9()
    {
        SceneManager.LoadScene(9);
    }

    public void Exit()
    {
        Application.Quit();
    }

}
