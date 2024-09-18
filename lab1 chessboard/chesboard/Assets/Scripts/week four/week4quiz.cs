using UnityEngine;

public class MeshTransformer : MonoBehaviour
{
    public Mesh exampleMesh;

    void Start()
    {

        Matrix4x4 translationMatrix = Matrix4x4.Translate(new Vector3(2, 2, 2));


        Matrix4x4 rotationMatrix = Matrix4x4.Rotate(Quaternion.Euler(90, 0, 0));


        Matrix4x4 transformationMatrix = translationMatrix * rotationMatrix;

        Vector3[] vertices = exampleMesh.vertices;


        for (int i = 0; i < vertices.Length; i++)
        {
            vertices[i] = transformationMatrix.MultiplyPoint3x4(vertices[i]);
        }

        exampleMesh.vertices = vertices;


    }
}
