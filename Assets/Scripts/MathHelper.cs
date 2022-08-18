using UnityEngine;

public static class MathHelper
{
    public static float Lerp(float value1, float value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        return value1 + (value2 - value1) * n;
    }

    public static double Lerp(double value1, double value2, float amount)
    {
        var n = (double)Mathf.Clamp01(amount);
        return value1 + (value2 - value1) * n;
    }

    public static decimal Lerp(decimal value1, decimal value2, float amount)
    {
        var n = (decimal)Mathf.Clamp01(amount);
        return value1 + (value2 - value1) * n;
    }

    public static Vector2 Lerp(Vector2 value1, Vector2 value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        return value1 + (value2 - value1) * n;
    }

    public static Vector3 Lerp(Vector3 value1, Vector3 value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        return value1 + (value2 - value1) * n;
    }

    public static Vector4 Lerp(Vector4 value1, Vector4 value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        return value1 + (value2 - value1) * n;
    }

    public static float LerpAccel(float value1, float value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        var t = n * n;
        return value2 * t + value1 * (1f - t);
    }

    public static double LerpAccel(double value1, double value2, float amount)
    {
        var n = (double)Mathf.Clamp01(amount);
        var t = n * n;
        return value2 * t + value1 * (1d - t);
    }

    public static decimal LerpAccel(decimal value1, decimal value2, float amount)
    {
        var n = (decimal)Mathf.Clamp01(amount);
        var t = n * n;
        return value2 * t + value1 * (1m - t);
    }

    public static Vector2 LerpAccel(Vector2 value1, Vector2 value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        var t = n * n;
        return value2 * t + value1 * (1f - t);
    }

    public static Vector3 LerpAccel(Vector3 value1, Vector3 value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        var t = n * n;
        return value2 * t + value1 * (1f - t);
    }

    public static Vector4 LerpAccel(Vector4 value1, Vector4 value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        var t = n * n;
        return value2 * t + value1 * (1f - t);
    }

    public static float LerpDecel(float value1, float value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        var t = 1f - (1f - n) * (1f - n);
        return value2 * t + value1 * (1f - t);
    }

    public static double LerpDecel(double value1, double value2, float amount)
    {
        var n = (double)Mathf.Clamp01(amount);
        var t = 1d - (1d - n) * (1d - n);
        return value2 * t + value1 * (1d - t);
    }

    public static decimal LerpDecel(decimal value1, decimal value2, float amount)
    {
        var n = (decimal)Mathf.Clamp01(amount);
        var t = 1m - (1m - n) * (1m - n);
        return value2 * t + value1 * (1m - t);
    }

    public static Vector2 LerpDecel(Vector2 value1, Vector2 value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        var t = 1f - (1f - n) * (1f - n);
        return value2 * t + value1 * (1f - t);
    }

    public static Vector3 LerpDecel(Vector3 value1, Vector3 value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        var t = 1f - (1f - n) * (1f - n);
        return value2 * t + value1 * (1f - t);
    }

    public static Vector4 LerpDecel(Vector4 value1, Vector4 value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        var t = 1f - (1f - n) * (1f - n);
        return value2 * t + value1 * (1f - t);
    }

    public static float SmoothStep(float value1, float value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        var t = n * n * (3f - 2f * n);
        return value2 * t + value1 * (1f - t);
    }

    public static double SmoothStep(double value1, double value2, float amount)
    {
        var n = (double)Mathf.Clamp01(amount);
        var t = n * n * (3d - 2d * n);
        return value2 * t + value1 * (1d - t);
    }

    public static decimal SmoothStep(decimal value1, decimal value2, float amount)
    {
        var n = (decimal)Mathf.Clamp01(amount);
        var t = n * n * (3m - 2m * n);
        return value2 * t + value1 * (1m - t);
    }

    public static Vector2 SmoothStep(Vector2 value1, Vector2 value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        var t = n * n * (3f - 2f * n);
        return value2 * t + value1 * (1f - t);
    }

    public static Vector3 SmoothStep(Vector3 value1, Vector3 value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        var t = n * n * (3f - 2f * n);
        return value2 * t + value1 * (1f - t);
    }

    public static Vector4 SmoothStep(Vector4 value1, Vector4 value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        var t = n * n * (3f - 2f * n);
        return value2 * t + value1 * (1f - t);
    }

    public static float SmootherStep(float value1, float value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        var t = n * n * n * (n * (n * 6f - 15f) + 10f);
        return value2 * t + value1 * (1f - t);
    }

    public static double SmootherStep(double value1, double value2, float amount)
    {
        var n = (double)Mathf.Clamp01(amount);
        var t = n * n * n * (n * (n * 6d - 15d) + 10d);
        return value2 * t + value1 * (1d - t);
    }

    public static decimal SmootherStep(decimal value1, decimal value2, float amount)
    {
        var n = (decimal)Mathf.Clamp01(amount);
        var t = n * n * n * (n * (n * 6m - 15m) + 10m);
        return value2 * t + value1 * (1m - t);
    }

    public static Vector2 SmootherStep(Vector2 value1, Vector2 value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        var t = n * n * n * (n * (n * 6f - 15f) + 10f);
        return value2 * t + value1 * (1f - t);
    }

    public static Vector3 SmootherStep(Vector3 value1, Vector3 value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        var t = n * n * n * (n * (n * 6f - 15f) + 10f);
        return value2 * t + value1 * (1f - t);
    }

    public static Vector4 SmootherStep(Vector4 value1, Vector4 value2, float amount)
    {
        var n = Mathf.Clamp01(amount);
        var t = n * n * n * (n * (n * 6f - 15f) + 10f);
        return value2 * t + value1 * (1f - t);
    }

    public static int GreatestCommonDenominator(int p, int q)
    {
        while (true)
        {
            if (q == 0)
            {
                return p;
            }
    
            var r = p % q;
    
            p = q;
            q = r;
        }
    }
    
    public static int Wrap(int i, int min, int max)
    {
        i = (i - min) % (max - min);
        return i < 0 ? max + i : min + i;
    }
}
