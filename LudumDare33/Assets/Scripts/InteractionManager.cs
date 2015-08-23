using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class InteractionManager : MonoBehaviour {

	public static Text screentext;


	public class Interactable{
		public string name;
		public Dictionary<int, List<string>> dialogMap;
		public Dictionary<int, int[,]> triggerTables;
		
		public Interactable(string obj, Dictionary<int, List<string>> Map, Dictionary<int, int[,]> tables){
			name = obj;
			dialogMap = Map;
			triggerTables = tables;
		}

		public int Interact(List<string> dialog, int clicks){
			if (clicks < dialog.Count) {
				screentext.text = dialog.ToArray()[clicks];
				clicks++;
			} else {
				clicks = 0;
				screentext.text = dialog.ToArray()[clicks];
				clicks++;
			}
			return clicks;
		}
	}

//These are the characters with only one Table
	public Interactable zoeyRoom;
	public Interactable zoeyBasement;
	public Interactable ClaireRoom;
	public Interactable ClaireRoof;
	public Interactable FrankRoom;
	public Interactable FrankOffice;
	public Interactable Drake;
	public Interactable Hannah;
	public Interactable Melissa;
	public Interactable Brenda;
	public Interactable ZackAmanda;
	public Interactable ZackBrenda;
	public Interactable Larry;

//These are the characters with two table
	public Interactable Amanda;
	public Interactable Danny;
	public Interactable Emma;
	public Interactable Ashton;

//These are the items that need to update there table per frame
	public Interactable Boltcutters;
	public Interactable PillBottle;
	public Interactable BrendasHouseKey;
	public Interactable HannahPhone;
	public Interactable Textbook;
	public Interactable Axe;
	public Interactable BasementRoomKey;
	public Interactable LarryHouseKey;

//These are interactables which will also need to update table per frame. They will have 2 tables based on trigger for finding items in ze game. They never go invisable
	public Interactable Railing;
	public Interactable HeartMeds;
	public Interactable Stove;
	public Interactable WaterHeater;
	public Interactable Dresser;
	public Interactable Electronics;
	public Interactable TV;
	public Interactable BrendaDoor;
	public Interactable LarryDoor;
	public Interactable BasementDoor;

	// Use this for initialization
	void Awake() {
		screentext = GameObject.Find ("Canvas").GetComponentsInChildren<Text>()[0];

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
//------------------------------------------------------------------------ZoeyRoom---------------------------------------------------------------------------|
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> zoeyRoomDialogList1 = new List<string>();
		zoeyRoomDialogList1.Add("I am zoey");
		zoeyRoomDialogList1.Add("I am zoey2");
		zoeyRoomDialogList1.Add("I am zoey3");
		zoeyRoomDialogList1.Add("I am zoey4");
		zoeyRoomDialogList1.Add("I am zoey5");

		// Each of these lines will be displayed to the screen. A click will advance to the next line.

		List<string> zoeyRoomDialogList2 = new List<string>();
		zoeyRoomDialogList2.Add("I am zodfsdfey");
		zoeyRoomDialogList2.Add("I am zoesdfsdfy2");
		zoeyRoomDialogList2.Add("I am zoesdfsdfsdfy3");
		zoeyRoomDialogList2.Add("I am zoegtrgery4");
		zoeyRoomDialogList2.Add("I am zoeutyutyy5");


		Dictionary<int, List<string>> zoeyRoomDialogMap = new Dictionary<int, List<string>>();
		zoeyRoomDialogMap.Add (1, zoeyRoomDialogList1);
		zoeyRoomDialogMap.Add (2, zoeyRoomDialogList2);


		int[,] zoeyRoomTableHidden = new int[,]{

			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{2,1},
			/*3*/			{1,1},
			/*4*/			{2,1},
			/*5*/			{1,1},
			/*6*/			{1,1},
			/*7*/			{1,1},
			/*8*/			{1,1},
			/*9*/			{1,1},
			/*10*/			{1,1},
			/*11*/			{1,1},
			/*12*/			{1,1},
			/*13*/			{1,1},
			/*14*/			{1,1},
			/*15*/			{1,1},
			/*16*/			{1,1},
			/*17*/			{1,1},
			/*18*/			{1,1},
			/*19*/			{1,1},
			/*20*/			{1,1},
			/*21*/			{1,1},
		};

		
		int[,] zoeyRoomTableA = new int[,] {

			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,1},
			/*3*/			{1,0},
			/*4*/			{1,1},
			/*5*/			{1,1},
			/*6*/			{1,1},
			/*7*/			{1,1},
			/*8*/			{1,1},
			/*9*/			{1,1},
			/*10*/			{1,1},
			/*11*/			{4,1},
			/*12*/			{1,1},
			/*13*/			{4,1},
			/*14*/			{4,1},
			/*15*/			{4,1},
			/*16*/			{5,1},
			/*17*/			{1,1},
			/*18*/			{1,1},
			/*19*/			{1,1},
			/*20*/			{1,1},
			/*21*/			{1,1},
		};


		Dictionary<int, int[,]> zoeyRoomTableMap = new Dictionary<int, int[,]>();
			zoeyRoomTableMap.Add (1, zoeyRoomTableHidden);
			zoeyRoomTableMap.Add (2, zoeyRoomTableA);

		zoeyRoom = new Interactable("zoeyRoom", zoeyRoomDialogMap, zoeyRoomTableMap);

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
//------------------------------------------------------------------------ZoeyBasement---------------------------------------------------------------------------|
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
	
	List<string> zoeyBaseDialogList1 = new List<string>();
	zoeyBaseDialogList1.Add("I am zoey");
	zoeyBaseDialogList1.Add("I am zoeBASSy2");
	zoeyBaseDialogList1.Add("I am zoBASSSSSey3");
	zoeyBaseDialogList1.Add("I am zoey4");
	zoeyBaseDialogList1.Add("I amBASS zoey5");
	
	List<string> zoeyBaseDialogList2 = new List<string>();
	zoeyBaseDialogList2.Add("I am zodfsdfBASSey");
	zoeyBaseDialogList2.Add("I am zoesdfsdBSASAfy2");
	zoeyBaseDialogList2.Add("I am zoesdfsdfBASSsdfy3");
	zoeyBaseDialogList2.Add("I am zoegtrgeryNSSA4");
	zoeyBaseDialogList2.Add("I am zoeutyutyBASSy5");
	
	
	Dictionary<int, List<string>> zoeyBaseDialogMap = new Dictionary<int, List<string>>();
	zoeyBaseDialogMap.Add(1, zoeyBaseDialogList1);
	zoeyBaseDialogMap.Add(2, zoeyBaseDialogList2);
	
	int[,] zoeyBaseTableHidden = new int[,]{
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{1,1},
			/*3*/			{1,1},
			/*4*/			{1,1},
			/*5*/			{1,1},
			/*6*/			{1,1},
			/*7*/			{1,1},
			/*8*/			{1,1},
			/*9*/			{1,1},
			/*10*/			{1,1},
			/*11*/			{1,1},
			/*12*/			{1,1},
			/*13*/			{1,1},
			/*14*/			{1,1},
			/*15*/			{1,1},
			/*16*/			{1,1},
			/*17*/			{1,1},
			/*18*/			{1,1},
			/*19*/			{1,1},
			/*20*/			{1,1},
			/*21*/			{1,1},
	};
	
	
	int[,] zoeyBaseTableA = new int[,]{
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{1,1},
			/*3*/			{1,1},
			/*4*/			{1,1},
			/*5*/			{1,1},
			/*6*/			{1,1},
			/*7*/			{1,1},
			/*8*/			{1,1},
			/*9*/			{1,1},
			/*10*/			{1,1},
			/*11*/			{1,1},
			/*12*/			{1,1},
			/*13*/			{1,1},
			/*14*/			{1,1},
			/*15*/			{1,1},
			/*16*/			{1,1},
			/*17*/			{1,1},
			/*18*/			{1,1},
			/*19*/			{1,1},
			/*20*/			{1,1},
			/*21*/			{1,1},
	};
	
	
	Dictionary<int, int[,]> zoeyBaseTableMap = new Dictionary<int, int[,]>();
	zoeyBaseTableMap.Add (1, zoeyBaseTableHidden);
	zoeyBaseTableMap.Add (2, zoeyBaseTableA);
	
	zoeyBasement = new Interactable("zoeyBase", zoeyBaseDialogMap, zoeyBaseTableMap);
		
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
//------------------------------------------------------------------------Amanda-----------------------------------------------------------------------------|
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> AmandaDialogList1 = new List<string>();
		AmandaDialogList1.Add("I am zoey");
		AmandaDialogList1.Add("I am zoey2");
		AmandaDialogList1.Add("I am zoey3");
		AmandaDialogList1.Add("I am zoey4");
		AmandaDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> AmandaDialogList2 = new List<string>();
		AmandaDialogList2.Add("I am zodfsdfey");
		AmandaDialogList2.Add("I am zoesdfsdfy2");
		AmandaDialogList2.Add("I am zoesdfsdfsdfy3");
		AmandaDialogList2.Add("I am zoegtrgery4");
		AmandaDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> AmandaDialogMap = new Dictionary<int, List<string>>();
		AmandaDialogMap.Add (1, AmandaDialogList1);
		AmandaDialogMap.Add (2, AmandaDialogList2);
		
		
		int[,] AmandaTableHidden = new int[,]{
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{1,1},
			/*3*/			{1,1},
			/*4*/			{1,1},
			/*5*/			{1,1},
			/*6*/			{1,1},
			/*7*/			{1,1},
			/*8*/			{1,1},
			/*9*/			{1,1},
			/*10*/			{1,1},
			/*11*/			{1,1},
			/*12*/			{1,1},
			/*13*/			{1,1},
			/*14*/			{1,1},
			/*15*/			{1,1},
			/*16*/			{1,1},
			/*17*/			{1,1},
			/*18*/			{1,1},
			/*19*/			{1,1},
			/*20*/			{1,1},
			/*21*/			{1,1},
		};
		
		
		int[,] AmandaTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{1,1},
			/*3*/			{1,1},
			/*4*/			{1,1},
			/*5*/			{1,1},
			/*6*/			{1,1},
			/*7*/			{1,1},
			/*8*/			{1,1},
			/*9*/			{1,1},
			/*10*/			{1,1},
			/*11*/			{1,1},
			/*12*/			{1,1},
			/*13*/			{1,1},
			/*14*/			{1,1},
			/*15*/			{1,1},
			/*16*/			{1,1},
			/*17*/			{1,1},
			/*18*/			{1,1},
			/*19*/			{1,1},
			/*20*/			{1,1},
			/*21*/			{1,1},
		};
		int[,] AmandaTableB = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{1,1},
			/*3*/			{1,1},
			/*4*/			{1,1},
			/*5*/			{1,1},
			/*6*/			{1,1},
			/*7*/			{1,1},
			/*8*/			{1,1},
			/*9*/			{1,1},
			/*10*/			{1,1},
			/*11*/			{1,1},
			/*12*/			{1,1},
			/*13*/			{1,1},
			/*14*/			{1,1},
			/*15*/			{1,1},
			/*16*/			{1,1},
			/*17*/			{1,1},
			/*18*/			{1,1},
			/*19*/			{1,1},
			/*20*/			{1,1},
			/*21*/			{1,1},
		};
		
		
		Dictionary<int, int[,]> AmandaTableMap = new Dictionary<int, int[,]>();
		AmandaTableMap.Add (1, AmandaTableHidden);
		AmandaTableMap.Add (2, AmandaTableA);
		AmandaTableMap.Add (3, AmandaTableB);

		Amanda = new Interactable("Amanda", AmandaDialogMap, AmandaTableMap);

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------ClaireRoom---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> ClaireRoomDialogList1 = new List<string>();
		ClaireRoomDialogList1.Add("I am zoey");
		ClaireRoomDialogList1.Add("I am zoey2");
		ClaireRoomDialogList1.Add("I am zoey3");
		ClaireRoomDialogList1.Add("I am zoey4");
		ClaireRoomDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> ClaireRoomDialogList2 = new List<string>();
		ClaireRoomDialogList2.Add("I am zodfsdfey");
		ClaireRoomDialogList2.Add("I am zoesdfsdfy2");
		ClaireRoomDialogList2.Add("I am zoesdfsdfsdfy3");
		ClaireRoomDialogList2.Add("I am zoegtrgery4");
		ClaireRoomDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> ClaireRoomDialogMap = new Dictionary<int, List<string>>();
		ClaireRoomDialogMap.Add (1, ClaireRoomDialogList1);
		ClaireRoomDialogMap.Add (2, ClaireRoomDialogList2);
		
		
		int[,] ClaireRoomTableHidden = new int[,]{
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{2,1},
			/*3*/			{1,1},
			/*4*/			{2,1},
			/*5*/			{1,1},
			/*6*/			{1,1},
			/*7*/			{1,1},
			/*8*/			{1,1},
			/*9*/			{1,1},
			/*10*/			{1,1},
			/*11*/			{1,1},
			/*12*/			{1,1},
			/*13*/			{1,1},
			/*14*/			{1,1},
			/*15*/			{1,1},
			/*16*/			{1,1},
			/*17*/			{1,1},
			/*18*/			{1,1},
			/*19*/			{1,1},
			/*20*/			{1,1},
			/*21*/			{1,1},
		};
		
		
		int[,] ClaireRoomTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,1},
			/*3*/			{1,0},
			/*4*/			{1,1},
			/*5*/			{1,1},
			/*6*/			{1,1},
			/*7*/			{1,1},
			/*8*/			{1,1},
			/*9*/			{1,1},
			/*10*/			{1,1},
			/*11*/			{4,1},
			/*12*/			{1,1},
			/*13*/			{4,1},
			/*14*/			{4,1},
			/*15*/			{4,1},
			/*16*/			{5,1},
			/*17*/			{1,1},
			/*18*/			{1,1},
			/*19*/			{1,1},
			/*20*/			{1,1},
			/*21*/			{1,1},
		};
		
		
		Dictionary<int, int[,]> ClaireRoomTableMap = new Dictionary<int, int[,]>();
		ClaireRoomTableMap.Add (1, ClaireRoomTableHidden);
		ClaireRoomTableMap.Add (2, ClaireRoomTableA);
		
		ClaireRoom = new Interactable("ClaireRoom", ClaireRoomDialogMap, ClaireRoomTableMap);


		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------Ashton---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> AshtonDialogList1 = new List<string>();
		AshtonDialogList1.Add("I am zoey");
		AshtonDialogList1.Add("I am zoey2");
		AshtonDialogList1.Add("I am zoey3");
		AshtonDialogList1.Add("I am zoey4");
		AshtonDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> AshtonDialogList2 = new List<string>();
		AshtonDialogList2.Add("I am zodfsdfey");
		AshtonDialogList2.Add("I am zoesdfsdfy2");
		AshtonDialogList2.Add("I am zoesdfsdfsdfy3");
		AshtonDialogList2.Add("I am zoegtrgery4");
		AshtonDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> AshtonDialogMap = new Dictionary<int, List<string>>();
		AshtonDialogMap.Add (1, AshtonDialogList1);
		AshtonDialogMap.Add (2, AshtonDialogList2);
		
		
		int[,] AshtonTableHidden = new int[,]{
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{2,1},
			/*3*/			{1,1},
			/*4*/			{2,1},
			/*5*/			{1,1},
			/*6*/			{1,1},
			/*7*/			{1,1},
			/*8*/			{1,1},
			/*9*/			{1,1},
			/*10*/			{1,1},
			/*11*/			{1,1},
			/*12*/			{1,1},
			/*13*/			{1,1},
			/*14*/			{1,1},
			/*15*/			{1,1},
			/*16*/			{1,1},
			/*17*/			{1,1},
			/*18*/			{1,1},
			/*19*/			{1,1},
			/*20*/			{1,1},
			/*21*/			{1,1},
		};
		
		
		int[,] AshtonTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,1},
			/*3*/			{1,0},
			/*4*/			{1,1},
			/*5*/			{1,1},
			/*6*/			{1,1},
			/*7*/			{1,1},
			/*8*/			{1,1},
			/*9*/			{1,1},
			/*10*/			{1,1},
			/*11*/			{4,1},
			/*12*/			{1,1},
			/*13*/			{4,1},
			/*14*/			{4,1},
			/*15*/			{4,1},
			/*16*/			{5,1},
			/*17*/			{1,1},
			/*18*/			{1,1},
			/*19*/			{1,1},
			/*20*/			{1,1},
			/*21*/			{1,1},
		};

		int[,] AshtonTableB = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,1},
			/*3*/			{1,0},
			/*4*/			{1,1},
			/*5*/			{1,1},
			/*6*/			{1,1},
			/*7*/			{1,1},
			/*8*/			{1,1},
			/*9*/			{1,1},
			/*10*/			{1,1},
			/*11*/			{4,1},
			/*12*/			{1,1},
			/*13*/			{4,1},
			/*14*/			{4,1},
			/*15*/			{4,1},
			/*16*/			{5,1},
			/*17*/			{1,1},
			/*18*/			{1,1},
			/*19*/			{1,1},
			/*20*/			{1,1},
			/*21*/			{1,1},
		};
		
		
		Dictionary<int, int[,]> AshtonTableMap = new Dictionary<int, int[,]>();
		AshtonTableMap.Add (1, AshtonTableHidden);
		AshtonTableMap.Add (2, AshtonTableA);
		AshtonTableMap.Add (3, AshtonTableB);

		Ashton = new Interactable("Ashton", AshtonDialogMap, AshtonTableMap);


}

}



