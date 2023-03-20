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

        if (aleaNbEvent == 0) return;

        if (typeId == 1)
        {
            
            /*for (int i = 0; i < aleaNbEvent; i++)
            {

            }
            int aleaId = rnd.Next(ListNameOfEvents.Count);*/
            events.Add("Drone");
            events.Add("Panne");
            events.Add("Innondation");
            events.Add("Electricite");
            //objects.Add();
        }
        else if (typeId == 2)
        {
            events.Add("Innondation");
            events.Add("Electricite");
        }
        else if (typeId == 3)
        {
            events.Add("Innondation");
            events.Add("Panne");
        }
        else if (typeId == 4)
        {
            events.Add("Drone");
            events.Add("Panne");
        }
        else if (typeId == 5)
        {
            events.Add("Panne");
        }
        else if (typeId == 6)
        {
            events.Add("Drone");
            events.Add("Panne");
        }
        else
        {
            events.Add("No events");
        }

        /*foreach (var x in param)
        {
            Debug.Log(x.ToString());
        }*/
    }
}
