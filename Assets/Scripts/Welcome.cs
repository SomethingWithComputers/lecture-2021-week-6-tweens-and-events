using UnityEngine;

public class Welcome : MonoBehaviour
{
    private void Start()
    {
        float duration = 1.28f;
        
        RectTransform rectTransform = GetComponent<RectTransform>();
        // Start scaling up and down
        LeanTween.scale(rectTransform, Vector3.one * 2.0f, duration * 2 ).setLoopCount(-1).setLoopPingPong().setEaseInOutElastic();
        
        // Rotate upside down and back
        LeanTween.rotateZ(gameObject, 180.0f, duration).setLoopCount(-1).setLoopPingPong().setEaseInOutCubic();

    }
}
