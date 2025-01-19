using UnityEngine;

public class CastleInteraction : MonoBehaviour
{
    public GameObject Player; 
    public string SceneName; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
           
            if (IsPlayerNear())
            {
                Debug.Log("Press E");
                UnityEngine.SceneManagement.SceneManager.LoadScene(SceneName);
            }
        }
    }

    private bool IsPlayerNear()
    {
        float distance = Vector2.Distance(Player.transform.position, transform.position);
        return distance < 1.5f; 
    }
}