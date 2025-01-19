using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
   public GameObject pauseUI;
   public void OnGameResumePress(){
      pauseUI.SetActive(false);
   }

   public void OnGameExitPress(){
      SceneManager.LoadScene("Main Menu");
   }

   public void OnEnterPausePress(){
      pauseUI.SetActive(true);
   }
}
