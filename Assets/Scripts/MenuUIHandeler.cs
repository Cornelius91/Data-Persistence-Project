using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandeler : MonoBehaviour
{
    private string input;

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
       
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
    }
}
