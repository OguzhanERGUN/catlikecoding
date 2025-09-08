using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{

	const float hoursToDegrees = -30f;
	const float minutesToDegrees = -6f;
	const float secondsToDegrees = -6f;
	[SerializeField] Transform hoursPivot;

	[SerializeField]
	Transform minutesPivot;

	[SerializeField]
	Transform secondsPivot;

	private void Update()
	{
		TimeSpan time = DateTime.Now.TimeOfDay;
		Debug.Log(DateTime.Now.Hour);
		hoursPivot.localRotation =
				Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
		minutesPivot.localRotation =
			Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
		secondsPivot.localRotation =
			Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);

	}
}
