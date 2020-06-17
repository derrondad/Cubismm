
using UnityEngine.UI;
using UnityEngine;
using System.Globalization;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
   
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
