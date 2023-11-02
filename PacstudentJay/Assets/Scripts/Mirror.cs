using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Tilemaps;

[CustomEditor(typeof(Tilemap))]
public class MirrorTilemapEditor : Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        Tilemap tilemap = (Tilemap)target;

        // Draw the default inspector fields
        DrawDefaultInspector();

        // Mirror tilemap along its local X-axis
        if (GUILayout.Button("Mirror X"))
        {
            tilemap.transform.localScale = new Vector3(-tilemap.transform.localScale.x, tilemap.transform.localScale.y, tilemap.transform.localScale.z);
        }

        serializedObject.ApplyModifiedProperties();
    }
}
