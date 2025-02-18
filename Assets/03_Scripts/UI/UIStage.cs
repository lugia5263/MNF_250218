using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStage : MonoBehaviour
{
	[Header("Settings")]
	//[SerializeField] private GameObject[] mainStage;
	[SerializeField] private GameObject[] subStage;
	[SerializeField] private UIStageDescription description;
	[SerializeField] private Button[] mainStageBtn;
	[SerializeField] private Button[] subStageBtn;

	[SerializeField] private GameObject subStageObj;

	#region Awake Start Update Reset
	private void Start()
	{
		OnReset();
	}
	

	private void OnReset()
	{
		description.gameObject.SetActive(false);
		subStageObj.gameObject.SetActive(false);
		foreach (var sub in subStage)
		{
			sub.SetActive(false);
		}

		foreach (var item in mainStageBtn)
		{
			item.interactable = true;
		}

		foreach (var item in subStage)
		{
			if (item.activeSelf == true)
				item.gameObject.SetActive(false);
		}
	}
	#endregion


	#region MainStage
	public void OnOpenMainStage(int _stageNumber)
	{
		// Enter MainStage
		description.gameObject.SetActive(true);
		switch (_stageNumber)
		{
			case 1:
				
				break;
			case 2:

				break;
			case 3:

				break;
			case 4:

				break;
			case 5:

				break;
			default:
				Debug.Log("세팅된 값이 없습니다.");
				break;
		}
	}

	public void OnCloseMainStage(int _stageNumber)
	{
		// Exit MainStage
		description.gameObject.SetActive(false);
		switch (_stageNumber)
		{
			case 1:

				break;
			case 2:

				break;
			case 3:

				break;
			case 4:

				break;
			case 5:

				break;
			default:
				Debug.Log("세팅된 값이 없습니다.");
				break;
		}
	}

	public void OnMainStage(int _stageNumber)
	{
		// Click MainStage

		foreach (var item in subStage)
		{
			if(item.activeSelf == true)
				item.gameObject.SetActive(false);
		}
		switch (_stageNumber)
		{
			case 1: subStage[0].SetActive(true); break;
			case 2: subStage[1].SetActive(true); break;
			case 3: subStage[2].SetActive(true); break;
			case 4: subStage[3].SetActive(true); break;
			case 5: subStage[4].SetActive(true); break;
			default:
				Debug.Log("세팅된 값이 없습니다.");
				break;
		}
	}
	#endregion

	#region SubStage
	// Enter SubStage
	public void OnOpenSubStage(string _stageNumber)
	{
		// Open SubStage
		subStageObj.SetActive(true);
		description.gameObject.SetActive(true);
		switch (_stageNumber)
		{
			case "1-1":

				break;
			case "1-2":

				break;
			case "1-3":

				break;
			case "1-4":

				break;
			case "1-5":

				break;

			case "2-1":

				break;
			case "2-2":

				break;
			case "2-3":

				break;
			case "2-4":

				break;
			case "2-5":

				break;

			case "3-1":

				break;
			case "3-2":

				break;
			case "3-3":

				break;
			case "3-4":

				break;
			case "3-5":

				break;
			default:
				break;
		}
	}

	public void OnCloseSubStage(string _stageNumber)
	{
		// Close SubStage
		subStageObj.SetActive(false);
		description.gameObject.SetActive(false);
		switch (_stageNumber)
		{
			case "1-1":

				break;
			case "1-2":

				break;
			case "1-3":

				break;
			case "1-4":

				break;
			case "1-5":

				break;

			case "2-1":

				break;
			case "2-2":

				break;
			case "2-3":

				break;
			case "2-4":

				break;
			case "2-5":

				break;

			case "3-1":

				break;
			case "3-2":

				break;
			case "3-3":

				break;
			case "3-4":

				break;
			case "3-5":

				break;

			case "4-1":

				break;
			case "4-2":

				break;
			case "4-3":

				break;
			case "4-4":

				break;
			case "4-5":

				break;

			case "5-1":

				break;
			case "5-2":

				break;
			case "5-3":

				break;
			case "5-4":

				break;
			case "5-5":

				break;
			default:
				break;
		}
	}
	#endregion

	public void OnSubStage(string _stageNumber)
	{
		// Click SubStage
		switch (_stageNumber)
		{
			case "1-1":

				break;
			case "1-2":

				break;
			case "1-3":

				break;
			case "1-4":

				break;
			case "1-5":

				break;

			case "2-1":

				break;
			case "2-2":

				break;
			case "2-3":

				break;
			case "2-4":

				break;
			case "2-5":

				break;

			case "3-1":

				break;
			case "3-2":

				break;
			case "3-3":

				break;
			case "3-4":

				break;
			case "3-5":

				break;

			case "4-1":

				break;
			case "4-2":

				break;
			case "4-3":

				break;
			case "4-4":

				break;
			case "4-5":

				break;

			case "5-1":

				break;
			case "5-2":

				break;
			case "5-3":

				break;
			case "5-4":

				break;
			case "5-5":

				break;
			default:
				break;
		}
	}

	public void OnBackMainStage()
	{
		foreach (var item in subStage)
		{
			if (item.activeSelf == true)
				item.gameObject.SetActive(false);
		}
	}

	public void OnBackLobby()
	{

	}
}