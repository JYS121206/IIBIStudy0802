using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

/// <summary> 라디오 버튼 </summary>
public class RadioButton : UIBehaviour
{
    [SerializeField] public Button btnRadio;
    [SerializeField] protected GameObject selectedRadio;
    [SerializeField] protected TMP_Text txtName;
    [SerializeField] protected string buttonName;

    public System.Action SelectedAction { get; set; } = null;
    public bool Swapable { get; set; } = true;
    protected bool isSelected = false; 
    public bool IsSelected
    {
        get
        { return isSelected; }
        set
        {
            isSelected = value;
            selectedRadio.SetActive(value);
        }
    }
    public string ButtonName
    {
        get { return buttonName; }
        set
        {
            buttonName = value;
            txtName.text = value;
        }
    }
    
    new private void OnValidate()
    {
        txtName.text = buttonName;
    }
    new void Start()
    {
        Setup();
    }
    protected virtual void Setup()
    {
        btnRadio.onClick.AddListener(ClickAction);
    }
    public virtual void ClickAction()
    {
        if (!Swapable && IsSelected)
            return;

        IsSelected = !IsSelected;
        SelectedAction?.Invoke();
    }
}