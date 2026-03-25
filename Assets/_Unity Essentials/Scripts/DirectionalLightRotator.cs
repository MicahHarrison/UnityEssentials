using UnityEngine;

public class DirectionalLightRotator : MonoBehaviour
{
    [Tooltip("The length of a full day cycle in seconds.")]
    public float dayLengthInSeconds = 24f;

    void Update()
    {
        // Rotate the light around the X-axis to simulate the sun's movement
        transform.Rotate(Vector3.right, 360f / dayLengthInSeconds * Time.deltaTime);
    }
}