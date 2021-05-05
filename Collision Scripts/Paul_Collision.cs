using UnityEngine;
using Fungus;

public class Paul_Collision : MonoBehaviour
{
    public Flowchart flowchart;

    private void OnCollisionEnter()
    {
        flowchart.ExecuteBlock("Meeting Paul");
    }
}