using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScenesUI : MonoBehaviour
{
    public GameObject profileUI, scenesUI, arCamera;
    public Text playerName;

    private void Start()
    {
      
    }
    public void Back()
    {
        profileUI.SetActive(true);
        scenesUI.SetActive(false);
    }

    public void addNewPlayer(string name)
    {
        playerName.text = name;
    }

    public void jungleButton()
    {
        scenesUI.SetActive(false);
    }
}
