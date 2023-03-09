using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Enemigo : MonoBehaviour
{

    [SerializeField]
    private float _speed=3;

    [SerializeField]
    private float _tiempoDeAutodestruccion=3.5f;

    private GUIManager _gui;

    // Start is called before the first frame update
    void Start()
    {
        //ESTO VA A CAMBIAR
        GameObject guiGO= GameObject.Find("GUIManager");
        Assert.IsNotNull(guiGO,"No hay GUIManager");
        _gui= guiGO.GetComponent<GUIManager>();
        Assert.IsNotNull(_gui,"GUIManager no tiene componente");
        
        Destroy(gameObject, _tiempoDeAutodestruccion);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -_speed*Time.deltaTime,0);        
    }

    void OnTriggerEnter(Collider c){
        print("Collider Enter"+c.transform.name);
        _gui.contador++;
        Destroy(gameObject,0);
    }
}
