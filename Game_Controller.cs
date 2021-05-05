using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class Game_Controller : MonoBehaviour
{
    public Flowchart flowchart;

    string theName;

    public GameObject nameInput;
    public GameObject mainCharacter;
    public GameObject playerModel;

    public Transform mageHome;

    void nameAppear()
    {
        nameInput.SetActive(true);
    }

    void nameChange()
    {
        nameInput.SetActive(false);
        theName = nameInput.GetComponent<InputField>().text;
        mainCharacter.GetComponent<Character>().nameText = theName;
        flowchart.SetStringVariable("PlayerName", theName);
        flowchart.ExecuteBlock("Greet Player");
    }

    void moveIncitingIncident()
    {
        Debug.Log("test");
        Vector3 goHere = mageHome.position;
        playerModel.transform.position = goHere;
    }
}