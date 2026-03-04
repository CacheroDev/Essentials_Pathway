using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day Settings")]
    [Tooltip("How many real-time seconds one full in-game day lasts.")]
    public float dayDurationInSeconds = 120f; // Default: 2 minutes per day

    private float rotationSpeed; // Degrees per second

    void Start()
    {
        CalculateRotationSpeed();
    }

    void Update()
    {
        // Rotate around the X axis (like sunrise to sunset)
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }

    void CalculateRotationSpeed()
    {
        if (dayDurationInSeconds <= 0.01f)
        {
            dayDurationInSeconds = 0.01f;
        }

        // 360 degrees per full day
        rotationSpeed = 360f / dayDurationInSeconds;
    }

    // Recalculate automatically if changed in Inspector during play mode
    void OnValidate()
    {
        CalculateRotationSpeed();
    }
}