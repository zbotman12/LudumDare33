using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class InteractionManager : MonoBehaviour {


	public class Interactable{
		public string name;
		public Dictionary<int, List<string>> dialogMap;
		public Dictionary<int, int[,]> triggerTables;
		
		public Interactable(string obj, Dictionary<int, List<string>> Map, Dictionary<int, int[,]> tables){
			name = obj;
			dialogMap = Map;
			triggerTables = tables;
		}
	}

	public Interactable Amanda;
	public Interactable Danny;
	public Interactable Emma;
	public Interactable ClaireRoom;
	public Interactable ClaireRoof;
	public Interactable FrankRoom;
	public Interactable FrankOffice;
	public Interactable zoeyRoom;
	public Interactable zoeyBasement;
	public Interactable Drake;
	public Interactable Ashton;
	public Interactable Hannah;
	public Interactable Melissa;
	public Interactable Brenda;
	public Interactable Zack;
	public Interactable Larry;



	// Use this for initialization
	void Awake() {
	
	//ZoeyRoom
		List<string> zoeyRoomDialogList1 = new List<string>();
		zoeyRoomDialogList1.Add("I am zoey");
		zoeyRoomDialogList1.Add("I am zoey2");
		zoeyRoomDialogList1.Add("I am zoey3");
		zoeyRoomDialogList1.Add("I am zoey4");
		zoeyRoomDialogList1.Add("I am zoey5");

		List<string> zoeyRoomDialogList2 = new List<string>();
		zoeyRoomDialogList2.Add("I am zodfsdfey");
		zoeyRoomDialogList2.Add("I am zoesdfsdfy2");
		zoeyRoomDialogList2.Add("I am zoesdfsdfsdfy3");
		zoeyRoomDialogList2.Add("I am zoegtrgery4");
		zoeyRoomDialogList2.Add("I am zoeutyutyy5");


		Dictionary<int, List<string>> zoeyRoomDialogMap = new Dictionary<int, List<string>>();
		zoeyRoomDialogMap.Add (1, zoeyRoomDialogList1);
		zoeyRoomDialogMap.Add (2, zoeyRoomDialogList2);


		int[,] zoeyRoomTableA = new int[,]{
			//{Do pass time, MapID, is Hidden?}
			/*1*/			{1,1,1},
			/*2*/			{1,1,1},
			/*3*/			{1,1,1},
			/*4*/			{1,1,1},
			/*5*/			{1,1,1},
			/*6*/			{1,1,1},
			/*7*/			{1,1,1},
			/*8*/			{1,1,1},
			/*9*/			{1,1,1},
			/*10*/			{1,1,1},
			/*11*/			{1,1,1},
			/*12*/			{1,1,1},
			/*13*/			{1,1,1},
			/*14*/			{1,1,1},
			/*15*/			{1,1,1},
			/*16*/			{1,1,1},
			/*17*/			{1,1,1},
			/*18*/			{1,1,1},
			/*19*/			{1,1,1},
			/*20*/			{1,1,1},
			/*21*/			{1,1,1},
		};

		
		int[,] zoeyRoomTableB = new int[,] {
			//{Do pass time, MapID, is Hidden?}
			/*1*/			{1,1,1},
			/*2*/			{1,1,1},
			/*3*/			{1,1,1},
			/*4*/			{1,1,1},
			/*5*/			{1,1,1},
			/*6*/			{1,1,1},
			/*7*/			{1,1,1},
			/*8*/			{1,1,1},
			/*9*/			{1,1,1},
			/*10*/			{1,1,1},
			/*11*/			{1,1,1},
			/*12*/			{1,1,1},
			/*13*/			{1,1,1},
			/*14*/			{1,1,1},
			/*15*/			{1,1,1},
			/*16*/			{1,1,1},
			/*17*/			{1,1,1},
			/*18*/			{1,1,1},
			/*19*/			{1,1,1},
			/*20*/			{1,1,1},
			/*21*/			{1,1,1},
		};


		Dictionary<int, int[,]> zoeyRoomTableMap = new Dictionary<int, int[,]>();
			zoeyRoomTableMap.Add (1, zoeyRoomTableA);
			zoeyRoomTableMap.Add (2, zoeyRoomTableB);

		zoeyRoom = new Interactable("zoeyRoom", zoeyRoomDialogMap, zoeyRoomTableMap);

	//ZoeyBasment
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
	
		int[,] zoeyBaseTableA = new int[,]{
		//{Do pass time, MapID, is Hidden?}
		/*1*/			{1,1,1},
		/*2*/			{1,1,1},
		/*3*/			{1,1,1},
		/*4*/			{1,1,1},
		/*5*/			{1,1,1},
		/*6*/			{1,1,1},
		/*7*/			{1,1,1},
		/*8*/			{1,1,1},
		/*9*/			{1,1,1},
		/*10*/			{1,1,1},
		/*11*/			{1,1,1},
		/*12*/			{1,1,1},
		/*13*/			{1,1,1},
		/*14*/			{1,1,1},
		/*15*/			{1,1,1},
		/*16*/			{1,1,1},
		/*17*/			{1,1,1},
		/*18*/			{1,1,1},
		/*19*/			{1,1,1},
		/*20*/			{1,1,1},
		/*21*/			{1,1,1},
	};
	
	
		int[,] zoeyBaseTableB = new int[,]{
		//{Do pass time, MapID, is Hidden?}
		/*1*/			{1,1,1},
		/*2*/			{1,1,1},
		/*3*/			{1,1,1},
		/*4*/			{1,1,1},
		/*5*/			{1,1,1},
		/*6*/			{1,1,1},
		/*7*/			{1,1,1},
		/*8*/			{1,1,1},
		/*9*/			{1,1,1},
		/*10*/			{1,1,1},
		/*11*/			{1,1,1},
		/*12*/			{1,1,1},
		/*13*/			{1,1,1},
		/*14*/			{1,1,1},
		/*15*/			{1,1,1},
		/*16*/			{1,1,1},
		/*17*/			{1,1,1},
		/*18*/			{1,1,1},
		/*19*/			{1,1,1},
		/*20*/			{1,1,1},
		/*21*/			{1,1,1},
	};
	
	
		Dictionary<int, int[,]> zoeyBaseTableMap = new Dictionary<int, int[,]>();
	zoeyBaseTableMap.Add (1, zoeyBaseTableA);
	zoeyBaseTableMap.Add (2, zoeyBaseTableB);
	
	zoeyBasement = new Interactable("zoeyBase", zoeyBaseDialogMap, zoeyBaseTableMap);
	
}

}



