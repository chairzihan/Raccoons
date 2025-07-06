using UnityEngine;

public class StartButton : MonoBehaviour
{

    public GameObject startMenu;
    public GameObject tutorial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        startMenu.SetActive(false);
        tutorial.SetActive(true);
    }
}
