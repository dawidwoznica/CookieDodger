using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResistanceSliderController : MonoBehaviour
{
	public Slider ResistanceSlider;
	public Text ResistanceText;

	
	public IEnumerator StartResistanceSlider(float seconds)
	{
		ResistanceSlider.gameObject.SetActive(true);
		ResistanceText.gameObject.SetActive(true);
		ResistanceSlider.value = 1f;
		float animationTime = 0f;
		while (animationTime < seconds)
		{
			animationTime += Time.deltaTime;
			float lerpValue = animationTime / seconds;
			ResistanceSlider.value = Mathf.Lerp(1f, 0f, lerpValue);
			yield return null;
		}
		ResistanceSlider.gameObject.SetActive(false);
		ResistanceText.gameObject.SetActive(false);
	}
}
