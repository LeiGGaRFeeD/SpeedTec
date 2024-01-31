using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void GoToHub()
    {
        Debug.Log("Loading hub");
        SceneManager.LoadScene("hub");
    }
}
