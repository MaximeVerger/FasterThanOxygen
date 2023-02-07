using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionPrompt : MonoBehaviour
{
    [SerializeField] List<string> _interactionList;
    [SerializeField] GameObject _textPrefab;

    public void initValues(List<string> list) {
        _interactionList.Clear();
        foreach(string element in list){
            _interactionList.Add(element);
        }
    }

    public void InstantiatePrefab(){
        for (int i, i < _interactionList.Count(), i++) {
            
        }
    }
}
