using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helado : MonoBehaviour
{
    //    Heladería "Los tres gustos"

    //Esta heladería ofrece 3 gustos: chocolate, frutilla y dulce de leche y toma pedidos mediante códigos.El cliente debe pedir los gustos ingresando CHO, FRU y DDL.Además debe ingresar una cantidad de helado en gramos (250 para un cuarto, 500 para medio k, etc). Esta semana tiene una promoción con frutilla, por lo que el precio se reduce un %10 solo en ese gusto.


    //.Mostrar un mensaje de error y ningún otro mensaje ni realizar ningún cálculo si no se ingresa un código válido o si las cantidades de helado son menores a 250 o mayores que 3000. 

    //. Sabiendo que el kilo de helado sale $500, devolver el costo del pedido si los ingresos son válidos. Recuerdo contemplar la promoción.
    public string gusto;
    public int peso;
    float precio;
    float descuento;

  void Start()
    {
        if (gusto == "FRU")
        {
            if (peso > 250)
            {
                if (peso < 3000)
                {
                    precio = peso * 0.5f;
                    descuento = precio / 10;
                    Debug.Log(precio - descuento);
                }
                else
                {
                    Debug.Log("el peso no es valido");
                }
            }
            else
            {
                Debug.Log("el peso no es valido");
            }
        }
        else if (gusto == "CHO")
        {
            if (peso > 250)
            {
                if (peso < 3000)
                {
                    precio = peso * 0.5f;

                    Debug.Log(precio);
                }
                else
                {
                    Debug.Log("el peso no es valido");
                }
            }
            else
            {
                Debug.Log("el peso no es valido");
            }
        }
        else if (gusto== "DDl")
        {
            if (peso > 250)
            {
                if (peso < 3000)
                {
                    precio = peso * 0.5f;

                    Debug.Log(precio);
                }
                else
                {
                    Debug.Log("el peso no es valido");
                }
            }
            else
            {
                Debug.Log("no es un peso valido");
            }
        }
        else
        {
            

            Debug.Log("el gusto no es valido");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
