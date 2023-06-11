using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    // public Button PlayButton;
    // public Button RulesButton;
    // public Button CreditsButton;
    // Start is called before the first frame update
    void Start()
    {
        // PlayButton.onClick.AddListener(TaskOnClick);
        // RulesButton.onClick.AddListener(TaskOnClick);
        // CreditsButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(3);
    }

    public void GoToRules()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToCredits()
    {
        SceneManager.LoadScene(2);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
