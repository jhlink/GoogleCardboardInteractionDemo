using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleColorChanger : MonoBehaviour {

	public ParticleSystem particleSystem;

	private static Color blue = new Color(0.0F, 0.0F, 255.0F);
	private static Color red = new Color(255.0F, 0.0F, 0.0F);
	private static Color green = new Color(0.0F, 255.0F, 0.0F);

	private Color psColor;


	// Use this for initialization
	void Start () {
		psColor = new Color(255.0F, 255.0F, 255.0F);
	}
	
	// Update is called once per frame
	void Update () {
		ParticleSystem.MainModule main = particleSystem.main;
		main.startColor = psColor;
	}

	public void turnBlue() {
		psColor = blue;
	}

	public void turnRed() {
		psColor = red;
	}

	public void turnGreen() {
		psColor = green;
	}
}
