using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagementScript : MonoBehaviour
{
    public int points= 0;
    public static bool isPause = false;
    public GameObject pauseMeunUI;
    [SerializeField] private string newlevel = "DemoScene";

    // void Start(){}
    // void Update(){}

    public int AddPoint(int n=1)
    {
        points+=n;
        return points;
    }

    public void RestartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PauseButton()
    {
        pauseMeunUI.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;
    }

    public void StartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(newlevel);
        // SceneManager.LoadScene("DemoScene");

    }

    public void AboutButton()
    {

    }

    public void ExitButton()
    {
        Application.Quit();

    }
    
    public void OptionsButton()
    {

    }


}
