using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int totalPoint;
    public int stagePoint;
    public int stageIndex;
    public int health;
    public PlayerMove player;
    public GameObject[] Stages;
    public void NextStage()
    {
        if(stageIndex < Stages.Length-1) {
        Stages[stageIndex].SetActive(false);
        stageIndex ++;
        Stages[stageIndex].SetActive(true);
        PlyaerReposition();
        }
        else {
            Time.timeScale = 0;
        }

        totalPoint += stagePoint;
        stagePoint = 0;
    }

    public void HealthDown()
    {
        if(health > 1)
        health --;
        else{
            player.OnDie();

        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            if(health >1) {
                PlyaerReposition
            }
            HealthDown();
        }
    }

    void PlyaerReposition()
    {
        player.transform.position = new Vector3(-7,0,-1);
        player.VelocityZero();
    }
}
