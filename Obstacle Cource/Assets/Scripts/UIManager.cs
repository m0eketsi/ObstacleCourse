using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject gameOverScreen;
    public GameObject gameWonScreen;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void PlayButtonPressed()
    {
        startScreen.SetActive(false);
    }
    public void HomeButtonPressed()
    {
        startScreen.SetActive(true);
        player.transform.position = new Vector3(10, 1, 11.65f);
        gameOverScreen.SetActive(false);
        gameWonScreen.SetActive(false);
    }
}
