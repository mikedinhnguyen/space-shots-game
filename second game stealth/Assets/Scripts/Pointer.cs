using UnityEngine;

public class Pointer : MonoBehaviour
{
    private Transform targetPos;
    private Transform pointerTransform;

    private void Awake()
    {
        targetPos = transform;
        pointerTransform = transform.Find("Pointer").GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 toPos = targetPos.position;
        Vector3 fromPos = Camera.main.transform.position;
        fromPos.z = 0;
        Vector3 dir = (toPos - fromPos).normalized;

        float angle = (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg) % 360;

        pointerTransform.localEulerAngles = new Vector3(0, 0, angle);

        Vector3 targetPosScreenPoint = Camera.main.WorldToScreenPoint(targetPos.position);
        bool isOffScreen = targetPosScreenPoint.x <= 0 || targetPosScreenPoint.x >= Screen.width || targetPosScreenPoint.y <= 0 || targetPosScreenPoint.y >= Screen.height;
        Debug.Log(isOffScreen + " " + targetPosScreenPoint);
    }
}
