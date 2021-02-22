using UnityEngine;

public class HealthBarPos : MonoBehaviour
{
    public Transform healthBar;
    public Transform objectPos;

    // Update is called once per frame
    void Update()
    {
        Vector3 defaultPos = objectPos.localPosition + (Vector3.up * 1f);
        healthBar.SetPositionAndRotation(defaultPos, Quaternion.identity); 
    }
}
