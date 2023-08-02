using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    #region 열거형
    public enum Study
    {
        강미란,
        김호영,
        민기,
        박용준,
        유한,
        장예소
    }

    void TestAction()
    {
        Study hy = (Study)1;
        print(hy);

        print($"{Study.민기}");
    }

    #endregion

    #region 프로퍼티
    public enum MyEmotion
    {
        Happy,
        Angry,
        Sad,
    }

    MyEmotion emotion = MyEmotion.Sad;

    public MyEmotion Emotion
    {
        get 
        { return emotion; }
        set 
        {
            emotion = value;
            SetState();
        }
    }

    void SetState()
    {
        switch (Emotion)
        {
            case MyEmotion.Happy:
                print("너무 행복해요.");
                break;
            case MyEmotion.Angry:
                print("화가 난다.");
                break;
            case MyEmotion.Sad:
                print("좀 슬퍼요.");
                break;
        }

    }
    #endregion
}
