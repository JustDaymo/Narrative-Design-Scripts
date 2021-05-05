using UnityEngine;
using Fungus;

public class Inciting_Incident_Check : MonoBehaviour
{
    public Flowchart flowchart;

    private void OnTriggerEnter()
    {
        flowchart.ExecuteBlock("Inciting Incident");
    }
}