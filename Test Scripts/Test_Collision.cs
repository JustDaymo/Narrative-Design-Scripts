using UnityEngine;
using Fungus;

public class Test_Collision : MonoBehaviour
{
    public Flowchart flowchart;

    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.collider.tag == "NPC")
        {
            Debug.Log("NPC hit");
            flowchart.ExecuteBlock("Collision");
        }
    }
}
