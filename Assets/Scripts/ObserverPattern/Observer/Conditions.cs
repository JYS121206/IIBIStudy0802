using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{
    [SerializeField] private Sprite[] state;
    [SerializeField] private SpriteRenderer spriteRenderer;

    private void Start()
    {
    }

    private void Setup(MyWeather myWeather)
    {
        int curWeather = (int)myWeather;
        spriteRenderer.sprite = state[curWeather];
    }

}
