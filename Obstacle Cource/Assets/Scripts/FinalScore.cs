using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
    public float finalScore;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        finalScore = PlayerPrefs.GetInt("FinalScore");
        scoreText.text = "Score: " + finalScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
