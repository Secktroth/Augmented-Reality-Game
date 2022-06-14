using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instruction : MonoBehaviour
{
    public void returnMenu()
    {
        Debug.Log("Returning to Menu");
        SceneManager.LoadScene("Menu");
    }
}
