using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class storyTelling : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("Game");
    }
}
