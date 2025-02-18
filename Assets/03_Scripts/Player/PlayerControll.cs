using UnityEngine;

public class PlayerControll : MonoBehaviour
{
	// speed
	private float currSpeed = 0.0f;
	private float reachHalfMoveSpeed = 0.0f;
	[SerializeField] private float reachMoveSpeed = 10.0f;

	private Vector3 moveDir;
	private Rigidbody rigidbody;

	[SerializeField] private float jumpPower = 100.0f;
	[SerializeField] private PlayerModel model;

	[SerializeField] private GameObject prefab_Effect;
	

	private void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
	}

	/// <summary>
	/// inputsystem을 활용한 move Function
	/// </summary>
	/// <param name="_moveValue">Inputsystem.InputValue</param>
	public void Move(Vector2 _moveValue)
	{
		moveDir = Vector3.zero;
		if ( _moveValue.x < 0.0f)
		{
			// left
			if (_moveValue.x < -0.5f)
			{ model.PlayModelAnimation(PlayerEnum.MODEL_ANI.RUN); }
			else
			{ model.PlayModelAnimation(PlayerEnum.MODEL_ANI.WALK); }
			moveDir.z = -_moveValue.x;
			model.SetFlip(true);
		}
		else if(_moveValue.x > 0.0f)
		{
			// right
			if (_moveValue.x > 0.5f)
			{ model.PlayModelAnimation(PlayerEnum.MODEL_ANI.RUN); }
			else
			{ model.PlayModelAnimation(PlayerEnum.MODEL_ANI.WALK); }
			moveDir.z = _moveValue.x;
			model.SetFlip(false);
		}
		else // _moveValue.x == 0.0f
		{
			model.PlayModelAnimation(PlayerEnum.MODEL_ANI.IDLE);
		}
		currSpeed = _moveValue.x * reachMoveSpeed;

	}

	private void Update()
	{
		if (moveDir != Vector3.zero)
		{
		//	Debug.Log(moveDir );
			transform.Translate(moveDir * Time.deltaTime * currSpeed);
		}
	}

	public void Attack()
	{
		model.PlayModelAnimation(PlayerEnum.MODEL_ANI.ATTACK);
	}

	public void Jump()
	{
		model.PlayModelAnimation(PlayerEnum.MODEL_ANI.JUMP);
		rigidbody.AddForce(transform.up * jumpPower,ForceMode.Impulse);
	}

#if UNITY_EDITOR
	public void TestAniFunc(int _aniNumber)
	{
		if (_aniNumber < 0) return; else if (_aniNumber >= (int)PlayerEnum.MODEL_ANI.MAX) return;
		PlayerEnum.MODEL_ANI aniEnum = (PlayerEnum.MODEL_ANI)_aniNumber;
		model.PlayModelAnimation(aniEnum);
	}
#endif

	public void OnLeft()
	{
		moveDir = Vector3.zero;
		moveDir.z = -1.0f;
		currSpeed = reachMoveSpeed;
		model.PlayModelAnimation(PlayerEnum.MODEL_ANI.RUN);
		model.SetFlip(true);
	}
	public void OnLeftUp()
	{
		moveDir = Vector3.zero;
		currSpeed = 0.0f;
		model.PlayModelAnimation(PlayerEnum.MODEL_ANI.IDLE);
	}

	public void OnRight()
	{
		moveDir = Vector3.zero;
		moveDir.z = 1.0f;
		currSpeed = reachMoveSpeed;
		model.PlayModelAnimation(PlayerEnum.MODEL_ANI.RUN);
		model.SetFlip(false);
	}

	public void OnRightUp()
	{
		moveDir = Vector3.zero;
		currSpeed = 0.0f;
		model.PlayModelAnimation(PlayerEnum.MODEL_ANI.IDLE);
	}

	public void OnJump()
	{

	}

	public void OnSkill1()
	{

	}


	public void OnSkill2()
	{

	}

}