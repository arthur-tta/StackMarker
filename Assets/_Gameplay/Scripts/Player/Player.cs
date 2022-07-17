using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject playerStack;

    public void AddStack()
    {
        transform.position = transform.position + new Vector3(0, 0.3f, 0);
        LevelManager.Ins.score++;
    }

    public void MinusStack()
    {
        transform.position = transform.position - new Vector3(0, 0.3f, 0);
        LevelManager.Ins.score--;
    }

    public void Reset()
    {
        // TODO: Reset lại khi sang level mới hoặc replay
    }

    public void ClearStack()
    {
        transform.position = transform.position - new Vector3(0, 0.3f * LevelManager.Ins.score, 0);
    }
}
