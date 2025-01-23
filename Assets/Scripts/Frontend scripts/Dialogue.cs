using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    [SerializeField] private GameObject NPC;
    [SerializeField] private Transform targetPosition;
    [SerializeField] private GameObject dialogueCanvas;
    [SerializeField] private TMP_Text speakerText;
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private Image portraitImage;
    [SerializeField] private string[] speaker;
    [SerializeField] [TextArea] private string[] dialogueWords;
    [SerializeField] private Sprite[] portrait;
    private bool dialogueActivated;
    private bool runningDialogue;
    private int step;
    public float speed;

    // Update is called once per frame
    void Update()
    {   
        //Khi bắt đầu tương tác nhân vật thì nhấn E
        if(Input.GetKeyDown(KeyCode.E) && dialogueActivated ==true && runningDialogue ==false){
            dialogueCanvas.SetActive(true);
            runningDialogue = true;
            step =0;
            speakerText.text = speaker[step];
            dialogueText.text = dialogueWords[step];
            portraitImage.sprite = portrait[step];
        }
        //Khi độc thoại đang chạy thì nhấn chuột
        if(runningDialogue && Input.GetMouseButtonDown(0)){
            if(step>= speaker.Length){
                dialogueCanvas.SetActive(false);
                runningDialogue = false;
                StartCoroutine(MoveNPCToTarget());
            }
            else{
            runningDialogue =true;
            dialogueCanvas.SetActive(true);
            speakerText.text = speaker[step];
            dialogueText.text = dialogueWords[step];
            portraitImage.sprite = portrait[step];
            step+=1;
            }
        }
    }
   private IEnumerator MoveNPCToTarget(){
    float speed = 0.5f;
    if(NPC.transform.position.x <targetPosition.position.x){
        NPC.transform.localScale = new Vector3(6,6,6);
    }
    while(Vector2.Distance(NPC.transform.position, targetPosition.position)>0.1f){
        NPC.transform.position = Vector2.MoveTowards(NPC.transform.position, targetPosition.transform.position, speed);
         yield return null;
    }
    NPC.transform.position = targetPosition.position;
    NPC.SetActive(false);
   }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Player"){
            dialogueActivated = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision){
        dialogueActivated = false;
        dialogueCanvas.SetActive(false);
    }
}
