using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public AudioClip buttonPress, bkgMusic;
    public Text titleText;
    public Animation spiderAnim;
    public GameObject videoPlayer, game;

   public void PlayAudio()
    {
        SoundManager.instance.PlaySingle(bkgMusic);
        titleText.text = "Dead!";
        spiderAnim.Play();
    }
    public void Respawn()
    {
        SoundManager.instance.PlaySingle(buttonPress);
        StartCoroutine("Yield");        
        titleText.text = "Kill Spider";
        spiderAnim.Rewind();
    }

    public void CloseApp()
    {
        game.SetActive(false);
        videoPlayer.SetActive(true);
        StartCoroutine("Quit");
    }

    IEnumerator Quit()
    {
        yield return new WaitForSeconds(25);
        Application.Quit();
    }

    IEnumerator Yield()
    {
        yield return new WaitForSeconds(buttonPress.length);
        SoundManager.instance.Stop(buttonPress);
    }
}
