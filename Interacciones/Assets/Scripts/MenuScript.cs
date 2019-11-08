using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void loadScene (string newScene)
    {
        SceneManager.LoadScene(newScene);
    }
}
