using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public Transform player;
    void Update()
    {
        score.text = player.position.z.ToString("0m");
    }
}
