using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionPrompt : MonoBehaviour
{
    [SerializeField] List<string> _interactionList;
    [SerializeField] GameObject _textPrefab;
    [SerializeField] GameObject _promptWindow;

    public void openPrompt()
    {
        _promptWindow.SetActive(true);
    }
    public void closePrompt()
    {   
        _promptWindow.SetActive(false);
    }
    public void initValues(List<string> list) {
        _interactionList.Clear();
        foreach(string element in list){
            _interactionList.Add(element);
        }
    }
    

    public void InstantiatePrefab(){
        for (int i = 0; i < _interactionList.Count; i++) {
            Instantiate(_textPrefab);
        }
    }
}
