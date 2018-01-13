using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnCollisionWithThing : MonoBehaviour
{

	public ParticleSystem FoodParticles;
	public Transform ParticlesSpawnPoint;
	public Slider FatLevelSlider;
	public FatController FatController;
	public ResistanceSliderController ResistanceSliderController;
	public AudioClip[] BurneikaAudioClips;
	public AudioClip CrunchAudioClip;
	public AudioSource AudioSource;
	


	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag.Equals("Food"))
		{
			FatController.Eat(other.gameObject.GetComponent<FatAmount>().AmountOfFat);
			Destroy(other.gameObject);
			AudioSource.PlayOneShot(CrunchAudioClip);
			Instantiate(FoodParticles, ParticlesSpawnPoint.position, ParticlesSpawnPoint.rotation);
		}
		else if (other.gameObject.tag.Equals("Boost"))
		{
			StartCoroutine(FatController.FatResistance());
		    StartCoroutine(ResistanceSliderController.StartResistanceSlider(FatController.FatResistanceTime));
			Destroy(other.gameObject);
			AudioSource.PlayOneShot(BurneikaAudioClips[Random.Range(0, BurneikaAudioClips.Length)]);
		}
	}
}
