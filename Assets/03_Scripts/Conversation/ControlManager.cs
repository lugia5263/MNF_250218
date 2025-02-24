using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ControlManager : MonoBehaviour
{
    public GameObject mawang;
    public GameObject talkService;
    public GameObject clear;
    public GameObject conversation;
    public GameObject selectMgr;

    private float posX = -796f;
    private bool isHolding = false;
    // Start is called before the first frame update
    void Awake()
    {
        talkService = GameObject.Find("SingleService");
        mawang = GameObject.Find("Mawang");
        clear = GameObject.Find("Clear");
        conversation = GameObject.Find("Conversation");
        selectMgr = GameObject.Find("SelectMgr");
        selectMgr.GetComponent<StageSelectTalkManager>().enabled = false;
        clear.SetActive(false);
        conversation.SetActive(false);


    }
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (!talkService.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && !isHolding) // 키를 처음 눌렀을 때 실행
            {
                isHolding = true;
                StartCoroutine(PerformLeftMove());
            }

            if (Input.GetKeyUp(KeyCode.LeftArrow)) // 키를 뗄 때 실행 중지
            {
                isHolding = false;
            }
            if(Input.GetKeyDown(KeyCode.RightArrow) && !isHolding)
            {
                isHolding = true;
                StartCoroutine(PerformRightMove());
            }
            if(Input.GetKeyUp(KeyCode.RightArrow))
            {
                isHolding = false;
            }
        }
    }

    //도착지점 상자 열면 발동
    public void ClearBox()
    {
        clear.SetActive(true);
        //클리어 창이 열리고, 캐릭터와 버디의 애니메이션을 승리모션으로 하자.
    }

    //클리어창 클릭 시 대화 열기
    public void ClearActive()
    {
        conversation.SetActive(true);
        selectMgr.SetActive(true);
        selectMgr.GetComponent<StageSelectTalkManager>().enabled = true;
        selectMgr.GetComponent<StageSelectTalkManager>().awake();
        clear.SetActive(false);
    }


    //무슨 기능?
    IEnumerator PerformLeftMove()
    {
        if (isHolding) { 
            Vector3 scale = mawang.transform.localScale;
            if (scale.x == -1)
            {
                scale.x = 1;
            }
            mawang.transform.localScale = scale;
            new WaitForSeconds(3.0f);
            mawang.GetComponent<RectTransform>().localPosition = new Vector3(posX -= 100.0f, -54.85071f, 0);

            yield return new WaitForSeconds(0.5f);
        }
    }

    //무슨 기능?
    IEnumerator PerformRightMove()
    {
        Vector3 scale = mawang.transform.localScale;
        if (scale.x != -1)
        {
            scale.x = -1;
        }
        mawang.transform.localScale = scale;
        new WaitForSeconds(3.0f);
        mawang.GetComponent<RectTransform>().localPosition = new Vector3(posX += 100.0f, -54.85071f, 0);
        yield return new WaitForSeconds(0.5f);
    }

}
