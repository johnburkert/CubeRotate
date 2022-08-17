using System.Collections;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    [Range(0.1f, 10f)]
    public float speed = 1f;
    private const float Rate = 1f / 60f;

    private IEnumerator Start()
    {
        var random = new System.Random();
        
        while (true)
        {
            var rotation = random.Next(6) switch
            {
                5 => Vector3.up,
                4 => Vector3.down,
                3 => Vector3.left,
                2 => Vector3.right,
                1 => Vector3.forward,
                _ => Vector3.back
            };
            
            for (var i = 0; i < 90; i++)
            {
                transform.rotation *= Quaternion.Euler(rotation);
                yield return new WaitForSeconds(Rate / speed);
            }
        }
    }
}
