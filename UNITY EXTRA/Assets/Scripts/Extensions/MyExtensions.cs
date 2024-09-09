using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class MyExtensions
{
   // Método de extensão para randomizar uma lista
   public static void RandomList<T>(this List<T> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            T temp = lista[i];
            int randomIndex = Random.Range(i, lista.Count);
            lista[i] = lista[randomIndex];
            lista[randomIndex] = temp;
        }
    }
}
