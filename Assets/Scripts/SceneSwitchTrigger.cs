using UnityEngine;

public class SceneSwitchTrigger : MonoBehaviour
{
    SceneSwitch sceneSwitch;
    [SerializeField] private string sceneName;
    
    [System.Obsolete]
    private void Start()
    {
        sceneSwitch = FindObjectOfType<SceneSwitch>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            sceneSwitch.SwitchScene(sceneName);
        }
    }
}
