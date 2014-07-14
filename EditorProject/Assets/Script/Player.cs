using UnityEngine;
using System.Collections;

public class Player : AllowableDistance
{
	public override void OnEnterAllowableDistance ()
	{
		print("Entrei");
	}
	public override void OnExitAllowableDistance ()
	{
		print("Sai");
	}
	public override void OnStayAllowableDistance ()
	{
		print("Estou loucamente apaixonado");
	}
}
