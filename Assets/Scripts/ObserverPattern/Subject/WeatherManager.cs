using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum MyWeather
{
    Fair,
    Rain,
    Snow,
    MaxCount
}

public class WeatherManager : MonoBehaviour
{
    #region Singleton
    private static WeatherManager instance = null;
    public static WeatherManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject go = GameObject.Find(nameof(WeatherManager));
                if (go)
                {
                    instance = go.GetComponent<WeatherManager>();
                }
                else
                {
                    go = new GameObject(nameof(WeatherManager));
                    instance = go.AddComponent<WeatherManager>();
                    DontDestroyOnLoad(go);
                }
            }
            return instance;
        }
    }
    #endregion

    private MyWeather weather = MyWeather.Fair;
    public MyWeather Weather // ���� ������Ƽ
    {
        get { return weather; }
        set { weather = value; }
    } 
}
