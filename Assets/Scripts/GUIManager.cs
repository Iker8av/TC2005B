using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using TMPro;

public class GUIManager : MonoBehaviour
{

    [SerializeField]
    public TMP_Text _text; 

    // Start is called before the first frame update
    void Start()
    {
        Assert.IsNotNull(_text,"Texto no puede ser nulo");
        _text.text="Hello World";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
