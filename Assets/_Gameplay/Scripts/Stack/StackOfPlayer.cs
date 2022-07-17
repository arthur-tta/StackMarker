using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackOfPlayer : MonoBehaviour
{
    private GameObject newStack;
  

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("StackAdd"))
        {
            AddStack();
        }

        if (other.CompareTag("StackMinus"))
        {
            MinusStack();
        }

        if (other.CompareTag("Finish"))
        {
            LevelManager.Ins.EndLevel();
            ClearStack();
        }
    }

    private void AddStack()
    {
        newStack = Instantiate(gameObject, transform.parent);
        newStack.transform.localPosition = newStack.transform.localPosition - new Vector3(0, 0.3f, 0);
        LevelManager.Ins.player.AddStack();
    }

    private void MinusStack()
    {
        Destroy(gameObject);
        LevelManager.Ins.player.MinusStack();
    }

    private void ClearStack()
    {
        for(int i = LevelManager.Ins.score; i> 0; i--)
        {
            Destroy(LevelManager.Ins.player.transform.GetChild(i).gameObject);
            //LevelManager.Ins.player.MinusStack();
        }
        LevelManager.Ins.player.ClearStack();
    }
}
