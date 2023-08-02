using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IObserver
{
    [SerializeField] private Sprite[] state;
    [SerializeField] private SpriteRenderer spriteRenderer;

    private void Start()
    {
        WeatherManager.Instance.Add(this);
    }

    private void Setup(MyWeather myWeather)
    {
        int curWeather = (int)myWeather;
        spriteRenderer.sprite = state[curWeather];
    }

    public void UpdateObserver(WeatherManager weather)
    {
        Setup(weather.Weather);
    }
}
