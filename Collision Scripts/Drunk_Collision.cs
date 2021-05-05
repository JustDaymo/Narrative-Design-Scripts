using UnityEngine;
using Fungus;

public class Drunk_Collision : MonoBehaviour
{
    public Flowchart flowchart;

    private void OnCollisionEnter()
    {
        flowchart.ExecuteBlock("Mean Drunk");
    }
}