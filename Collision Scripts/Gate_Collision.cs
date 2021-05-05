using UnityEngine;
using Fungus;

public class Gate_Collision : MonoBehaviour
{
    public Flowchart flowchart;

    private void OnCollisionEnter()
    {
        flowchart.ExecuteBlock("Gate Locked");
    }
}
