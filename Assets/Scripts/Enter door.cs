using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enterdoor : MonoBehaviour
{
    private bool playerDetected;
    public Transform DoorPos;
    public float width;
    public float height;
    public LayerMask whatIsPlayer;
    SceneSwitch sceneSwitch;

    [SerializeField] private string sceneName;

    [System.Obsolete]
    private void Start()
    {
        sceneSwitch = FindObjectOfType<SceneSwitch>();
    }
    private void Update()
    {
        playerDetected = Physics2D.OverlapBox(DoorPos.position, new Vector2(width, height), 0,  whatIsPlayer);
        if(playerDetected == true)
        {
            if(Input.GetKeyDown(KeyCode.E)) 
            {
                sceneSwitch.SwitchScene(sceneName);
            }
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(DoorPos.position, new Vector3(width, height, 1));
    }
}
