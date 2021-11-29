using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//発展課題:Bossクラスの作成→37行目以降で呼び出し
public class Boss
{
    int mp = 53;
    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}
public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //配列arrayの初期化･for文を使った順番表示と逆順表示
        int[] array = { 10, 15, 20, 25, 30 };
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for(int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
        //発展課題:Bossクラス･Magic関数の呼び出し
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
