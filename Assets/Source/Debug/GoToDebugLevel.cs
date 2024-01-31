using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToDebugLevel : MonoBehaviour
{
    [SerializeField] private bool _enabled;
    private void OnCollisionEnter(Collision collision)
    {
        if (enabled == true)
        {
            if (collision.gameObject.GetComponent<Player>() == true)
            {
                SceneManager.LoadScene("TestScene");
            }
        }
    }
}
