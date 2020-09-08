using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneMng : MonoBehaviour
{
    public void NextScene(string other)
    {
        SceneManager.LoadScene("OtherSceneName", LoadSceneMode.Additive);
    }
}
