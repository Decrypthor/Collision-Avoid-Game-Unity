using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager manager;
    private void OnTriggerEnter()
    {
        Debug.Log("lolll");
        manager.LevelComplete();
    }
}
