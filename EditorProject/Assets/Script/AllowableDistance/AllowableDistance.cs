using UnityEngine;
using System;
using System.Collections;

public class AllowableDistance: MonoBehaviour
{
	public float allowableDistance = 10.0f;

	private float currentDistance = 0.0f;

	private Transform target;
	private Transform myTransform;

	private bool isEnter = false;

	void Start() 
	{
		this.myTransform = this.transform;
		this.target = GameObject.FindGameObjectWithTag("Player").transform;
	}

	void Update()
	{
		this.currentDistance =  Vector3.Distance( this.target.position, this.myTransform.position );

		if(!this.isEnter)
		{
			if(this.currentDistance <= this.allowableDistance)
			{  
				this.OnEnterAllowableDistance();
				this.isEnter = true;
			}
		}

		if(this.isEnter)
		{
			if(this.currentDistance <= this.allowableDistance)
				this.OnStayAllowableDistance();

			if(this.currentDistance > this.allowableDistance)
			{
				this.OnExitAllowableDistance();
				this.isEnter = false;
			}
		}
	}

	public virtual void OnEnterAllowableDistance(){}
	public virtual void OnExitAllowableDistance(){}
	public virtual void OnStayAllowableDistance(){}
}
