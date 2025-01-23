using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneTrigger : MonoBehaviour
{
   void Start(){
    StartCoroutine(NextScene());
   }
   IEnumerator NextScene(){
       string currentSceneName = SceneManager.GetActiveScene().name;
       if(currentSceneName == "PhoneCall"){
        yield return new WaitForSeconds(15f);
        SceneManager.LoadScene("Onthestreet");
       }
       else if(currentSceneName == "Onthestreet"){
           yield return new WaitForSeconds(5.51f);
           SceneManager.LoadScene("Outside");
       }
   }
}
