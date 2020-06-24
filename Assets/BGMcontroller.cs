using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMcontroller : MonoBehaviour
{
    private static BGMcontroller instance = null;
    public static BGMcontroller Instance
    {
        get { return instance; }
    }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
