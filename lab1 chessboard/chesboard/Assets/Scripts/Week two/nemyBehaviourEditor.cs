using UnityEngine;
using UnityEditor;
using System.Linq;

// Apply the CustomEditor attribute to specify the target component
[CustomEditor(typeof(EnemyBehaviour)), CanEditMultipleObjects]
public class EnemyBehaviourEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // Draw the default inspector UI
        base.OnInspectorGUI();

        // Add a button to the inspector
        if (GUILayout.Button("Select all enemies"))
        {
            // Find all instances of EnemyBehaviour in the scene
            var allEnemyBehaviours = GameObject.FindObjectsOfType<EnemyBehaviour>();

            // Get the GameObjects from the EnemyBehaviour components
            var allEnemyGameObjects = allEnemyBehaviours
                .Select(enemy => enemy.gameObject)
                .ToArray();

            // Set the active selection in the editor to the found GameObjects
            Selection.objects = allEnemyGameObjects;
        }
    }
}

public class EnemyBehaviour : MonoBehaviour
{
    // Your code for EnemyBehaviour here
}