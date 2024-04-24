using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Misiones : MonoBehaviour
{
    public Button misionSeleccionada;

    public Image mision1;
    public Image mision2;
    public Image mision3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MisionSeleccionada(Button misionActual)
    {
        misionSeleccionada = misionActual.GetComponent<Button>();
    }
    public void ActivarMision()
    {
        misionSeleccionada.image.color = Color.blue;
    }
    public void CompletarMision()
    {
        misionSeleccionada.image.color = Color.green;
    }
    public void CancelarMision()
    {
        misionSeleccionada.image.color = Color.red;
    }

}
