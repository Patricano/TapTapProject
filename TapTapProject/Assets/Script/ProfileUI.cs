using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProfileUI : MonoBehaviour
{
    public GameObject playerName, age, profileUI, Scenes;

    public string PlayerName, Age;
    public void StartButton()
    {
        PlayerName = playerName.GetComponent<InputField>().text;
        int dropdown_index;
        dropdown_index = age.GetComponent<Dropdown>().value;
        Age = age.GetComponent<Dropdown>().options[dropdown_index].text;

        if (PlayerName != "" && Age != "")
        {
            profileUI.SetActive(false);
            Scenes.SetActive(true);
            Scenes.SendMessage("addNewPlayer", PlayerName);
        }
        else
        {
            Debug.Log("Input field empty!!");
        }


    }

    public void CLoseAR()
    {
        Debug.Log("Quit!!!");
        Application.Quit();
    }

}
