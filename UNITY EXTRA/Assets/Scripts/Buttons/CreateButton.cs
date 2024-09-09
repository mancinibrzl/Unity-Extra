using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateButton : MonoBehaviour
{
    public GameObject prefab;

    [ContextMenu("Imprimir Mensagem")]
    public void PrintMessage()
    {
        Debug.Log("Botão Clicado!");
    }

    [ContextMenu("Criar Objeto")]
    public void CreateObject()
    {
        if (prefab != null)
        {
            Instantiate(prefab, Vector3.zero, Quaternion.identity);
        }
    }
}
