using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EmploymentBar : MonoBehaviour
{// Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private Slider employmentSlider;

    public int employment = 100;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        employmentSlider.value = employment;

        if (employmentSlider.value <= 0)
        {
            Debug.Log("Employment is at zero. Game Over!");
            SceneManager.LoadScene("EndScene");
        }
    }

    public void addEmployment(int amount)
    {
        if (employmentSlider != null)
        {
            employment += amount;
            Debug.Log($"Employment increased by {amount}. Current value: {employmentSlider.value}");
        }
        else
        {
            Debug.LogWarning("Employment slider is not assigned.");
        }
    }
    
    public void reduceEmployment(int amount)
    {
        if (employmentSlider != null)
        {
            employment -= amount;
            Debug.Log($"Employment decreased by {amount}. Current value: {employmentSlider.value}");
        }
        else
        {
            Debug.LogWarning("Employment slider is not assigned.");
        }
    }
}
