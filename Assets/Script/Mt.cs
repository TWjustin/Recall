using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Mt : MonoBehaviour
{
    public Content content;
    public TextMeshProUGUI text;
    public GameObject portal;
    public GameObject bookA;

    private void Awake()
    {
        Scene targetScene = SceneManager.GetSceneByName("DontDestroyOnLoad");
        bookA = GameObject.Find("bookA");
    }

    void Start()
    {
        if (bookA.activeSelf)
        {
            text.text = content.sentences[1];
        }
        else
        {
            text.text = content.sentences[0];
        }
    }

    public void Next()
    {
        portal.SetActive(true);
        if (bookA.activeSelf)
        {
            portal.transform.Find("ruin").gameObject.SetActive(true);
        }
        else
        {
            portal.transform.Find("ruin").gameObject.SetActive(false);
        }
    }
    
    public void SwitchPlace(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
