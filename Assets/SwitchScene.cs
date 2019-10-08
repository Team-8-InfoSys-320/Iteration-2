using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("Auckland");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("Iteration 2");
    }
}