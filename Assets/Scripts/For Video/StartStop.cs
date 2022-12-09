using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Sprites;
using UnityEngine.UI;

public class StartStop : MonoBehaviour
{
    private VideoPlayer player;
    public Button button;
    public Sprite startPrite;
    public Sprite stopPrite;

    void OnEnable ()
    {
        player = GetComponent<VideoPlayer>();
        button.image.sprite = stopPrite;
    }

    void Update()
    {
        if (player.isPlaying == false)
        {
            button.image.sprite = startPrite;
        }
        else
        {
            button.image.sprite = stopPrite;
        }
    }


    public void ChangeStartStop ()
    {
        if (player.isPlaying == false)
        {
            player.Play();
            button.image.sprite = stopPrite;
        }
        else
        {
            player.Pause();
            button.image.sprite = startPrite;
        }
    }
}
