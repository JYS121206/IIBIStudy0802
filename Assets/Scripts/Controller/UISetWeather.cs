using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISetWeather : MonoBehaviour
{
    #region UI관련
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
    /// 선택된 버튼만 켜지게 셋팅
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

    // 날씨 선택
    void SelectWeather(int idx)
    {
        SetButtonState(idx);
        selected = idx;
    }

    // 선택한 날씨 적용
    void ApplyAction()
    {
        WeatherManager.Instance.Weather = (MyWeather)selected;
    }
}