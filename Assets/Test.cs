using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���W�ۑ�:Boss�N���X�̍쐬��37�s�ڈȍ~�ŌĂяo��
public class Boss
{
    int mp = 53;
    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + mp + "�B");
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
}
public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�z��array�̏������for�����g�������ԕ\���Ƌt���\��
        int[] array = { 10, 15, 20, 25, 30 };
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for(int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
        //���W�ۑ�:Boss�N���X�Magic�֐��̌Ăяo��
        Boss boss = new Boss();
        for(int i = 0; i <= 10; i++)
        {
            boss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
