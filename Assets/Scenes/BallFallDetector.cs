using UnityEngine;

public class BallFallDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("YellowBall(1)"))
        {
            Debug.Log($"🟡 Жёлтый мяч (1) упал вниз!");
        }
        if (other.CompareTag("YellowBall(2)"))
        {
            Debug.Log($"🟡 Жёлтый мяч (2) упал вниз!");
        }
        if (other.CompareTag("YellowBall(3)"))
        {
            Debug.Log($"🟡 Жёлтый мяч (3) упал вниз!");
        }
    }
}