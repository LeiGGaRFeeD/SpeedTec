using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoTOHub : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Loading Hub Scene");
        SceneManager.LoadScene("hub");
    }
}
