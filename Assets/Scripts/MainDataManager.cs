using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainDataManager : MonoBehaviour
{
    public static MainDataManager Instance;

    

    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);


    }



}
