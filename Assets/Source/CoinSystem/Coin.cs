using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]private float rotationSpeed = 100f; 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Player>() == true)
        {
            Debug.Log("Money ");
            PlayerPrefs.SetInt("money", (PlayerPrefs.GetInt("money") + 1));
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
