using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lib : MonoBehaviour
{
    private GameObject targetObject;

    private void Start()
    {
        Scene targetScene = SceneManager.GetSceneByName("DontDestroyOnLoad");
        if (targetScene.isLoaded)
        {
            // 獲取目標物件
            targetObject = GameObject.Find("bookA");

            if (targetObject != null)
            {
                // 做些事情...
                Debug.Log("找到目標物件：" + targetObject.name);
            }
            else
            {
                Debug.Log("無法找到目標物件：");
            }
        }
        else
        {
            Debug.Log("目標場景未載入：");
        }
    }

    public void Hihhijofeo()
    {
        targetObject.SetActive(true);
    }
}
