using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]private int seconds;
    [SerializeField] private Text _text;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Count",0,1);
    }
    void Count()
    {
        seconds--;
        if (seconds<= 0)
        {
            Debug.Log("Times up!");
        }
    }
    // Update is called once per frame
    void Update()
    {
        _text.text ="Time left: "+ seconds.ToString();
    }
    
}
