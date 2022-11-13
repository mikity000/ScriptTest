using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int[] array = new int[5];

    void Start()
    {
        //�z��ۑ�
        ArrayIssue();

        //���W�ۑ�
        Boss boss = new Boss();
        for (int i = 1; i < 15; i++)
        {
            boss.Magic(i);
        }
    }

    private void ArrayIssue()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }

        foreach (int a in array)
        {
            Debug.Log(a);
        }

        Array.Reverse(array);

        foreach (int a in array)
        {
            Debug.Log(a);
        }
    }
}

public class Boss
{
    private int mp = 53;

    public void Magic(int i)
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log(i + "��� : ���@�U���������B�c��MP��" + mp + "�B");
            return;
        }
        Debug.Log(i + "��� : MP������Ȃ����߁A���@���g���Ȃ��B");
    }
}
