using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }
}
