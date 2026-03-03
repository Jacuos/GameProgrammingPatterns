using UnityEditor;
using UnityEngine;

namespace DirtyFlag
{
    [CustomEditor(typeof(WorldGraph))] //The script which you want to button to appear in
    public class CustomInspectorScript : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector(); //This goes first

            WorldGraph scriptReference = (WorldGraph)target; //The target script
            if (GUILayout.Button("Move")) // If the button is clicked
            {
                scriptReference.Move(); //Execute the function in the target script
            }
        }
    }
}