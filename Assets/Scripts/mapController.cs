using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapController : MonoBehaviour
{

    [SerializeField] List<GameObject> listPrefabsShip;
    [SerializeField] GameObject map;

    // Start is called before the first frame update
    void Start()
    {
        GameObject ship;

        System.Random rnd = new System.Random();

        int alea = rnd.Next(2);

        ship = listPrefabsShip[alea];

        Instantiate(ship, map.transform);

        //ship.transform.SetParent(map.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
