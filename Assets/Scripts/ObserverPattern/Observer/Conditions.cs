using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour, IObserver
{
    [SerializeField] private Sprite[] state;
    [SerializeField] private SpriteRenderer spriteRenderer;

    private void Start()
    {
        WeatherManager.Instance.Add(this);
    }

    public void Setup(MyWeather myWeather)
    {
        int curWeather = (int)myWeather;
        spriteRenderer.sprite = state[curWeather];
    }

    public void UpdateObserver(WeatherManager weather)
    {
        Setup(weather.Weather);
    }
}
