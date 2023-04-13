using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scorer : MonoBehaviour
{
    [SerializeField] private int _hits = 0;
    public int numberOfObst;
    private int health;
    public TextMeshProUGUI healthText;
    public GameObject gameOverScreen;

    void Update()
    {
        health = numberOfObst - _hits;
        healthText.text = "Health: " + health.ToString();
        if (health <= 0)
        {
            gameOverScreen.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Obstacle"))
        {
            _hits++;
        }    
    }
}