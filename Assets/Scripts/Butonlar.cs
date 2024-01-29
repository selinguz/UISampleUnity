using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Butonlar : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("SecondScene");
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void ComeBackButton()
    {
        SceneManager.LoadScene("FirstScene");
    }
}
