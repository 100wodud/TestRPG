using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager I;
    public float bestScore;


    void Awake()
    {
        if (I != null) //이미 존재하면
        {
            Destroy(gameObject); //두개 이상이니 삭제
            return;
        }
        I = this;
        DontDestroyOnLoad(this.gameObject);

    }
}
