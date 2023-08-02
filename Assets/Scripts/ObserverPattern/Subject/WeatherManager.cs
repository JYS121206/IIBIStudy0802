using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum MyWeather
{
    Fair,
    Rain,
    Snow
}

public class WeatherManager : MonoBehaviour, ISubject
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
    public MyWeather Weather // ³¯¾¾ ÇÁ·ÎÆÛÆ¼
    {
        get { return weather; }
        set 
        { 
            weather = value;
            Notify();
        }
    }

    List<IObserver> observers = new();

    public void Add(IObserver observer)
    {
        if (observers.Contains(observer) == true)
            return;

        observers.Add(observer);
        print($"{observer} °¡ÀÔ");
    }
    public void Delete(IObserver observer)
    {
        if (observers.Contains(observer) == false)
            return;

        observers.Remove(observer);
        print($"{observer} Å»Åð");
    }
    public void Notify()
    {
        foreach(IObserver observer in observers)
        {
            observer.UpdateObserver(this);
        }
    }
}
