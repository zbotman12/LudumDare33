using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class DaySystem : MonoBehaviour {

	public float dayTime, BlackoutTime;
	public Image Blackscreen;
	public Text BlackScreenText;
	public IEnumerator clock;
	bool fadein, fadeout, dayisrunning;
	public int DayCount;
	private List<string> BlackScreenTextEntries = new List<string>();

	// Use this for initialization
	void Start () {
		Blackscreen = GameObject.Find ("Blackscreen").GetComponent<Image> ();
		BlackScreenText = GameObject.Find ("Blackscreen").GetComponentsInChildren<Text>()[0];
		fadein = false;
		fadeout = false;
		StartCoroutine (DayTimer (dayTime));
		BlackScreenTextEntries.Add("SUNDAY\n6:00 am");
		BlackScreenTextEntries.Add("SUNDAY\n12:00 am");
		BlackScreenTextEntries.Add("SUNDAY\n6:00 pm");
		BlackScreenTextEntries.Add("MONDAY\n6:00 am");
		BlackScreenTextEntries.Add("MONDAY\n12:00 am");
		BlackScreenTextEntries.Add("MONDAY\n6:00 pm");
		BlackScreenTextEntries.Add("TUESDAY\n6:00 am");
		BlackScreenTextEntries.Add("TUESDAY\n12:00 am");
		BlackScreenTextEntries.Add("TUESDAY\n6:00 pm");
		BlackScreenTextEntries.Add("WEDNESDAY\n6:00 am");
		BlackScreenTextEntries.Add("WEDNESDAY\n12:00 am");
		BlackScreenTextEntries.Add("WEDNESDAY\n6:00 pm");
		BlackScreenTextEntries.Add("THURSDAY\n6:00 am");
		BlackScreenTextEntries.Add("THURSDAY\n12:00 am");
		BlackScreenTextEntries.Add("THURSDAY\n6:00 pm");
		BlackScreenTextEntries.Add("FRIDAY\n6:00 am");
		BlackScreenTextEntries.Add("FRIDAY\n12:00 am");
		BlackScreenTextEntries.Add("FRIDAY\n6:00 pm");
		BlackScreenTextEntries.Add("SATURDAY\n6:00 am");
		BlackScreenTextEntries.Add("SATURDAY\n12:00 am");
		BlackScreenTextEntries.Add("SATURDAY\n6:00 pm");


	}

	void Update(){
		if (fadein) {
			Blackscreen.color = new Color (Blackscreen.color.r, Blackscreen.color.g, Blackscreen.color.b, Blackscreen.color.a + .01f);
			if(Blackscreen.color.a >= 1f){
				fadein = false;

			}
		}
		if (fadeout) {
			Blackscreen.color = new Color (Blackscreen.color.r, Blackscreen.color.g, Blackscreen.color.b, Blackscreen.color.a - .01f);
			if(Blackscreen.color.a < 0.1f){
				fadeout = false;
				//StopCoroutine(clock);
				clock = DayTimer (dayTime);
				if (!dayisrunning) StartCoroutine(clock);
			}
		}
	}


	public IEnumerator DayTimer(float daytime)
	{
		dayisrunning = true;
		DayCount++;
		while(true){
			yield return new WaitForSeconds(daytime);
			fadein = true;
			BlackScreenText.text = BlackScreenTextEntries.ToArray()[DayCount - 1];
			yield return new WaitForSeconds(2f);
			BlackScreenText.text="";
			fadeout = true;
			dayisrunning = false;
			//Blackscreen.color = new Color (Blackscreen.color.r, Blackscreen.color.g, Blackscreen.color.b, 1f);
			//BlackScreenText.color = new Color (BlackScreenText.color.r, BlackScreenText.color.g, BlackScreenText.color.b, 1f);
		}
		
	}

}
