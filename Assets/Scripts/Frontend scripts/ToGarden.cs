using UnityEngine;
using UnityEngine.SceneManagement;
public class ToGarden : MonoBehaviour
{
    public GameObject Player;
    void Update(){
        if(Input.GetKeyDown(KeyCode.E)){
            if(IsPlayerNear()){
                Debug.Log("Press E");
                SceneManager.LoadScene("Garden");
            }
        }
    }
    private bool IsPlayerNear(){
        float distance =Vector2.Distance(Player.transform.position,transform.position);
        return distance<1.5f;
    }
}
