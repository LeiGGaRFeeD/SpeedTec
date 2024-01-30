using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinUU : MonoBehaviour
{
    [SerializeField] private Text _text;

    void Update()
    {
        _text.text = PlayerPrefs.GetInt("money").ToString();
    }
}
