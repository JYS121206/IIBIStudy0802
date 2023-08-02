using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISetWeather : MonoBehaviour
{
    #region UI����
    [SerializeField] private RadioButton[] btnOptionList;
    [SerializeField] private Button btnApply;
    private int selected;

    void Start()
    {
        Setup();
    }
    void Setup()
    {
        btnApply.onClick.AddListener(ApplyAction);

        for (int i = 0; i < btnOptionList.Length; i++)
        {
            int idx = i;
            btnOptionList[i].Swapable = false;
            btnOptionList[i].SelectedAction = () => { SelectWeather(idx); };
        }
    }
    /// <summary>
    /// ���õ� ��ư�� ������ ����
    /// </summary>
    void SetButtonState(int idx)
    {
        for (int i = 0; i < btnOptionList.Length; i++)
        {
            if (i == idx) { continue; }
            btnOptionList[i].IsSelected = false;
        }
    }
    #endregion

    // ���� ����
    void SelectWeather(int idx)
    {
        SetButtonState(idx);
        selected = idx;
    }

    // ������ ���� ����
    void ApplyAction()
    {
        WeatherManager.Instance.Weather = (MyWeather)selected;
    }
}