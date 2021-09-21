using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackButtonBehaviour : MonoBehaviour
{
    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene("Start");
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
    }
}
