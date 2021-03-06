﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformerCharacter2DHealth : MonoBehaviour {

	public int startingHealth = 100;
	public int currentHealth;
	public Slider healthSlider;

	//public Image damageImage; 		//if we wanna use a flash or something
	//public float flashSpeed = 5f;
	//public Color flashColor = new Color(1f. 0f, 0f, 0.1f);

	//public AudioClip deathClip;			//combat sounds
	//public AudioClip hurtClip;

	//private Animator anim;
	//private AudioSource playerAudio;
	//private PlayerMovementScript playerMovement;	//use player control script for combat
	private bool isDead;
	private bool damaged;

	void Awake ()
	{
		//anim = GetComponent <Animator> ();
		//playerAudio = GetComponent <AudioSource> ();
		//playerMovement = GetComponent <PlayerMovementScript> ();
		currentHealth = startingHealth;
	}
		
	// Update is called once per frame
	void Update () 
	{
		/*
		//assuming we want to use damage flash
		if (damaged)
		{
			damageImage.color = flashColor;
		}
		else
		{
			damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		*/
		damaged = false;
	}

	public void TakeDamage (int amount)
	{
		damaged = true;
		currentHealth -= amount;
		healthSlider.value = currentHealth;
		//playerAudio.Play ();				//plays hurt audio
		if (currentHealth <= 0 && !isDead)
		{
			Death ();
		}
	}

	void Death ()
	{
		isDead = true;
		/*
		//enable these as we go
		anim.SetTrigger ("Die");
		playerAudio.clip = deathClip;
		playerAudio.Play ();
		playerMovement.enabled = false;
		*/
	}
}
