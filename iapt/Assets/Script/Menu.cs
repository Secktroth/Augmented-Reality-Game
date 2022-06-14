using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("AR Game");
    }

    public void loadInstructions()
    {
        SceneManager.LoadScene("Instructions");

    }
}
