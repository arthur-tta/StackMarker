using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : Singleton<LevelManager>
{
    public Player player;
    public Player Player => player;
    public PlayerMovement playerMovement;

    public int score;
    public int currentLevel;


    public GameObject currentLevelMap;
    public GameObject[] levelMapReference;


    private void Awake()
    {
        player = FindObjectOfType<Player>();
        playerMovement = FindObjectOfType<PlayerMovement>();
        
    }

    public void StartLevel()
    {
        score = 0;
        currentLevel = 1;
        currentLevelMap = Instantiate(levelMapReference[currentLevel - 1]);
    }

    public void EndLevel()
    {
        // TODO: end level
    }
}
