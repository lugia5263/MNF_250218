using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleScene : MonoBehaviour
{
    [SerializeField] private GameObject clearConversation;
    [SerializeField] private UITextBox textBox;
    [SerializeField] private GameObject clearImage;
    // Start is called before the first frame update
    void Start()
    {
        clearConversation.SetActive(false);
        clearImage.SetActive(false);
        textBox.singleService = GameObject.Find("SingleService");
        textBox.battleStartConversation = GameObject.Find("BattleStartConversation");
        textBox.OnInit("Stage01_Start");
        textBox.PlayText();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
