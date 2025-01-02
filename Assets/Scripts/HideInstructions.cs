using System.Collections;
using UnityEngine;

public class HideInstructions : MonoBehaviour
{
    public GameObject instructionsPanel; 
    public float displayTime = 5f;

    void Start()
    {
        
        StartCoroutine(HideAfterTime());
    }

    private IEnumerator HideAfterTime()
    {
        yield return new WaitForSeconds(displayTime);
        instructionsPanel.SetActive(false);
    }
}