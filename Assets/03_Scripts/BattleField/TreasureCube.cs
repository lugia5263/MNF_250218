using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureCube : MonoBehaviour
{
    [SerializeField] private GameObject clearImage;
    [SerializeField] private GameObject clearConversation;
    [SerializeField] private UITextBox textBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            clearImage.SetActive(true);
            StartCoroutine(DisapearClearImage());
        }
    }

    IEnumerator DisapearClearImage()
    {
        yield return new WaitForSeconds(3.0f);
        clearImage.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        clearConversation.SetActive(true);
        textBox.OnInit("Stage01_Clear");
        textBox.PlayText();
    }
}
