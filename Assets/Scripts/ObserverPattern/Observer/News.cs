using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class News : MonoBehaviour, IObserver
{
    [SerializeField] private string[] state;
    [SerializeField] private TMP_Text txtNews;

    private void Start()
    {
        WeatherManager.Instance.Add(this);
    }

    public void Setup(MyWeather myWeather)
    {
        int curWeather = (int)myWeather;
        txtNews.text = state[curWeather];

    }

    public void UpdateObserver(WeatherManager weather)
    {
        Setup(weather.Weather);
    }
}
