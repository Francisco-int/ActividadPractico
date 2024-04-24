using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntajeManager : MonoBehaviour
{
    public int puntajeAdd;
    public Text puntajeUi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActualizarPuntaje()
    {
        puntajeAdd++;
        puntajeUi.text = "Puntaje: "+ puntajeAdd;
    }
}
