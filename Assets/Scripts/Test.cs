using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    #region ������
    public enum Study
    {
        ���̶�,
        ��ȣ��,
        �α�,
        �ڿ���,
        ����,
        �忹��
    }

    void TestAction()
    {
        Study hy = (Study)1;
        print(hy);

        print($"{Study.�α�}");
    }

    #endregion

    #region ������Ƽ
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
                print("�ʹ� �ູ�ؿ�.");
                break;
            case MyEmotion.Angry:
                print("ȭ�� ����.");
                break;
            case MyEmotion.Sad:
                print("�� ���ۿ�.");
                break;
        }

    }
    #endregion
}
