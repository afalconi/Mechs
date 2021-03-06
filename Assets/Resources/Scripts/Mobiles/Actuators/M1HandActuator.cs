﻿using UnityEngine;
using System.Collections;

public class M1HandActuator : Actuator 
{
	public string[] Compatibility = new string[] {"left arm", "right arm"};

	public M1HandActuator(float mass) : base(mass)
	{
		Short = "Mark-1 Leg Actuator";
		Long = "A MechTech Mark-1 hand actuator. It attaches to the end of the arm and can be used for punching, picking up objects, and climbing.";
	}

	public override bool IsMeleeWeapon()
	{
		return true;
	}
}