using UnityEngine;
//using PlayerEnum;


public class PlayerModel : MonoBehaviour
{
	[Header("Settings")]
	[SerializeField] private GameObject[] modelPrefabs;


	[Header("Debug")]
	[SerializeField]private GameObject targetPartner;
	[SerializeField]private PlayerModelAniCtrl targetPartnerAni;
//	[SerializeField]private PlayerEnum.MODEL_NUMBER_NAME targetPartnerEnum = PlayerEnum.MODEL_NUMBER_NAME.NONE;



	private void Start()
	{
		ChangeModel(PlayerEnum.MODEL_NUMBER_NAME.MAWANG);
	}

	/// <summary>
	/// 외부적으로 모델을 바꿀 때 이 함수를 거치도록 합니다
	/// </summary>
	/// <param name="_targetEnum"></param>
	public void ChangeModel(PlayerEnum.MODEL_NUMBER_NAME _targetEnum)
	{
		Change(_targetEnum);
	}

	/// <summary>
	/// 내부함수로 작동되는 모델 변경입니다
	/// </summary>
	/// <param name="_targetEnum"></param>
	private void Change(PlayerEnum.MODEL_NUMBER_NAME _targetEnum)
	{
		if(targetPartner != null)
		{
			Destroy(targetPartner);
			targetPartner = null;
			targetPartnerAni = null;
			//targetPartnerEnum = PlayerEnum.MODEL_NUMBER_NAME.NONE;
		}


		switch (_targetEnum)
		{
			case PlayerEnum.MODEL_NUMBER_NAME.MAWANG:
				targetPartner = Instantiate(modelPrefabs[0],Vector3.zero,Quaternion.Euler(new Vector3(0,90,0)));
				targetPartner.transform.parent = this.transform;
				targetPartnerAni = targetPartner.GetComponent<PlayerModelAniCtrl>();
				break;
			default:
				break;
		}
	}

	/// <summary>
	/// 모델의 애니메이션을 재생합니다
	/// </summary>
	/// <param name="_aniEnum">PlayerEnum.Model_Ani State</param>
	public void PlayModelAnimation(PlayerEnum.MODEL_ANI _aniEnum)
	{
		if (targetPartnerAni == null) return;
		targetPartnerAni.PlayAni(ref _aniEnum);
	}



	public void SetFlip(bool _isLeft)
	{
		if (_isLeft == true) transform.rotation = Quaternion.Euler(new Vector3(0, -90, 0));
		else transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
	}
}