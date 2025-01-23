using System.Collections;
using UnityEngine;

public class DisappearToAppear : MonoBehaviour
{
   public GameObject player;
   [SerializeField] private float time;
   void Start(){
        StartCoroutine(disappearandappear());
   }
   IEnumerator disappearandappear(){
        player.SetActive(false);
        yield return new WaitForSeconds(time);
        player.SetActive(true);
   }
}
