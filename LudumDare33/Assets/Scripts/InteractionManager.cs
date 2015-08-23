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
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,1},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,1},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,1},
			/*11*/			{4,0},
			/*12*/			{1,0},
			/*13*/			{4,1},
			/*14*/			{4,0},
			/*15*/			{4,0},
			/*16*/			{5,1},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,0},
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
			/*11*/			{1,0},
			/*12*/			{1,0},
			/*13*/			{1,0},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,0},
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
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,0},
			/*11*/			{1,0},
			/*12*/			{1,0},
			/*13*/			{1,0},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		int[,] AmandaTableB = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,0},
			/*11*/			{1,0},
			/*12*/			{1,0},
			/*13*/			{1,0},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{2,0},
			/*20*/			{2,0},
			/*21*/			{2,0},
		};
		
		
		Dictionary<int, int[,]> AmandaTableMap = new Dictionary<int, int[,]>();
		AmandaTableMap.Add (1, AmandaTableHidden);
		AmandaTableMap.Add (2, AmandaTableA);
		AmandaTableMap.Add (3, AmandaTableB);

		Amanda = new Interactable("Amanda", AmandaDialogMap, AmandaTableMap);

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------Danny-----------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> DannyDialogList1 = new List<string>();
		DannyDialogList1.Add("I am zoey");
		DannyDialogList1.Add("I am zoey2");
		DannyDialogList1.Add("I am zoey3");
		DannyDialogList1.Add("I am zoey4");
		DannyDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> DannyDialogList2 = new List<string>();
		DannyDialogList2.Add("I am zodfsdfey");
		DannyDialogList2.Add("I am zoesdfsdfy2");
		DannyDialogList2.Add("I am zoesdfsdfsdfy3");
		DannyDialogList2.Add("I am zoegtrgery4");
		DannyDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> DannyDialogMap = new Dictionary<int, List<string>>();
		DannyDialogMap.Add (1, DannyDialogList1);
		DannyDialogMap.Add (2, DannyDialogList2);
		
		
		int[,] DannyTableHidden = new int[,]{
			
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
		
		
		int[,] DannyTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,0},
			/*11*/			{1,0},
			/*12*/			{1,0},
			/*13*/			{1,0},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		int[,] DannyTableB = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,0},
			/*11*/			{1,0},
			/*12*/			{1,0},
			/*13*/			{1,0},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{2,0},
			/*20*/			{2,0},
			/*21*/			{2,0},
		};
		
		
		Dictionary<int, int[,]> DannyTableMap = new Dictionary<int, int[,]>();
		DannyTableMap.Add (1, DannyTableHidden);
		DannyTableMap.Add (2, DannyTableA);
		DannyTableMap.Add (3, DannyTableB);
		
		Danny = new Interactable("Danny", DannyDialogMap, DannyTableMap);

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------Emma-----------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> EmmaDialogList1 = new List<string>();
		EmmaDialogList1.Add("I am zoey");
		EmmaDialogList1.Add("I am zoey2");
		EmmaDialogList1.Add("I am zoey3");
		EmmaDialogList1.Add("I am zoey4");
		EmmaDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> EmmaDialogList2 = new List<string>();
		EmmaDialogList2.Add("I am zodfsdfey");
		EmmaDialogList2.Add("I am zoesdfsdfy2");
		EmmaDialogList2.Add("I am zoesdfsdfsdfy3");
		EmmaDialogList2.Add("I am zoegtrgery4");
		EmmaDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> EmmaDialogMap = new Dictionary<int, List<string>>();
		EmmaDialogMap.Add (1, EmmaDialogList1);
		EmmaDialogMap.Add (2, EmmaDialogList2);
		
		
		int[,] EmmaTableHidden = new int[,]{
			
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
		
		
		int[,] EmmaTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,0},
			/*11*/			{1,0},
			/*12*/			{1,0},
			/*13*/			{1,0},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		int[,] EmmaTableB = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,0},
			/*11*/			{1,0},
			/*12*/			{1,0},
			/*13*/			{1,0},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{2,0},
			/*20*/			{2,0},
			/*21*/			{2,0},
		};
		
		
		Dictionary<int, int[,]> EmmaTableMap = new Dictionary<int, int[,]>();
		EmmaTableMap.Add (1, EmmaTableHidden);
		EmmaTableMap.Add (2, EmmaTableA);
		EmmaTableMap.Add (3, EmmaTableB);
		
		Emma = new Interactable("Emma", EmmaDialogMap, EmmaTableMap);

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
		
		
		int[,] ClaireRoomTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{1,0},
			/*3*/			{1,1},
			/*4*/			{1,1},
			/*5*/			{1,0},
			/*6*/			{1,1},
			/*7*/			{1,1},
			/*8*/			{1,0},
			/*9*/			{1,1},
			/*10*/			{1,1},
			/*11*/			{4,0},
			/*12*/			{1,1},
			/*13*/			{4,1},
			/*14*/			{4,0},
			/*15*/			{4,1},
			/*16*/			{5,1},
			/*17*/			{1,0},
			/*18*/			{1,1},
			/*19*/			{1,1},
			/*20*/			{1,0},
			/*21*/			{1,1},
		};
		
		
		Dictionary<int, int[,]> ClaireRoomTableMap = new Dictionary<int, int[,]>();
		ClaireRoomTableMap.Add (1, ClaireRoomTableHidden);
		ClaireRoomTableMap.Add (2, ClaireRoomTableA);
		
		ClaireRoom = new Interactable("ClaireRoom", ClaireRoomDialogMap, ClaireRoomTableMap);


		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------ClaireRoof---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		
		List<string> claireroofDialogList1 = new List<string>();
		ClaireRoofDialogList1.Add("I am zoey");
		ClaireRoofDialogList1.Add("I am zoeBASSy2");
		ClaireRoofDialogList1.Add("I am zoBASSSSSey3");
		ClaireRoofDialogList1.Add("I am zoey4");
		ClaireRoofDialogList1.Add("I amBASS zoey5");
		
		List<string> ClaireRoofDialogList2 = new List<string>();
		ClaireRoofDialogList2.Add("I am zodfsdfBASSey");
		ClaireRoofDialogList2.Add("I am zoesdfsdBSASAfy2");
		ClaireRoofDialogList2.Add("I am zoesdfsdfBASSsdfy3");
		ClaireRoofDialogList2.Add("I am zoegtrgeryNSSA4");
		ClaireRoofDialogList2.Add("I am zoeutyutyBASSy5");
		
		
		Dictionary<int, List<string>> ClaireRoofDialogMap = new Dictionary<int, List<string>>();
		ClaireRoofDialogMap.Add(1, ClaireRoofDialogList1);
		ClaireRoofDialogMap.Add(2, ClaireRoofDialogList2);
		
		int[,] ClaireRoofTableHidden = new int[,]{
			
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
		
		
		int[,] ClaireRoofTableA = new int[,]{
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{1,1},
			/*3*/			{1,0},
			/*4*/			{1,1},
			/*5*/			{1,1},
			/*6*/			{1,0},
			/*7*/			{1,1},
			/*8*/			{1,1},
			/*9*/			{1,0},
			/*10*/			{1,1},
			/*11*/			{1,1},
			/*12*/			{1,0},
			/*13*/			{1,1},
			/*14*/			{1,1},
			/*15*/			{1,0},
			/*16*/			{1,1},
			/*17*/			{1,1},
			/*18*/			{1,0},
			/*19*/			{1,1},
			/*20*/			{1,1},
			/*21*/			{1,0},
		};
		
		
		Dictionary<int, int[,]> ClaireRoofTableMap = new Dictionary<int, int[,]>();
		ClaireRoofTableMap.Add (1, ClaireRoofTableHidden);
		ClaireRoofTableMap.Add (2, ClaireRoofTableA);
		
		ClaireRoofment = new Interactable("ClaireRoof", ClaireRoofDialogMap, ClaireRoofTableMap);


		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------FrankRoom---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> FrankRoomDialogList1 = new List<string>();
		FrankRoomDialogList1.Add("I am zoey");
		FrankRoomDialogList1.Add("I am zoey2");
		FrankRoomDialogList1.Add("I am zoey3");
		FrankRoomDialogList1.Add("I am zoey4");
		FrankRoomDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> FrankRoomDialogList2 = new List<string>();
		FrankRoomDialogList2.Add("I am zodfsdfey");
		FrankRoomDialogList2.Add("I am zoesdfsdfy2");
		FrankRoomDialogList2.Add("I am zoesdfsdfsdfy3");
		FrankRoomDialogList2.Add("I am zoegtrgery4");
		FrankRoomDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> FrankRoomDialogMap = new Dictionary<int, List<string>>();
		FrankRoomDialogMap.Add (1, FrankRoomDialogList1);
		FrankRoomDialogMap.Add (2, FrankRoomDialogList2);
		
		
		int[,] FrankRoomTableHidden = new int[,]{
			
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
		
		
		int[,] FrankRoomTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{1,1},
			/*3*/			{1,0},
			/*4*/			{1,1},
			/*5*/			{1,1},
			/*6*/			{1,0},
			/*7*/			{1,1},
			/*8*/			{1,1},
			/*9*/			{1,0},
			/*10*/			{1,1},
			/*11*/			{4,1},
			/*12*/			{1,0},
			/*13*/			{4,1},
			/*14*/			{4,1},
			/*15*/			{4,0},
			/*16*/			{5,1},
			/*17*/			{1,1},
			/*18*/			{1,0},
			/*19*/			{1,1},
			/*20*/			{1,1},
			/*21*/			{1,0},
		};
		
		
		Dictionary<int, int[,]> FrankRoomTableMap = new Dictionary<int, int[,]>();
		FrankRoomTableMap.Add (1, FrankRoomTableHidden);
		FrankRoomTableMap.Add (2, FrankRoomTableA);
		
		FrankRoom = new Interactable("FrankRoom", FrankRoomDialogMap, FrankRoomTableMap);
		
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------FrankOffice---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> FrankOfficeDialogList1 = new List<string>();
		FrankOfficeDialogList1.Add("I am zoey");
		FrankOfficeDialogList1.Add("I am zoey2");
		FrankOfficeDialogList1.Add("I am zoey3");
		FrankOfficeDialogList1.Add("I am zoey4");
		FrankOfficeDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> FrankOfficeDialogList2 = new List<string>();
		FrankOfficeDialogList2.Add("I am zodfsdfey");
		FrankOfficeDialogList2.Add("I am zoesdfsdfy2");
		FrankOfficeDialogList2.Add("I am zoesdfsdfsdfy3");
		FrankOfficeDialogList2.Add("I am zoegtrgery4");
		FrankOfficeDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> FrankOfficeDialogMap = new Dictionary<int, List<string>>();
		FrankOfficeDialogMap.Add (1, FrankOfficeDialogList1);
		FrankOfficeDialogMap.Add (2, FrankOfficeDialogList2);
		
		
		int[,] FrankOfficeTableHidden = new int[,]{
			
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
		
		
		int[,] FrankOfficeTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{1,0},
			/*3*/			{1,1},
			/*4*/			{1,1},
			/*5*/			{1,0},
			/*6*/			{1,1},
			/*7*/			{1,1},
			/*8*/			{1,0},
			/*9*/			{1,1},
			/*10*/			{1,1},
			/*11*/			{4,0},
			/*12*/			{1,1},
			/*13*/			{4,1},
			/*14*/			{4,0},
			/*15*/			{4,1},
			/*16*/			{5,1},
			/*17*/			{1,0},
			/*18*/			{1,1},
			/*19*/			{1,1},
			/*20*/			{1,0},
			/*21*/			{1,1},
		};
		
		
		Dictionary<int, int[,]> FrankOfficeTableMap = new Dictionary<int, int[,]>();
		FrankOfficeTableMap.Add (1, FrankOfficeTableHidden);
		FrankOfficeTableMap.Add (2, FrankOfficeTableA);
		
		FrankOffice = new Interactable("FrankOffice", FrankOfficeDialogMap, FrankOfficeTableMap);

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------Drake---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> DrakeDialogList1 = new List<string>();
		DrakeDialogList1.Add("I am zoey");
		DrakeDialogList1.Add("I am zoey2");
		DrakeDialogList1.Add("I am zoey3");
		DrakeDialogList1.Add("I am zoey4");
		DrakeDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> DrakeDialogList2 = new List<string>();
		DrakeDialogList2.Add("I am zodfsdfey");
		DrakeDialogList2.Add("I am zoesdfsdfy2");
		DrakeDialogList2.Add("I am zoesdfsdfsdfy3");
		DrakeDialogList2.Add("I am zoegtrgery4");
		DrakeDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> DrakeDialogMap = new Dictionary<int, List<string>>();
		DrakeDialogMap.Add (1, DrakeDialogList1);
		DrakeDialogMap.Add (2, DrakeDialogList2);
		
		
		int[,] DrakeTableHidden = new int[,]{
			
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
		
		
		int[,] DrakeTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,1},
			/*5*/			{1,1},
			/*6*/			{1,0},
			/*7*/			{1,1},
			/*8*/			{1,1},
			/*9*/			{1,0},
			/*10*/			{1,1},
			/*11*/			{4,1},
			/*12*/			{1,0},
			/*13*/			{4,1},
			/*14*/			{4,1},
			/*15*/			{4,0},
			/*16*/			{5,1},
			/*17*/			{1,1},
			/*18*/			{1,0},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		
		
		Dictionary<int, int[,]> DrakeTableMap = new Dictionary<int, int[,]>();
		DrakeTableMap.Add (1, DrakeTableHidden);
		DrakeTableMap.Add (2, DrakeTableA);
		
		Drake = new Interactable("Drake", DrakeDialogMap, DrakeTableMap);

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------Hannah---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> HannahDialogList1 = new List<string>();
		HannahDialogList1.Add("I am zoey");
		HannahDialogList1.Add("I am zoey2");
		HannahDialogList1.Add("I am zoey3");
		HannahDialogList1.Add("I am zoey4");
		HannahDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> HannahDialogList2 = new List<string>();
		HannahDialogList2.Add("I am zodfsdfey");
		HannahDialogList2.Add("I am zoesdfsdfy2");
		HannahDialogList2.Add("I am zoesdfsdfsdfy3");
		HannahDialogList2.Add("I am zoegtrgery4");
		HannahDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> HannahDialogMap = new Dictionary<int, List<string>>();
		HannahDialogMap.Add (1, HannahDialogList1);
		HannahDialogMap.Add (2, HannahDialogList2);
		
		
		int[,] HannahTableHidden = new int[,]{
			
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
		
		
		int[,] HannahTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{1,1},
			/*3*/			{1,1},
			/*4*/			{1,1},
			/*5*/			{1,1},
			/*6*/			{1,1},
			/*7*/			{1,1},
			/*8*/			{1,1},
			/*9*/			{1,0},
			/*10*/			{1,1},
			/*11*/			{4,1},
			/*12*/			{1,1},
			/*13*/			{4,1},
			/*14*/			{4,0},
			/*15*/			{4,0},
			/*16*/			{5,1},
			/*17*/			{1,1},
			/*18*/			{1,1},
			/*19*/			{1,1},
			/*20*/			{1,1},
			/*21*/			{1,1},
		};
		
		
		Dictionary<int, int[,]> HannahTableMap = new Dictionary<int, int[,]>();
		HannahTableMap.Add (1, HannahTableHidden);
		HannahTableMap.Add (2, HannahTableA);
		
		Hannah = new Interactable("Hannah", HannahDialogMap, HannahTableMap);

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------Melissa---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> MelissaDialogList1 = new List<string>();
		MelissaDialogList1.Add("I am GAYYYYYYE");
		MelissaDialogList1.Add("I am BATMAN");
		MelissaDialogList1.Add("I am FCK MAN");
		MelissaDialogList1.Add("I am AHHHHHHHHHHHHHHH");
		MelissaDialogList1.Add("I am rgerjhgerretrhernfdjfrgerjifert");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> MelissaDialogList2 = new List<string>();
		MelissaDialogList2.Add("I am zodfsdfey");
		MelissaDialogList2.Add("I am zoesdfsdfy2");
		MelissaDialogList2.Add("I am zoesdfsdfsdfy3");
		MelissaDialogList2.Add("I am zoegtrgery4");
		MelissaDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> MelissaDialogMap = new Dictionary<int, List<string>>();
		MelissaDialogMap.Add (1, MelissaDialogList1);
		MelissaDialogMap.Add (2, MelissaDialogList2);
		
		
		int[,] MelissaTableHidden = new int[,]{
			
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
		
		
		int[,] MelissaTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,1},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,1},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,1},
			/*10*/			{1,0},
			/*11*/			{4,0},
			/*12*/			{1,1},
			/*13*/			{4,0},
			/*14*/			{4,0},
			/*15*/			{4,1},
			/*16*/			{5,0},
			/*17*/			{1,0},
			/*18*/			{1,1},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,1},
		};
		
		
		Dictionary<int, int[,]> MelissaTableMap = new Dictionary<int, int[,]>();
		MelissaTableMap.Add (1, MelissaTableHidden);
		MelissaTableMap.Add (2, MelissaTableA);
		
		Melissa = new Interactable("Melissa", MelissaDialogMap, MelissaTableMap);

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------Brenda---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> BrendaDialogList1 = new List<string>();
		BrendaDialogList1.Add("I am GAYYYYYYE");
		BrendaDialogList1.Add("I am BATMAN");
		BrendaDialogList1.Add("I am FCK MAN");
		BrendaDialogList1.Add("I am AHHHHHHHHHHHHHHH");
		BrendaDialogList1.Add("I am rgerjhgerretrhernfdjfrgerjifert");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> BrendaDialogList2 = new List<string>();
		BrendaDialogList2.Add("I am zodfsdfey");
		BrendaDialogList2.Add("I am zoesdfsdfy2");
		BrendaDialogList2.Add("I am zoesdfsdfsdfy3");
		BrendaDialogList2.Add("I am zoegtrgery4");
		BrendaDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> BrendaDialogMap = new Dictionary<int, List<string>>();
		BrendaDialogMap.Add (1, BrendaDialogList1);
		BrendaDialogMap.Add (2, BrendaDialogList2);
		
		
		int[,] BrendaTableHidden = new int[,]{
			
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
		
		
		int[,] BrendaTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,1},
			/*4*/			{1,0},
			/*5*/			{1,1},
			/*6*/			{1,1},
			/*7*/			{1,0},
			/*8*/			{1,1},
			/*9*/			{1,1},
			/*10*/			{1,0},
			/*11*/			{1,1},
			/*12*/			{1,1},
			/*13*/			{1,0},
			/*14*/			{1,1},
			/*15*/			{1,1},
			/*16*/			{1,0},
			/*17*/			{1,1},
			/*18*/			{1,1},
			/*19*/			{1,0},
			/*20*/			{1,1},
			/*21*/			{1,1},
		};
		
		
		Dictionary<int, int[,]> BrendaTableMap = new Dictionary<int, int[,]>();
		BrendaTableMap.Add (1, BrendaTableHidden);
		BrendaTableMap.Add (2, BrendaTableA);
		
		Brenda = new Interactable("Brenda", BrendaDialogMap, BrendaTableMap);

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------ZackAmanda---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> ZackAmandaDialogList1 = new List<string>();
		ZackAmandaDialogList1.Add("I am GAYYYYYYE");
		ZackAmandaDialogList1.Add("I am BATMAN");
		ZackAmandaDialogList1.Add("I am FCK MAN");
		ZackAmandaDialogList1.Add("I am AHHHHHHHHHHHHHHH");
		ZackAmandaDialogList1.Add("I am rgerjhgerretrhernfdjfrgerjifert");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> ZackAmandaDialogList2 = new List<string>();
		ZackAmandaDialogList2.Add("I am zodfsdfey");
		ZackAmandaDialogList2.Add("I am zoesdfsdfy2");
		ZackAmandaDialogList2.Add("I am zoesdfsdfsdfy3");
		ZackAmandaDialogList2.Add("I am zoegtrgery4");
		ZackAmandaDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> ZackAmandaDialogMap = new Dictionary<int, List<string>>();
		ZackAmandaDialogMap.Add (1, ZackAmandaDialogList1);
		ZackAmandaDialogMap.Add (2, ZackAmandaDialogList2);
		
		
		int[,] ZackAmandaTableHidden = new int[,]{
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{1,1},
			/*3*/			{1,0},
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
		
		
		int[,] ZackAmandaTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{1,1},
			/*3*/			{1,0},
			/*4*/			{1,1},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,1},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,1},
			/*11*/			{1,0},
			/*12*/			{1,0},
			/*13*/			{1,1},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,1},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,1},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		
		
		Dictionary<int, int[,]> ZackAmandaTableMap = new Dictionary<int, int[,]>();
		ZackAmandaTableMap.Add (1, ZackAmandaTableHidden);
		ZackAmandaTableMap.Add (2, ZackAmandaTableA);
		
		ZackAmanda = new Interactable("ZackAmanda", ZackAmandaDialogMap, ZackAmandaTableMap);


		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------ZackBrenda---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> ZackBrendaDialogList1 = new List<string>();
		ZackBrendaDialogList1.Add("I am GAYYYYYYE");
		ZackBrendaDialogList1.Add("I am BATMAN");
		ZackBrendaDialogList1.Add("I am FCK MAN");
		ZackBrendaDialogList1.Add("I am AHHHHHHHHHHHHHHH");
		ZackBrendaDialogList1.Add("I am rgerjhgerretrhernfdjfrgerjifert");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> ZackBrendaDialogList2 = new List<string>();
		ZackBrendaDialogList2.Add("I am zodfsdfey");
		ZackBrendaDialogList2.Add("I am zoesdfsdfy2");
		ZackBrendaDialogList2.Add("I am zoesdfsdfsdfy3");
		ZackBrendaDialogList2.Add("I am zoegtrgery4");
		ZackBrendaDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> ZackBrendaDialogMap = new Dictionary<int, List<string>>();
		ZackBrendaDialogMap.Add (1, ZackBrendaDialogList1);
		ZackBrendaDialogMap.Add (2, ZackBrendaDialogList2);
		
		
		int[,] ZackBrendaTableHidden = new int[,]{
			
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
		
		
		int[,] ZackBrendaTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,1},
			/*4*/			{1,0},
			/*5*/			{1,1},
			/*6*/			{1,1},
			/*7*/			{1,0},
			/*8*/			{1,1},
			/*9*/			{1,1},
			/*10*/			{1,0},
			/*11*/			{1,1},
			/*12*/			{1,1},
			/*13*/			{1,0},
			/*14*/			{1,1},
			/*15*/			{1,1},
			/*16*/			{1,0},
			/*17*/			{1,1},
			/*18*/			{1,1},
			/*19*/			{1,0},
			/*20*/			{1,1},
			/*21*/			{1,1},
		};
		
		
		Dictionary<int, int[,]> ZackBrendaTableMap = new Dictionary<int, int[,]>();
		ZackBrendaTableMap.Add (1, ZackBrendaTableHidden);
		ZackBrendaTableMap.Add (2, ZackBrendaTableA);
		
		ZackBrenda = new Interactable("ZackBrenda", ZackBrendaDialogMap, ZackBrendaTableMap);

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------Larry---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> LarryDialogList1 = new List<string>();
		LarryDialogList1.Add("I am GAYYYYYYE");
		LarryDialogList1.Add("I am BATMAN");
		LarryDialogList1.Add("I am FCK MAN");
		LarryDialogList1.Add("I am AHHHHHHHHHHHHHHH");
		LarryDialogList1.Add("I am rgerjhgerretrhernfdjfrgerjifert");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> LarryDialogList2 = new List<string>();
		LarryDialogList2.Add("I am zodfsdfey");
		LarryDialogList2.Add("I am zoesdfsdfy2");
		LarryDialogList2.Add("I am zoesdfsdfsdfy3");
		LarryDialogList2.Add("I am zoegtrgery4");
		LarryDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> LarryDialogMap = new Dictionary<int, List<string>>();
		LarryDialogMap.Add (1, LarryDialogList1);
		LarryDialogMap.Add (2, LarryDialogList2);
		
		
		int[,] LarryTableHidden = new int[,]{
			
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
		
		
		int[,] LarryTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,1},
			/*5*/			{1,1},
			/*6*/			{1,0},
			/*7*/			{1,1},
			/*8*/			{1,1},
			/*9*/			{1,0},
			/*10*/			{1,1},
			/*11*/			{1,1},
			/*12*/			{1,0},
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
		
		
		Dictionary<int, int[,]> LarryTableMap = new Dictionary<int, int[,]>();
		LarryTableMap.Add (1, LarryTableHidden);
		LarryTableMap.Add (2, LarryTableA);
		
		Larry = new Interactable("Larry", LarryDialogMap, LarryTableMap);


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
			
			/*1*/			{1,1},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,1},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,1},
			/*8*/			{1,1},
			/*9*/			{1,0},
			/*10*/			{1,1},
			/*11*/			{4,0},
			/*12*/			{1,0},
			/*13*/			{4,1},
			/*14*/			{4,0},
			/*15*/			{4,0},
			/*16*/			{5,1},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,1},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};

		int[,] AshtonTableB = new int[,] {
			
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
			/*11*/			{4,1},
			/*12*/			{1,1},
			/*13*/			{4,1},
			/*14*/			{4,1},
			/*15*/			{4,1},
			/*16*/			{5,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		
		
		Dictionary<int, int[,]> AshtonTableMap = new Dictionary<int, int[,]>();
		AshtonTableMap.Add (1, AshtonTableHidden);
		AshtonTableMap.Add (2, AshtonTableA);
		AshtonTableMap.Add (3, AshtonTableB);

		Ashton = new Interactable("Ashton", AshtonDialogMap, AshtonTableMap);


		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------Boltcutters---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> BoltcuttersDialogList1 = new List<string>();
		BoltcuttersDialogList1.Add("I am zoey");
		BoltcuttersDialogList1.Add("I am zoey2");
		BoltcuttersDialogList1.Add("I am zoey3");
		BoltcuttersDialogList1.Add("I am zoey4");
		BoltcuttersDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> BoltcuttersDialogList2 = new List<string>();
		BoltcuttersDialogList2.Add("I am zodfsdfey");
		BoltcuttersDialogList2.Add("I am zoesdfsdfy2");
		BoltcuttersDialogList2.Add("I am zoesdfsdfsdfy3");
		BoltcuttersDialogList2.Add("I am zoegtrgery4");
		BoltcuttersDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> BoltcuttersDialogMap = new Dictionary<int, List<string>>();
		BoltcuttersDialogMap.Add (1, BoltcuttersDialogList1);
		BoltcuttersDialogMap.Add (2, BoltcuttersDialogList2);
		
		
		int[,] BoltcuttersTableHidden = new int[,]{
			
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
		
		
		int[,] BoltcuttersTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,0},
			/*11*/			{4,0},
			/*12*/			{1,0},
			/*13*/			{4,0},
			/*14*/			{4,0},
			/*15*/			{4,0},
			/*16*/			{5,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		
		
		Dictionary<int, int[,]> BoltcuttersTableMap = new Dictionary<int, int[,]>();
		BoltcuttersTableMap.Add (1, BoltcuttersTableHidden);
		BoltcuttersTableMap.Add (2, BoltcuttersTableA);
		
		Boltcutters = new Interactable("Boltcutters", BoltcuttersDialogMap, BoltcuttersTableMap);


		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------HannahPhone---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> HannahPhoneDialogList1 = new List<string>();
		HannahPhoneDialogList1.Add("I am zoey");
		HannahPhoneDialogList1.Add("I am zoey2");
		HannahPhoneDialogList1.Add("I am zoey3");
		HannahPhoneDialogList1.Add("I am zoey4");
		HannahPhoneDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> HannahPhoneDialogList2 = new List<string>();
		HannahPhoneDialogList2.Add("I am zodfsdfey");
		HannahPhoneDialogList2.Add("I am zoesdfsdfy2");
		HannahPhoneDialogList2.Add("I am zoesdfsdfsdfy3");
		HannahPhoneDialogList2.Add("I am zoegtrgery4");
		HannahPhoneDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> HannahPhoneDialogMap = new Dictionary<int, List<string>>();
		HannahPhoneDialogMap.Add (1, HannahPhoneDialogList1);
		HannahPhoneDialogMap.Add (2, HannahPhoneDialogList2);
		
		
		int[,] HannahPhoneTableHidden = new int[,]{
			
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
		
		
		int[,] HannahPhoneTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,1},
			/*8*/			{1,1},
			/*9*/			{1,0},
			/*10*/			{1,0},
			/*11*/			{4,0},
			/*12*/			{1,0},
			/*13*/			{4,0},
			/*14*/			{4,0},
			/*15*/			{4,0},
			/*16*/			{5,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		
		
		Dictionary<int, int[,]> HannahPhoneTableMap = new Dictionary<int, int[,]>();
		HannahPhoneTableMap.Add (1, HannahPhoneTableHidden);
		HannahPhoneTableMap.Add (2, HannahPhoneTableA);
		
		HannahPhone = new Interactable("HannahPhone", HannahPhoneDialogMap, HannahPhoneTableMap);

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
			//------------------------------------------------------------------------PillBottle---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
			List<string> PillBottleDialogList1 = new List<string>();
			PillBottleDialogList1.Add("I am zoey");
			PillBottleDialogList1.Add("I am zoey2");
			PillBottleDialogList1.Add("I am zoey3");
			PillBottleDialogList1.Add("I am zoey4");
			PillBottleDialogList1.Add("I am zoey5");
			
			// Each of these lines will be displayed to the screen. A click will advance to the next line.
			
			List<string> PillBottleDialogList2 = new List<string>();
			PillBottleDialogList2.Add("I am zodfsdfey");
			PillBottleDialogList2.Add("I am zoesdfsdfy2");
			PillBottleDialogList2.Add("I am zoesdfsdfsdfy3");
			PillBottleDialogList2.Add("I am zoegtrgery4");
			PillBottleDialogList2.Add("I am zoeutyutyy5");
			
			
			Dictionary<int, List<string>> PillBottleDialogMap = new Dictionary<int, List<string>>();
			PillBottleDialogMap.Add (1, PillBottleDialogList1);
			PillBottleDialogMap.Add (2, PillBottleDialogList2);
			
			
			int[,] PillBottleTableHidden = new int[,]{
				
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
			
			
			int[,] PillBottleTableA = new int[,] {
				
				//{MapID, is Hidden?}
				
				/*1*/			{1,0},
				/*2*/			{1,0},
				/*3*/			{1,0},
				/*4*/			{1,0},
				/*5*/			{1,0},
				/*6*/			{1,0},
				/*7*/			{1,0},
				/*8*/			{1,0},
				/*9*/			{1,0},
				/*10*/			{1,0},
				/*11*/			{1,0},
				/*12*/			{1,0},
				/*13*/			{1,0},
				/*14*/			{1,0},
				/*15*/			{1,0},
				/*16*/			{1,0},
				/*17*/			{1,0},
				/*18*/			{1,0},
				/*19*/			{1,0},
				/*20*/			{1,0},
				/*21*/			{1,0},
			};
			
			
			Dictionary<int, int[,]> PillBottleTableMap = new Dictionary<int, int[,]>();
			PillBottleTableMap.Add (1, PillBottleTableHidden);
			PillBottleTableMap.Add (2, PillBottleTableA);
			
		PillBottle = new Interactable("PillBottle", PillBottleDialogMap, PillBottleTableMap);

			//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
			//------------------------------------------------------------------------BrendasHouseKey---------------------------------------------------------------------------|
			//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
			List<string> BrendasHouseKeyDialogList1 = new List<string>();
		BrendasHouseKeyDialogList1.Add("I am zoey");
		BrendasHouseKeyDialogList1.Add("I am zoey2");
		BrendasHouseKeyDialogList1.Add("I am zoey3");
		BrendasHouseKeyDialogList1.Add("I am zoey4");
		BrendasHouseKeyDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> BrendasHouseKeyDialogList2 = new List<string>();
		BrendasHouseKeyDialogList2.Add("I am zodfsdfey");
		BrendasHouseKeyDialogList2.Add("I am zoesdfsdfy2");
		BrendasHouseKeyDialogList2.Add("I am zoesdfsdfsdfy3");
		BrendasHouseKeyDialogList2.Add("I am zoegtrgery4");
		BrendasHouseKeyDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> BrendasHouseKeyDialogMap = new Dictionary<int, List<string>>();
		BrendasHouseKeyDialogMap.Add (1, BrendasHouseKeyDialogList1);
		BrendasHouseKeyDialogMap.Add (2, BrendasHouseKeyDialogList2);
		
		
		int[,] BrendasHouseKeyTableHidden = new int[,]{
			
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
		
		
		int[,] BrendasHouseKeyTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,0},
			/*11*/			{1,0},
			/*12*/			{1,0},
			/*13*/			{1,0},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		
		
		Dictionary<int, int[,]> BrendasHouseKeyTableMap = new Dictionary<int, int[,]>();
		BrendasHouseKeyTableMap.Add (1, BrendasHouseKeyTableHidden);
		BrendasHouseKeyTableMap.Add (2, BrendasHouseKeyTableA);
		
		BrendasHouseKey = new Interactable("BrendasHouseKey", BrendasHouseKeyDialogMap, BrendasHouseKeyTableMap);

			//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
			//------------------------------------------------------------------------Textbook---------------------------------------------------------------------------|
			//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
			List<string> TextbookDialogList1 = new List<string>();
		TextbookDialogList1.Add("I am zoey");
		TextbookDialogList1.Add("I am zoey2");
		TextbookDialogList1.Add("I am zoey3");
		TextbookDialogList1.Add("I am zoey4");
		TextbookDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> TextbookDialogList2 = new List<string>();
		TextbookDialogList2.Add("I am zodfsdfey");
		TextbookDialogList2.Add("I am zoesdfsdfy2");
		TextbookDialogList2.Add("I am zoesdfsdfsdfy3");
		TextbookDialogList2.Add("I am zoegtrgery4");
		TextbookDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> TextbookDialogMap = new Dictionary<int, List<string>>();
		TextbookDialogMap.Add (1, TextbookDialogList1);
		TextbookDialogMap.Add (2, TextbookDialogList2);
		
		
		int[,] TextbookTableHidden = new int[,]{
			
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
		
		
		int[,] TextbookTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,0},
			/*11*/			{1,0},
			/*12*/			{1,0},
			/*13*/			{1,0},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		
		
		Dictionary<int, int[,]> TextbookTableMap = new Dictionary<int, int[,]>();
		TextbookTableMap.Add (1, TextbookTableHidden);
		TextbookTableMap.Add (2, TextbookTableA);
		
		Textbook = new Interactable("Textbook", TextbookDialogMap, TextbookTableMap)

			//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
			//------------------------------------------------------------------------Axe---------------------------------------------------------------------------|
			//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
			List<string> AxeDialogList1 = new List<string>();
		AxeDialogList1.Add("I am zoey");
		AxeDialogList1.Add("I am zoey2");
		AxeDialogList1.Add("I am zoey3");
		AxeDialogList1.Add("I am zoey4");
		AxeDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> AxeDialogList2 = new List<string>();
		AxeDialogList2.Add("I am zodfsdfey");
		AxeDialogList2.Add("I am zoesdfsdfy2");
		AxeDialogList2.Add("I am zoesdfsdfsdfy3");
		AxeDialogList2.Add("I am zoegtrgery4");
		AxeDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> AxeDialogMap = new Dictionary<int, List<string>>();
		AxeDialogMap.Add (1, AxeDialogList1);
		AxeDialogMap.Add (2, AxeDialogList2);
		
		
		int[,] AxeTableHidden = new int[,]{
			
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
		
		
		int[,] AxeTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,0},
			/*11*/			{1,0},
			/*12*/			{1,0},
			/*13*/			{1,0},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		
		
		Dictionary<int, int[,]> AxeTableMap = new Dictionary<int, int[,]>();
		AxeTableMap.Add (1, AxeTableHidden);
		AxeTableMap.Add (2, AxeTableA);
		
		Axe = new Interactable("Axe", AxeDialogMap, AxeTableMap);

			//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
			//------------------------------------------------------------------------BasementRoomKey---------------------------------------------------------------------------|
			//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
			List<string> BasementRoomKeyDialogList1 = new List<string>();
		BasementRoomKeyDialogList1.Add("I am zoey");
		BasementRoomKeyDialogList1.Add("I am zoey2");
		BasementRoomKeyDialogList1.Add("I am zoey3");
		BasementRoomKeyDialogList1.Add("I am zoey4");
		BasementRoomKeyDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> BasementRoomKeyDialogList2 = new List<string>();
		BasementRoomKeyDialogList2.Add("I am zodfsdfey");
		BasementRoomKeyDialogList2.Add("I am zoesdfsdfy2");
		BasementRoomKeyDialogList2.Add("I am zoesdfsdfsdfy3");
		BasementRoomKeyDialogList2.Add("I am zoegtrgery4");
		BasementRoomKeyDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> BasementRoomKeyDialogMap = new Dictionary<int, List<string>>();
		BasementRoomKeyDialogMap.Add (1, BasementRoomKeyDialogList1);
		BasementRoomKeyDialogMap.Add (2, BasementRoomKeyDialogList2);
		
		
		int[,] BasementRoomKeyTableHidden = new int[,]{
			
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
		
		
		int[,] BasementRoomKeyTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,0},
			/*11*/			{1,0},
			/*12*/			{1,0},
			/*13*/			{1,0},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		
		
		Dictionary<int, int[,]> BasementRoomKeyTableMap = new Dictionary<int, int[,]>();
		BasementRoomKeyTableMap.Add (1, BasementRoomKeyTableHidden);
		BasementRoomKeyTableMap.Add (2, BasementRoomKeyTableA);
		
		BasementRoomKey = new Interactable("BasementRoomKey", BasementRoomKeyDialogMap, BasementRoomKeyTableMap);

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------LarryHouseKey---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> LarryHouseKeyDialogList1 = new List<string>();
		LarryHouseKeyDialogList1.Add("I am zoey");
		LarryHouseKeyDialogList1.Add("I am zoey2");
		LarryHouseKeyDialogList1.Add("I am zoey3");
		LarryHouseKeyDialogList1.Add("I am zoey4");
		LarryHouseKeyDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> LarryHouseKeyDialogList2 = new List<string>();
		LarryHouseKeyDialogList2.Add("I am zodfsdfey");
		LarryHouseKeyDialogList2.Add("I am zoesdfsdfy2");
		LarryHouseKeyDialogList2.Add("I am zoesdfsdfsdfy3");
		LarryHouseKeyDialogList2.Add("I am zoegtrgery4");
		LarryHouseKeyDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> LarryHouseKeyDialogMap = new Dictionary<int, List<string>>();
		LarryHouseKeyDialogMap.Add (1, LarryHouseKeyDialogList1);
		LarryHouseKeyDialogMap.Add (2, LarryHouseKeyDialogList2);
		
		
		int[,] LarryHouseKeyTableHidden = new int[,]{
			
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
		
		
		int[,] LarryHouseKeyTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,0},
			/*11*/			{1,0},
			/*12*/			{1,0},
			/*13*/			{1,0},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		
		
		Dictionary<int, int[,]> LarryHouseKeyTableMap = new Dictionary<int, int[,]>();
		LarryHouseKeyTableMap.Add (1, LarryHouseKeyTableHidden);
		LarryHouseKeyTableMap.Add (2, LarryHouseKeyTableA);
		
		LarryHouseKey = new Interactable("LarryHouseKey", LarryHouseKeyDialogMap, LarryHouseKeyTableMap);

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------Railing---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> RailingDialogList1 = new List<string>();
		RailingDialogList1.Add("I am zoey");
		RailingDialogList1.Add("I am zoey2");
		RailingDialogList1.Add("I am zoey3");
		RailingDialogList1.Add("I am zoey4");
		RailingDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> RailingDialogList2 = new List<string>();
		RailingDialogList2.Add("I am zodfsdfey");
		RailingDialogList2.Add("I am zoesdfsdfy2");
		RailingDialogList2.Add("I am zoesdfsdfsdfy3");
		RailingDialogList2.Add("I am zoegtrgery4");
		RailingDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> RailingDialogMap = new Dictionary<int, List<string>>();
		RailingDialogMap.Add (1, RailingDialogList1);
		RailingDialogMap.Add (2, RailingDialogList2);
		
		
		int[,] RailingTableHidden = new int[,]{
			
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
		
		
		int[,] RailingTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,1},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,1},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,1},
			/*10*/			{1,0},
			/*11*/			{1,0},
			/*12*/			{1,1},
			/*13*/			{1,0},
			/*14*/			{1,0},
			/*15*/			{1,1},
			/*16*/			{1,0},
			/*17*/			{1,0},
			/*18*/			{1,1},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,1},
		};
		
		
		Dictionary<int, int[,]> RailingTableMap = new Dictionary<int, int[,]>();
		RailingTableMap.Add (1, RailingTableHidden);
		RailingTableMap.Add (2, RailingTableA);
		
		Railing = new Interactable("Railing", RailingDialogMap, RailingTableMap);

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------HeartMeds---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> HeartMedsDialogList1 = new List<string>();
		HeartMedsDialogList1.Add("I am zoey");
		HeartMedsDialogList1.Add("I am zoey2");
		HeartMedsDialogList1.Add("I am zoey3");
		HeartMedsDialogList1.Add("I am zoey4");
		HeartMedsDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> HeartMedsDialogList2 = new List<string>();
		HeartMedsDialogList2.Add("I am zodfsdfey");
		HeartMedsDialogList2.Add("I am zoesdfsdfy2");
		HeartMedsDialogList2.Add("I am zoesdfsdfsdfy3");
		HeartMedsDialogList2.Add("I am zoegtrgery4");
		HeartMedsDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> HeartMedsDialogMap = new Dictionary<int, List<string>>();
		HeartMedsDialogMap.Add (1, HeartMedsDialogList1);
		HeartMedsDialogMap.Add (2, HeartMedsDialogList2);
		
		
		int[,] HeartMedsTableHidden = new int[,]{
			
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
		
		
		int[,] HeartMedsTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,0},
			/*11*/			{1,0},
			/*12*/			{1,0},
			/*13*/			{1,0},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		
		
		Dictionary<int, int[,]> HeartMedsTableMap = new Dictionary<int, int[,]>();
		HeartMedsTableMap.Add (1, HeartMedsTableHidden);
		HeartMedsTableMap.Add (2, HeartMedsTableA);
		
		HeartMeds = new Interactable("HeartMeds", HeartMedsDialogMap, HeartMedsTableMap);


		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------Stove---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> StoveDialogList1 = new List<string>();
		StoveDialogList1.Add("I am zoey");
		StoveDialogList1.Add("I am zoey2");
		StoveDialogList1.Add("I am zoey3");
		StoveDialogList1.Add("I am zoey4");
		StoveDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> StoveDialogList2 = new List<string>();
		StoveDialogList2.Add("I am zodfsdfey");
		StoveDialogList2.Add("I am zoesdfsdfy2");
		StoveDialogList2.Add("I am zoesdfsdfsdfy3");
		StoveDialogList2.Add("I am zoegtrgery4");
		StoveDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> StoveDialogMap = new Dictionary<int, List<string>>();
		StoveDialogMap.Add (1, StoveDialogList1);
		StoveDialogMap.Add (2, StoveDialogList2);
		
		
		int[,] StoveTableHidden = new int[,]{
			
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
		
		
		int[,] StoveTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{1,1},
			/*3*/			{1,0},
			/*4*/			{1,1},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,1},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,1},
			/*11*/			{1,0},
			/*12*/			{1,0},
			/*13*/			{1,1},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,1},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,1},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		
		
		Dictionary<int, int[,]> StoveTableMap = new Dictionary<int, int[,]>();
		StoveTableMap.Add (1, StoveTableHidden);
		StoveTableMap.Add (2, StoveTableA);
		
		Stove = new Interactable("Stove", StoveDialogMap, StoveTableMap);

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------WaterHeater---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> WaterHeaterDialogList1 = new List<string>();
		WaterHeaterDialogList1.Add("I am zoey");
		WaterHeaterDialogList1.Add("I am zoey2");
		WaterHeaterDialogList1.Add("I am zoey3");
		WaterHeaterDialogList1.Add("I am zoey4");
		WaterHeaterDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> WaterHeaterDialogList2 = new List<string>();
		WaterHeaterDialogList2.Add("I am zodfsdfey");
		WaterHeaterDialogList2.Add("I am zoesdfsdfy2");
		WaterHeaterDialogList2.Add("I am zoesdfsdfsdfy3");
		WaterHeaterDialogList2.Add("I am zoegtrgery4");
		WaterHeaterDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> WaterHeaterDialogMap = new Dictionary<int, List<string>>();
		WaterHeaterDialogMap.Add (1, WaterHeaterDialogList1);
		WaterHeaterDialogMap.Add (2, WaterHeaterDialogList2);
		
		
		int[,] WaterHeaterTableHidden = new int[,]{
			
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
		
		
		int[,] WaterHeaterTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,0},
			/*11*/			{1,0},
			/*12*/			{1,0},
			/*13*/			{1,0},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		
		
		Dictionary<int, int[,]> WaterHeaterTableMap = new Dictionary<int, int[,]>();
		WaterHeaterTableMap.Add (1, WaterHeaterTableHidden);
		WaterHeaterTableMap.Add (2, WaterHeaterTableA);
		
		WaterHeater = new Interactable("WaterHeater", WaterHeaterDialogMap, WaterHeaterTableMap);


		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------Dresser---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> DresserDialogList1 = new List<string>();
		DresserDialogList1.Add("I am zoey");
		DresserDialogList1.Add("I am zoey2");
		DresserDialogList1.Add("I am zoey3");
		DresserDialogList1.Add("I am zoey4");
		DresserDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> DresserDialogList2 = new List<string>();
		DresserDialogList2.Add("I am zodfsdfey");
		DresserDialogList2.Add("I am zoesdfsdfy2");
		DresserDialogList2.Add("I am zoesdfsdfsdfy3");
		DresserDialogList2.Add("I am zoegtrgery4");
		DresserDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> DresserDialogMap = new Dictionary<int, List<string>>();
		DresserDialogMap.Add (1, DresserDialogList1);
		DresserDialogMap.Add (2, DresserDialogList2);
		
		
		int[,] DresserTableHidden = new int[,]{
			
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
		
		
		int[,] DresserTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,0},
			/*11*/			{1,0},
			/*12*/			{1,0},
			/*13*/			{1,0},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		
		
		Dictionary<int, int[,]> DresserTableMap = new Dictionary<int, int[,]>();
		DresserTableMap.Add (1, DresserTableHidden);
		DresserTableMap.Add (2, DresserTableA);
		
		Dresser = new Interactable("Dresser", DresserDialogMap, DresserTableMap);

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------Electronics---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> ElectronicsDialogList1 = new List<string>();
		ElectronicsDialogList1.Add("I am zoey");
		ElectronicsDialogList1.Add("I am zoey2");
		ElectronicsDialogList1.Add("I am zoey3");
		ElectronicsDialogList1.Add("I am zoey4");
		ElectronicsDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> ElectronicsDialogList2 = new List<string>();
		ElectronicsDialogList2.Add("I am zodfsdfey");
		ElectronicsDialogList2.Add("I am zoesdfsdfy2");
		ElectronicsDialogList2.Add("I am zoesdfsdfsdfy3");
		ElectronicsDialogList2.Add("I am zoegtrgery4");
		ElectronicsDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> ElectronicsDialogMap = new Dictionary<int, List<string>>();
		ElectronicsDialogMap.Add (1, ElectronicsDialogList1);
		ElectronicsDialogMap.Add (2, ElectronicsDialogList2);
		
		
		int[,] ElectronicsTableHidden = new int[,]{
			
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
		
		
		int[,] ElectronicsTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{1,1},
			/*3*/			{1,1},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,1},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,1},
			/*10*/			{1,0},
			/*11*/			{1,0},
			/*12*/			{1,1},
			/*13*/			{1,0},
			/*14*/			{1,0},
			/*15*/			{1,1},
			/*16*/			{1,0},
			/*17*/			{1,0},
			/*18*/			{1,1},
			/*19*/			{1,1},
			/*20*/			{1,1},
			/*21*/			{1,1},
		};
		
		
		Dictionary<int, int[,]> ElectronicsTableMap = new Dictionary<int, int[,]>();
		ElectronicsTableMap.Add (1, ElectronicsTableHidden);
		ElectronicsTableMap.Add (2, ElectronicsTableA);
		
		Electronics = new Interactable("Electronics", ElectronicsDialogMap, ElectronicsTableMap);

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------TV---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> TVDialogList1 = new List<string>();
		TVDialogList1.Add("I am zoey");
		TVDialogList1.Add("I am zoey2");
		TVDialogList1.Add("I am zoey3");
		TVDialogList1.Add("I am zoey4");
		TVDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> TVDialogList2 = new List<string>();
		TVDialogList2.Add("I am zodfsdfey");
		TVDialogList2.Add("I am zoesdfsdfy2");
		TVDialogList2.Add("I am zoesdfsdfsdfy3");
		TVDialogList2.Add("I am zoegtrgery4");
		TVDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> TVDialogMap = new Dictionary<int, List<string>>();
		TVDialogMap.Add (1, TVDialogList1);
		TVDialogMap.Add (2, TVDialogList2);
		
		
		int[,] TVTableHidden = new int[,]{
			
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
		
		
		int[,] TVTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{1,1},
			/*3*/			{1,1},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,1},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,1},
			/*10*/			{1,0},
			/*11*/			{1,0},
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
		
		
		Dictionary<int, int[,]> TVTableMap = new Dictionary<int, int[,]>();
		TVTableMap.Add (1, TVTableHidden);
		TVTableMap.Add (2, TVTableA);
		
		TV = new Interactable("TV", TVDialogMap, TVTableMap);

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------BrendaDoor---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> BrendaDoorDialogList1 = new List<string>();
		BrendaDoorDialogList1.Add("I am zoey");
		BrendaDoorDialogList1.Add("I am zoey2");
		BrendaDoorDialogList1.Add("I am zoey3");
		BrendaDoorDialogList1.Add("I am zoey4");
		BrendaDoorDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> BrendaDoorDialogList2 = new List<string>();
		BrendaDoorDialogList2.Add("I am zodfsdfey");
		BrendaDoorDialogList2.Add("I am zoesdfsdfy2");
		BrendaDoorDialogList2.Add("I am zoesdfsdfsdfy3");
		BrendaDoorDialogList2.Add("I am zoegtrgery4");
		BrendaDoorDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> BrendaDoorDialogMap = new Dictionary<int, List<string>>();
		BrendaDoorDialogMap.Add (1, BrendaDoorDialogList1);
		BrendaDoorDialogMap.Add (2, BrendaDoorDialogList2);
		
		
		int[,] BrendaDoorTableHidden = new int[,]{
			
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
		
		
		int[,] BrendaDoorTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{1,1},
			/*3*/			{1,0},
			/*4*/			{1,1},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,1},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,1},
			/*11*/			{1,0},
			/*12*/			{1,0},
			/*13*/			{1,1},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,1},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,1},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		
		
		Dictionary<int, int[,]> BrendaDoorTableMap = new Dictionary<int, int[,]>();
		BrendaDoorTableMap.Add (1, BrendaDoorTableHidden);
		BrendaDoorTableMap.Add (2, BrendaDoorTableA);
		
		BrendaDoor = new Interactable("BrendaDoor", BrendaDoorDialogMap, BrendaDoorTableMap);

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------LarryDoor---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> LarryDoorDialogList1 = new List<string>();
		LarryDoorDialogList1.Add("I am zoey");
		LarryDoorDialogList1.Add("I am zoey2");
		LarryDoorDialogList1.Add("I am zoey3");
		LarryDoorDialogList1.Add("I am zoey4");
		LarryDoorDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> LarryDoorDialogList2 = new List<string>();
		LarryDoorDialogList2.Add("I am zodfsdfey");
		LarryDoorDialogList2.Add("I am zoesdfsdfy2");
		LarryDoorDialogList2.Add("I am zoesdfsdfsdfy3");
		LarryDoorDialogList2.Add("I am zoegtrgery4");
		LarryDoorDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> LarryDoorDialogMap = new Dictionary<int, List<string>>();
		LarryDoorDialogMap.Add (1, LarryDoorDialogList1);
		LarryDoorDialogMap.Add (2, LarryDoorDialogList2);
		
		
		int[,] LarryDoorTableHidden = new int[,]{
			
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
		
		
		int[,] LarryDoorTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,1},
			/*2*/			{1,1},
			/*3*/			{1,1},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,1},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,1},
			/*10*/			{1,0},
			/*11*/			{1,0},
			/*12*/			{1,1},
			/*13*/			{1,0},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		
		
		Dictionary<int, int[,]> LarryDoorTableMap = new Dictionary<int, int[,]>();
		LarryDoorTableMap.Add (1, LarryDoorTableHidden);
		LarryDoorTableMap.Add (2, LarryDoorTableA);
		
		LarryDoor = new Interactable("LarryDoor", LarryDoorDialogMap, LarryDoorTableMap);

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		//------------------------------------------------------------------------BasementDoor---------------------------------------------------------------------------|
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++|
		List<string> BasementDoorDialogList1 = new List<string>();
		BasementDoorDialogList1.Add("I am zoey");
		BasementDoorDialogList1.Add("I am zoey2");
		BasementDoorDialogList1.Add("I am zoey3");
		BasementDoorDialogList1.Add("I am zoey4");
		BasementDoorDialogList1.Add("I am zoey5");
		
		// Each of these lines will be displayed to the screen. A click will advance to the next line.
		
		List<string> BasementDoorDialogList2 = new List<string>();
		BasementDoorDialogList2.Add("I am zodfsdfey");
		BasementDoorDialogList2.Add("I am zoesdfsdfy2");
		BasementDoorDialogList2.Add("I am zoesdfsdfsdfy3");
		BasementDoorDialogList2.Add("I am zoegtrgery4");
		BasementDoorDialogList2.Add("I am zoeutyutyy5");
		
		
		Dictionary<int, List<string>> BasementDoorDialogMap = new Dictionary<int, List<string>>();
		BasementDoorDialogMap.Add (1, BasementDoorDialogList1);
		BasementDoorDialogMap.Add (2, BasementDoorDialogList2);
		
		
		int[,] BasementDoorTableHidden = new int[,]{
			
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
		
		
		int[,] BasementDoorTableA = new int[,] {
			
			//{MapID, is Hidden?}
			
			/*1*/			{1,0},
			/*2*/			{1,0},
			/*3*/			{1,0},
			/*4*/			{1,0},
			/*5*/			{1,0},
			/*6*/			{1,0},
			/*7*/			{1,0},
			/*8*/			{1,0},
			/*9*/			{1,0},
			/*10*/			{1,0},
			/*11*/			{1,0},
			/*12*/			{1,0},
			/*13*/			{1,0},
			/*14*/			{1,0},
			/*15*/			{1,0},
			/*16*/			{1,0},
			/*17*/			{1,0},
			/*18*/			{1,0},
			/*19*/			{1,0},
			/*20*/			{1,0},
			/*21*/			{1,0},
		};
		
		
		Dictionary<int, int[,]> BasementDoorTableMap = new Dictionary<int, int[,]>();
		BasementDoorTableMap.Add (1, BasementDoorTableHidden);
		BasementDoorTableMap.Add (2, BasementDoorTableA);
		
		BasementDoor = new Interactable("BasementDoor", BasementDoorDialogMap, BasementDoorTableMap);

}

}



