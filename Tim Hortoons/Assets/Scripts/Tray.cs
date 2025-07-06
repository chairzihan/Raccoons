using UnityEngine;

public class Tray : MonoBehaviour
{
    public bool hasDrink = false;
    public bool hasDonut = false;

    [Header("Tray Components")]
    [SerializeField] private Cup trayCup;
    [SerializeField] private Donut trayDonut;
    
    [Header("Visual Feedback")]
    [SerializeField] private SpriteRenderer trayRenderer;
    [SerializeField] private Color emptyTrayColor = Color.white;
    [SerializeField] private Color fullTrayColor = Color.green;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find components if not assigned
        if (trayCup == null) trayCup = GetComponentInChildren<Cup>();
        if (trayDonut == null) trayDonut = GetComponentInChildren<Donut>();
        
        UpdateTrayVisuals();
    }

    // Update is called once per frame
    void Update()
    {
        // Update tray state based on contents
        UpdateTrayState();
        UpdateTrayVisuals();
    }
    
    void UpdateTrayState()
    {
        // Check if tray has drink
        hasDrink = trayCup != null && (trayCup.coffeeAmt > 0 || trayCup.milkAmt > 0);
        
        // Check if tray has donut
        hasDonut = trayDonut != null && !string.IsNullOrEmpty(trayDonut.flavour);
    }
    
    void UpdateTrayVisuals()
    {
        if (trayRenderer != null)
        {
            // Change tray color based on contents
            if (hasDrink || hasDonut)
            {
                trayRenderer.color = fullTrayColor;
            }
            else
            {
                trayRenderer.color = emptyTrayColor;
            }
        }
    }
    
    // Public methods for external access
    public Cup GetCup()
    {
        return trayCup;
    }
    
    public Donut GetDonut()
    {
        return trayDonut;
    }
    
    public bool IsEmpty()
    {
        return !hasDrink && !hasDonut;
    }
    
    public bool HasItems()
    {
        return hasDrink || hasDonut;
    }
    
    public string GetTrayDescription()
    {
        string description = "";
        
        if (hasDrink && trayCup != null)
        {
            description += $"Drink: {trayCup.coffeeAmt} coffee, {trayCup.milkAmt} milk. ";
        }
        
        if (hasDonut && trayDonut != null)
        {
            description += $"Donut: {trayDonut.flavour}.";
        }
        
        return string.IsNullOrEmpty(description) ? "Empty tray" : description;
    }
    
    public void ClearTray()
    {
        if (trayCup != null)
        {
            trayCup.coffeeAmt = 0;
            trayCup.milkAmt = 0;
            trayCup.isFull = false;
        }
        
        if (trayDonut != null)
        {
            trayDonut.flavour = "";
            // Reset donut visuals by calling one of the add methods then clearing
            trayDonut.AddVanillaDonut();
            trayDonut.flavour = "";
        }
        
        hasDrink = false;
        hasDonut = false;
        UpdateTrayVisuals();
    }
}
