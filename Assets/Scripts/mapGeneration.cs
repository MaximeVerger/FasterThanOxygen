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

    // Start is called before the first frame update
    void Start()
    {
        System.Random rnd = new System.Random();

        ListRooms = GameObject.FindGameObjectsWithTag("Room");
        List<string> ListAvailableRooms = new List<string> { "Salle de contrôle", "Salle des machines", "Cuisine", "Dortoir", "Capsule de secours" };

        foreach (GameObject Room in ListRooms)
        {
            int alea = rnd.Next(ListAvailableRooms.Count);
            string roomName = Room.transform.GetChild(0).GetComponent<TMP_Text>().text;
            if (ListTypeOfRooms.Contains(roomName))
            {
                //print(roomName);
                //print(ListAvailableRooms);
                Room.transform.GetChild(0).GetComponent<TMP_Text>().text = ListAvailableRooms[alea];
                ListAvailableRooms.RemoveAt(alea);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
