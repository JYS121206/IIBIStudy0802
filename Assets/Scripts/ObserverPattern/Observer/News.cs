using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class News : MonoBehaviour
{
    [SerializeField] private string[] state;
    [SerializeField] private TMP_Text txtNews;

    private void Start()
    {
    }

    private void Setup(MyWeather myWeather)
    {
        int curWeather = (int)myWeather;
        txtNews.text = state[curWeather];

    }
}
