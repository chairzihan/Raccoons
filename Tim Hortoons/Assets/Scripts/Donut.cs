using UnityEngine;

public class Donut : MonoBehaviour
{
    public string flavour = "";

    [SerializeField] private GameObject vanillaDonut;
    [SerializeField] private GameObject chocolateDonut;
    [SerializeField] private GameObject strawberryDonut;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (vanillaDonut != null) vanillaDonut.SetActive(false);
        if (chocolateDonut != null) chocolateDonut.SetActive(false);
        if (strawberryDonut != null) strawberryDonut.SetActive(false);

        // Debug to confirm assignment
        Debug.Log($"vanillaDonut: {vanillaDonut?.name}");
        Debug.Log($"chocolateDonut: {chocolateDonut?.name}");
        Debug.Log($"strawberryDonut: {strawberryDonut?.name}");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddVanillaDonut()
    {
        if (flavour == "")
        {
            flavour = "vanilla";
            Debug.Log("added vanilla donut");

            if (vanillaDonut != null) vanillaDonut.SetActive(true);
            if (chocolateDonut != null) chocolateDonut.SetActive(false);
            if (strawberryDonut != null) strawberryDonut.SetActive(false);
        }
        else
        {
            Debug.Log("can't add vanilla, donut already selected");
        }
    }

    public void AddChocolateDonut()
    {
        if (flavour == "")
        {
            flavour = "chocolate";
            Debug.Log("added chocolate donut");

            if (vanillaDonut != null) vanillaDonut.SetActive(false);
            if (chocolateDonut != null) chocolateDonut.SetActive(true);
            if (strawberryDonut != null) strawberryDonut.SetActive(false);
        }
        else
        {
            Debug.Log("can't add chocolate, donut already selected");
        }
    }

    public void AddStrawberryDonut()
    {
        if (flavour == "")
        {
            flavour = "strawberry";
            Debug.Log("added strawberry donut");

            if (vanillaDonut != null) vanillaDonut.SetActive(false);
            if (chocolateDonut != null) chocolateDonut.SetActive(false);
            if (strawberryDonut != null) strawberryDonut.SetActive(true);
        }
        else
        {
            Debug.Log("can't add strawberry, donut already selected");
        }
    }

    public void ClearDonut()
    {
        flavour = "";
        Debug.Log("cleared donut");

        if (vanillaDonut != null) vanillaDonut.SetActive(false);
        if (chocolateDonut != null) chocolateDonut.SetActive(false);
        if (strawberryDonut != null) strawberryDonut.SetActive(false);
    }
}
