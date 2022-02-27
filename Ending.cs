using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }
}
