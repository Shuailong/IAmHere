using UnityEngine;
using System.Collections;

public class RPGControl : MonoBehaviour {
	
	//定义角色动画
	private Animation mAnimation;
	//定义角色状态
	public PersonState mState=PersonState.idle;
	//定义方向状态
	public PersonDirection mDirection=PersonDirection.Forward;
	//定义角色弹跳量
	public float mJumpValue=2F;
	//定义旋转角
	private float mAngles;
	//定义相机
	public GameObject mCamera;
	//定义角色行动方式
	public PersonState RunOrWalk=PersonState.walk;
	
	public float WalkSpeed=1.5F;
	public float RunSpeed=3.0F;
	//角色状态枚举
	public enum PersonState
	{
		idle,
		run,
		walk,
		jump,
		attack
	}
	//角色行动方向枚举
	public enum PersonDirection
	{
		//正常向前
		Forward=90,
		//正常向后
		Backward=270,
		//正常向左
		Left=180,
		//正常向右
		Right=0,
	}
	
	void Start () 
	{
		//获取动画
		mAnimation=gameObject.GetComponent<Animation>();
	}
	
	void Update () 
	{
		//前进
		if(Input.GetKey(KeyCode.W))
		{
			SetPersonDirection(PersonDirection.Forward);
//			SetPersonAnimation();
		}
		//后退
		if(Input.GetKey(KeyCode.S))
		{
			SetPersonDirection(PersonDirection.Backward);
//			SetPersonAnimation();
		}
		//向左
		if(Input.GetKey(KeyCode.A))
		{
			SetPersonDirection(PersonDirection.Left);
//			SetPersonAnimation();
		}
		//向右
		if(Input.GetKey(KeyCode.D))
		{
			SetPersonDirection(PersonDirection.Right);
//			SetPersonAnimation();
		}
		//巡逻或等待
		if(Input.GetKeyUp(KeyCode.A)||Input.GetKeyUp(KeyCode.D)||Input.GetKeyUp(KeyCode.S)||Input.GetKeyUp(KeyCode.W)||Input.GetKeyUp(KeyCode.Space))	
		{
//			mAnimation.Play("idle");
			mState=PersonState.idle;
		}
		//跳跃
		if(Input.GetKey(KeyCode.Space))
		{
			transform.GetComponent<Rigidbody>().AddForce(Vector3.up * mJumpValue,ForceMode.Force);
//			mAnimation.Play("Jump");
			mState=PersonState.jump;
		}
		//攻击
		if(Input.GetMouseButton(0))
		{
//			mAnimation.Play("Attack");
			mState=PersonState.attack;
			StartCoroutine("ReSetState");
		}
		//计算旋转角
		if(Input.GetMouseButton(1))
		{
			//计算水平旋转角
		mAngles+=Input.GetAxis("Mouse X") * 15;
			//旋转角色
			transform.rotation=Quaternion.Euler(new Vector3(0,mAngles,0));
		}
	}

	private void SetPersonDirection(PersonDirection mDir)
	{
		//根据目标方向与当前方向让角色旋转
		if(mDirection!=mDir)
		{
			transform.Rotate(Vector3.up*(mDirection-mDir));
			mDirection=mDir;
		}
	}

/*	private void SetPersonAnimation()
	{
		if(RunOrWalk==PersonState.walk)
		{
			mAnimation.Play("Walk");
			mState=PersonState.walk;
			transform.Translate(Vector3.forward * WalkSpeed * Time.deltaTime);
		}
		else if(RunOrWalk==PersonState.run)
		{
			mAnimation.Play("Run");
			mState=PersonState.run;
			transform.Translate(Vector3.forward * RunSpeed * Time.deltaTime);
		}
	}
	
	IEnumerator ReSetState()
	{
		//当攻击动画播放完毕时，自动切换到巡逻状态
		yield return new WaitForSeconds(mAnimation.clip.length);
		mAnimation.Play("idle");
		mState=PersonState.idle;
	}
	*/
	
}
