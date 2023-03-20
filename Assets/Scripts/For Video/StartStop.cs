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
        // *** ---- the OnEnable function will be call when the page load and it will get the components with a scripts ---- *** //

        player = GetComponent<VideoPlayer>();
        button.image.sprite = stopPrite;
    }

    void Update()
    {
        // *** ---- the Update function will be call when every second to check if the user is currently playing ---- *** //

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
        // *** ---- the ChangeStartStop function will be call user stop playing ---- *** //

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
