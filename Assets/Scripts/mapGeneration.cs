using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Linq;

public class mapGeneration : MonoBehaviour
{
    [SerializeField] GameObject[] ListRooms;
    [SerializeField] GameObject Map;

    List<string> ListTypeOfRooms = new List<string> {"Salle de contrôle", "Salle des machines", "Cuisine", "Dortoir", "Capsule de secours"};
    List<int> ListTypeIdOfRooms = new List<int> { 2, 3, 4, 5, 6 };
    //call getName


    // Start is called before the first frame update
    void Start()
    {
        System.Random rnd = new System.Random();

        ListRooms = GameObject.FindGameObjectsWithTag("Room");
        List<string> ListAvailableRooms = new List<string> { "Salle de contrôle", "Salle des machines", "Cuisine", "Dortoir", "Capsule de secours" };

        List<int> ListAvailableTypeId = new List<int> { 2, 3, 4, 5, 6 };

        foreach (GameObject Room in ListRooms)
        {
            /*int alea = rnd.Next(ListAvailableRooms.Count);
            string roomName = Room.transform.GetChild(0).GetComponent<TMP_Text>().text;*/

            int aleaId = rnd.Next(ListAvailableTypeId.Count);
            int typeId = Room.GetComponent<room>().getTypeId();

            /*if (ListTypeOfRooms.Contains(roomName))
            {
                //print(roomName);
                //print(ListAvailableRooms);
                Room.transform.GetChild(0).GetComponent<TMP_Text>().text = ListAvailableRooms[alea];
                ListAvailableRooms.RemoveAt(alea);
            }*/

            if (ListTypeIdOfRooms.Contains(typeId))
            {
                //print(ListAvailableRooms);
                Room.GetComponent<room>().setRoom(ListAvailableTypeId[aleaId]);
                Room.transform.GetChild(0).GetComponent<TMP_Text>().text = Room.GetComponent<room>().getName();

                /*string name = Room.GetComponent<room>().getName();
                print(name);*/

                ListAvailableTypeId.RemoveAt(aleaId);
                //Room.GetComponent<room>().updateRoomParam();
            }

            Room.GetComponent<room>().updateRoomEvents();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
