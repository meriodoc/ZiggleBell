using UnityEngine;
using System.Collections;

public class A_Background_Script : MonoBehaviour {

	private AudioSource audioSource;
	public AudioClip aPageBg;

	void Start () 
	{
		audio.PlayOneShot(aPageBg, 0.7F);
	}
}
