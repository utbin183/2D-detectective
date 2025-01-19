using UnityEngine;

public class TeleportToDoor : SceneSwitch
{
    public Transform player;
    public float posX;
    public float posY;
    public string next;
    public override void Start()
    {
        base.Start();
        if(nextScene == next)
        {
            player.position = new Vector2(posX, posY);
        }
    }
   
}
