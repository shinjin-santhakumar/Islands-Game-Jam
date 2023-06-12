using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ReloadScene : MonoBehaviour
{
    public Button ResetWaves;
    private void Start()
    {
        ResetWaves.onClick.AddListener(TaskOnClick);
    }


    void TaskOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
