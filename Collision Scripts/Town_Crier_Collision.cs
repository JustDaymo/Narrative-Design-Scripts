using UnityEngine;
using Fungus;

public class Town_Crier_Collision : MonoBehaviour
{
    public Flowchart flowchart;

    private void OnCollisionEnter()
    {
        flowchart.ExecuteBlock("Meeting Town Crier");
    }
}