using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu: MonoBehaviour
{
    public void Go_back_to_menu(){
        SceneManager.LoadScene("Main Menu");
    }
}
