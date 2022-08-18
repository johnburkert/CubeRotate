using System.Collections;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public PennerEasing.Functions easing;
    [Range(0.1f, 10f)]
    public float speed = 1f;

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
            } * 90f;

            yield return RotateTo(rotation, 1f / speed);
        }
    }

    private IEnumerator RotateTo(Vector3 rotation, float time)
    {
        var elapsed = 0f;
        var origin = transform.rotation;
        
        while (elapsed < time)
        {
            transform.rotation =
                origin * Quaternion.Euler(MathHelper.Lerp(Vector3.zero, rotation, PennerEasing.Interpolate(elapsed / time, easing)));

            yield return null;
            
            elapsed += Time.deltaTime;
        }
        
        transform.rotation = origin * Quaternion.Euler(rotation);
    }
}
