/*
MIT License

Copyright (c) 2016 Juan Antonio Fajardo Serrano

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using UnityEngine;
using UnityEditor;

namespace CopyTransformTool
{
    public sealed class CopyTransformToolWindow : EditorWindow
    {
        private const int WindowWidth = 400;
        private const int WindowHeight = 300;
        private const int MaxNameLabelWidth = 300;
        private const int ElementLabelWidth = 60;

        private Transform SourceTransform;
        private bool CopyPosition = true;
        private bool CopyRotation = true;
        private bool CopyScale = true;
        private bool CopyParent = false;

        private Vector2 ScrollPosition;

        [MenuItem("CopyTransform Tool/Open Tool Window")]
        private static void OpenToolWindow ()
        {
            CopyTransformToolWindow window = EditorWindow.GetWindow<CopyTransformToolWindow>();
            window.minSize = new Vector2(WindowWidth, WindowHeight);
            window.maxSize = new Vector2(WindowWidth, WindowHeight);
            window.autoRepaintOnSceneChange = true;
            window.Show();
        }

        private void OnGUI ()
        {
            EditorGUILayout.BeginVertical();
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Elements to copy:", EditorStyles.boldLabel);
            EditorGUILayout.Space();
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Position", EditorStyles.boldLabel, GUILayout.Width(ElementLabelWidth));
            CopyPosition = EditorGUILayout.Toggle("", CopyPosition);
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Rotation", EditorStyles.boldLabel, GUILayout.Width(ElementLabelWidth));
            CopyRotation = EditorGUILayout.Toggle("", CopyRotation);
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Scale", EditorStyles.boldLabel, GUILayout.Width(ElementLabelWidth));
            CopyScale = EditorGUILayout.Toggle("", CopyScale);
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Parent", EditorStyles.boldLabel, GUILayout.Width(ElementLabelWidth));
            CopyParent = EditorGUILayout.Toggle("", CopyParent);
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.Space();
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Source Transform:", EditorStyles.boldLabel, GUILayout.Width(150));
            SourceTransform = (Transform)EditorGUILayout.ObjectField("", SourceTransform, typeof(Transform),true);
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Name(s) of the selected GameObject(s):", EditorStyles.boldLabel);
            EditorGUILayout.Space();

            ScrollPosition = EditorGUILayout.BeginScrollView(ScrollPosition, false, false, GUILayout.Height(100));

            for (int i = 0; i < Selection.gameObjects.Length; i++)
            {
                string name = Selection.gameObjects[i].name;

                if (name == "")
                {
                    name = "<GameObject without name>";
                }

                EditorGUILayout.LabelField(name, EditorStyles.label, GUILayout.Width(MaxNameLabelWidth));
            }

            EditorGUILayout.EndScrollView();

            if (SourceTransform != null && Selection.gameObjects.Length > 0)
            {
                EditorGUILayout.Space();

                if (GUILayout.Button("Copy elements"))
                {
                    if (EditorUtility.DisplayDialog("Are you sure?", "This action can't be undo. Are you sure you want to do the copy with the selected parameters?", "Yes", "No"))
                    {
                        Copy();
                    }
                }
            }

            EditorGUILayout.EndVertical();
        }

        private void OnInspectorUpdate()
        {
            Repaint();
        }

        private void Copy ()
        {
            for (int i = 0; i < Selection.gameObjects.Length; i++)
            {
                if (CopyPosition)
                {
                    Selection.gameObjects[i].transform.position = SourceTransform.position;
                }

                if (CopyRotation)
                {
                    Selection.gameObjects[i].transform.rotation = Quaternion.Euler(SourceTransform.rotation.eulerAngles);
                }

                if (CopyScale)
                {
                    Selection.gameObjects[i].transform.localScale = SourceTransform.localScale;
                }

                if (CopyParent)
                {
                    Selection.gameObjects[i].transform.SetParent(SourceTransform.parent);
                }
            }
        }
    }
}
