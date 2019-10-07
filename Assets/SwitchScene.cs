using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("Iteration 1");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("Auckland");
    }
}