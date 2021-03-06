﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Config;

public class DynamicItem : Interface 
{
	public Text NameInput;
	public Text MassInput;
	public Text StatusInput;
    public Component BoundTo;

	public override void UpdateUI()
	{
		Color statusColor;
		NameInput.text = BoundTo.GetShort();
		MassInput.text = BoundTo.GetMass().ToString("0.00M");
		StatusInput.text = BoundTo.GetStatusLong();
		switch(BoundTo.Status)
		{
			case Statuses.OK:
				statusColor = new Color(0.23f, 0.51f, 0.03f, 1.0f);break;
			case Statuses.STUN:
				statusColor = new Color(0.96f, 0.89f, 0.12f, 1.0f);break;
			case Statuses.DAMAGE:
				statusColor = new Color(1.0f, 0.0f, 0.0f, 1.0f);break;
			default: //destroyed
				statusColor = new Color(0.58f, 0.04f, 0.04f, 1.0f);break;
		}
		NameInput.color = statusColor;
		MassInput.color = statusColor;
		StatusInput.color = statusColor;
	}
}