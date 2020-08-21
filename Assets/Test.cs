using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; //mp

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }
    public void Magic(int magic)
    {
            if(5 <= mp)
            {
                mp -= magic;
                Debug.Log("魔法攻撃した。残りMPは" + mp + "。");
            }
            else
            {
            Debug.Log("mpが足りないための方が使えない");
            }
    }

}

public class Test : MonoBehaviour
{

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        int[] array = { 10, 20, 30, 40, 50 };
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for(int j = 4; 0 <= j; j--)
        {
            Debug.Log(array[j]);
        }
        for(int i = 10; 0 <= i; i--)
        {
            //マジック用の関数をよびだす
            lastboss.Magic(5);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}