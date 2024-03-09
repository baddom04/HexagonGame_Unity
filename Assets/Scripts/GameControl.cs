using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public PlayerControl player;
    public TMP_Text timeText;
    private float time;
    private static int bestTime;
    public TMP_Text end;
    public Spawning spawner;
    private bool oneTimer;
    void Start()
    {
        time = 0;
        oneTimer = true;
        spawner.spawn = true;
        end.gameObject.SetActive(false);
    }
    void Update()
    {
        if (!player.isAlive)
        {
            if (oneTimer)
            {
                Ending();
                oneTimer = false;
            }
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
            foreach (Touch touch in Input.touches)
            {
                if (touch.tapCount == 2)
                {
                    SceneManager.LoadScene("SampleScene");
                }
            }
        }
        else
        {
            time += Time.deltaTime;
            timeText.text = "Time: " + (int)time;
        }
    }
    private void Ending()
    {
        spawner.spawn = false;
        end.gameObject.SetActive(true);
        if (time > bestTime) bestTime = (int)time;
        end.text = "Best time so far: " + bestTime + "s.\nPress R or double tap to restart!";
    }
}
