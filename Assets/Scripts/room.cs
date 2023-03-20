using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room : MonoBehaviour
{

    [SerializeField] int id;
    [SerializeField] string name;
    [SerializeField] int typeId;
    [SerializeField] Dictionary<int, string> roomType = new Dictionary<int, string>(){
        {0, "Salle de depart"},
        {1, "Salle commune"},
        {2, "Salle de controle"},
        {3, "Salle des machines"},
        {4, "Cuisine"},
        {5, "Dortoir"},
        {6, "Capsule de secours"},
    };
    [SerializeField]
    Dictionary<int, string> objectType = new Dictionary<int, string>(){
        {0, "Panneau electrique"},
        {1, "Pompe"},
        {2, "Ordinateur"},
    };
    [SerializeField] List<string> events;
    [SerializeField] List<string> objects;

    List<string> ListNameOfRooms = new List<string> { "Salle de départ", "Salle commune", "Salle de contrôle", "Salle des machines", "Cuisine", "Dortoir", "Capsule de secours" };
    List<string> ListNameOfEvents = new List<string> { "Drone", "Panne", "Innondation", "Electricite" };
    List<string> ListNameOfObjects = new List<string> { "Panneau électrique", "Pompe", "Ordinateur" };

    // Start is called before the first frame update
    void Start()
    {
        name = ListNameOfRooms[typeId];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int getTypeId()
    {
        return typeId;
    }

    public string getName()
    {
        return name;
    }

    public void setRoom(int p_typeId)
    {
        this.typeId = p_typeId;
        this.name = ListNameOfRooms[typeId];
    }

    public void updateRoomEvents()
    {
        System.Random rnd = new System.Random();
        int aleaNbEvent = rnd.Next(3);

        if (typeId == 1)
        {
            List<string> tempListEvents = new List<string> { "Drone", "Panne", "Innondation", "Electricite" };
            for (int i = 0; i < aleaNbEvent; i++)
            {
                int aleaEvent = rnd.Next(tempListEvents.Count);
                events.Add(tempListEvents[aleaEvent]);
                tempListEvents.RemoveAt(aleaEvent);
            }

            int aleaObject = rnd.Next(ListNameOfObjects.Count);
            objects.Add(ListNameOfObjects[aleaObject]);
        }
        else if (typeId == 2)
        {
            int aleaEvent = rnd.Next(0, 2);
            events.Add(ListNameOfEvents[aleaEvent]);

            objects.Add(ListNameOfObjects[2]);
        }
        else if (typeId == 3)
        {
            int aleaEvent = rnd.Next(0, 2);
            events.Add(ListNameOfEvents[aleaEvent]);

            objects.Add(ListNameOfObjects[1]);
        }
        else if (typeId == 4)
        {
            int aleaEvent = rnd.Next(2, 4);
            events.Add(ListNameOfEvents[aleaEvent]);

            objects.Add(ListNameOfObjects[0]);
        }
        else if (typeId == 5)
        {
            int aleaEvent = rnd.Next(2, 4);
            events.Add(ListNameOfEvents[aleaEvent]);

            objects.Add(ListNameOfObjects[0]);
        }
        else if (typeId == 6)
        {
            events.Add("No events");
        }
        else
        {
            events.Add("No events");
        }
    }
}
