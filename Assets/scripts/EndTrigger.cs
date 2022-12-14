using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameManager gm;

    void OnTriggerEnter2D()
    {
        gm.CommpleteLevel();      
    }
}
