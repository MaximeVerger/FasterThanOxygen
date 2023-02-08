using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class Controller : MonoBehaviour
{
    [SerializeField] private List<Button> btns;
    [SerializeField] TMP_Text log;
    public GameObject selectedObject;
    Vector3 offset;
    // Start is called before the first frame update
    private void Awake()
    {
        foreach(Button btn in btns)
        {
            // adding a delegate with no parameters
            btn.onClick.AddListener(NoParamaterOnclick);

            // adding a delegate with parameters
            btn.onClick.AddListener(delegate { ParameterOnClick("Button was pressed!"); });
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
            if (targetObject)
            {
                selectedObject = targetObject.transform.gameObject;
                offset = selectedObject.transform.position - mousePosition;
            }
            if (selectedObject)
            {
                selectedObject.transform.position = mousePosition + offset;
            }
            if (Input.GetMouseButtonUp(0) && selectedObject)
            {
                selectedObject = null;
            }
        }
    }

    private void NoParamaterOnclick()
    {
        //log.text += 
        Debug.Log("Fat Cock");
    }

    private void ParameterOnClick(string test)
    {
        Debug.Log(test);
    }
}
