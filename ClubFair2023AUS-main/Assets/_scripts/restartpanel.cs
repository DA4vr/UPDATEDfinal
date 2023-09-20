using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restartpanel : MonoBehaviour
{
    [SerializeField] GameObject endgame;

    void Start()
    {
        // Deactivate the "endgame" GameObject when the script is initialized.
        endgame.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene("MainMenu 1");
    }
}
