using UnityEditor;
using UnityEngine;

public class CustomEditorWindow : EditorWindow
{
    [MenuItem("Ferramentas/Adicionar GameObject")]
    public static void ShowWindow()
    {
        GameObject novoObjeto = new GameObject("Novo Objeto");
        novoObjeto.transform.position = Vector3.zero;
    }
}
