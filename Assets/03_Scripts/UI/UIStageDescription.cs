using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIStageDescription : MonoBehaviour
{
	[Header("Settings")]
	[SerializeField]private TMPro.TextMeshProUGUI mainStageName;
	[SerializeField]private TMPro.TextMeshProUGUI subStageName;

	public void SetMainStageDescription(int _stageNumber)
	{
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


	public void SetSubStageDescription(string _stageNumber)
	{
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


}