using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public static string nextScene;
    public static string currentScene;
   public virtual void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
    }
    public void SwitchScene(string sceneName)
    {
        nextScene = currentScene;
        SceneManager.LoadScene(sceneName);
    }
}
