
// https://github.com/acron0/Easings
// https://github.com/warrenm/AHEasing
// http://robertpenner.com/easing/
// https://easings.net/

using UnityEngine;

public static class PennerEasing
{
	private const float HalfPi = Mathf.PI / 2.0f;
	
	public enum Functions
	{
		LinearInterpolation,
		QuadraticEaseIn,
		QuadraticEaseOut,
		QuadraticEaseInOut,
		CubicEaseIn,
		CubicEaseOut,
		CubicEaseInOut,
		QuarticEaseIn,
		QuarticEaseOut,
		QuarticEaseInOut,
		QuinticEaseIn,
		QuinticEaseOut,
		QuinticEaseInOut,
		SineEaseIn,
		SineEaseOut,
		SineEaseInOut,
		CircularEaseIn,
		CircularEaseOut,
		CircularEaseInOut,
		ExponentialEaseIn,
		ExponentialEaseOut,
		ExponentialEaseInOut,
		ElasticEaseIn,
		ElasticEaseOut,
		ElasticEaseInOut,
		BackEaseIn,
		BackEaseOut,
		BackEaseInOut,
		BounceEaseIn,
		BounceEaseOut,
		BounceEaseInOut
	}

	public static float Interpolate(float p, Functions function)
	{
		switch (function)
		{
			default:
			case Functions.LinearInterpolation: 	return LinearInterpolation(p);
			case Functions.QuadraticEaseOut:		return QuadraticEaseOut(p);
			case Functions.QuadraticEaseIn:			return QuadraticEaseIn(p);
			case Functions.QuadraticEaseInOut:		return QuadraticEaseInOut(p);
			case Functions.CubicEaseIn:				return CubicEaseIn(p);
			case Functions.CubicEaseOut:			return CubicEaseOut(p);
			case Functions.CubicEaseInOut:			return CubicEaseInOut(p);
			case Functions.QuarticEaseIn:			return QuarticEaseIn(p);
			case Functions.QuarticEaseOut:			return QuarticEaseOut(p);
			case Functions.QuarticEaseInOut:		return QuarticEaseInOut(p);
			case Functions.QuinticEaseIn:			return QuinticEaseIn(p);
			case Functions.QuinticEaseOut:			return QuinticEaseOut(p);
			case Functions.QuinticEaseInOut:		return QuinticEaseInOut(p);
			case Functions.SineEaseIn:				return SineEaseIn(p);
			case Functions.SineEaseOut:				return SineEaseOut(p);
			case Functions.SineEaseInOut:			return SineEaseInOut(p);
			case Functions.CircularEaseIn:			return CircularEaseIn(p);
			case Functions.CircularEaseOut:			return CircularEaseOut(p);
			case Functions.CircularEaseInOut:		return CircularEaseInOut(p);
			case Functions.ExponentialEaseIn:		return ExponentialEaseIn(p);
			case Functions.ExponentialEaseOut:		return ExponentialEaseOut(p);
			case Functions.ExponentialEaseInOut:	return ExponentialEaseInOut(p);
			case Functions.ElasticEaseIn:			return ElasticEaseIn(p);
			case Functions.ElasticEaseOut:			return ElasticEaseOut(p);
			case Functions.ElasticEaseInOut:		return ElasticEaseInOut(p);
			case Functions.BackEaseIn:				return BackEaseIn(p);
			case Functions.BackEaseOut:				return BackEaseOut(p);
			case Functions.BackEaseInOut:			return BackEaseInOut(p);
			case Functions.BounceEaseIn:			return BounceEaseIn(p);
			case Functions.BounceEaseOut:			return BounceEaseOut(p);
			case Functions.BounceEaseInOut:			return BounceEaseInOut(p);
		}
	}

	public static float LinearInterpolation(float p)
	{
		return p;
	}
	
	public static float QuadraticEaseIn(float p)
	{
		return p * p;
	}
	
	public static float QuadraticEaseOut(float p)
	{
		return -(p * (p - 2f));
	}
	
	public static float QuadraticEaseInOut(float p)
	{
		if (p < 0.5f)
		{
			return 2f * p * p;
		}

		return -2f * p * p + 4f * p - 1f;
	}
	
	public static float CubicEaseIn(float p)
	{
		return p * p * p;
	}
	
	public static float CubicEaseOut(float p)
	{
		var f = p - 1f;
		return f * f * f + 1f;
	}
	
	public static float CubicEaseInOut(float p)
	{
		if (p < 0.5f)
		{
			return 4f * p * p * p;
		}

		var f = 2f * p - 2f;
		return 0.5f * f * f * f + 1f;
	}
	
	public static float QuarticEaseIn(float p)
	{
		return p * p * p * p;
	}
	
	public static float QuarticEaseOut(float p)
	{
		var f = p - 1f;
		return f * f * f * (1f - p) + 1f;
	}
	
	public static float QuarticEaseInOut(float p)
	{
		if (p < 0.5f)
		{
			return 8f * p * p * p * p;
		}

		var f = p - 1f;
		return -8f * f * f * f * f + 1f;
	}
	
	public static float QuinticEaseIn(float p) 
	{
		return p * p * p * p * p;
	}
	
	public static float QuinticEaseOut(float p) 
	{
		var f = p - 1f;
		return f * f * f * f * f + 1f;
	}
	
	public static float QuinticEaseInOut(float p)
	{
		if (p < 0.5f)
		{
			return 16f * p * p * p * p * p;
		}

		var f = 2f * p - 2f;
		return 0.5f * f * f * f * f * f + 1f;
	}
	
	public static float SineEaseIn(float p)
	{
		return Mathf.Sin((p - 1f) * HalfPi) + 1f;
	}
	
	public static float SineEaseOut(float p)
	{
		return Mathf.Sin(p * HalfPi);
	}
	
	public static float SineEaseInOut(float p)
	{
		return 0.5f * (1f - Mathf.Cos(p * Mathf.PI));
	}
	
	public static float CircularEaseIn(float p)
	{
		return 1f - Mathf.Sqrt(1f - p * p);
	}
	
	public static float CircularEaseOut(float p)
	{
		return Mathf.Sqrt((2f - p) * p);
	}
	
	public static float CircularEaseInOut(float p)
	{
		if (p < 0.5f)
		{
			return 0.5f * (1f - Mathf.Sqrt(1f - 4f * (p * p)));
		}

		return 0.5f * (Mathf.Sqrt(-(2f * p - 3f) * (2f * p - 1f)) + 1f);
	}
	
	public static float ExponentialEaseIn(float p)
	{
		return Mathf.Approximately(p, 0f) ? p : Mathf.Pow(2f, 10f * (p - 1f));
	}
	
	public static float ExponentialEaseOut(float p)
	{
		return Mathf.Approximately(p, 1f) ? p : 1f - Mathf.Pow(2f, -10f * p);
	}
	
	public static float ExponentialEaseInOut(float p)
	{
		if (Mathf.Approximately(p, 0f) || Mathf.Approximately(p, 1f)) return p;
		
		if (p < 0.5f)
		{
			return 0.5f * Mathf.Pow(2f, 20f * p - 10f);
		}

		return -0.5f * Mathf.Pow(2f, -20f * p + 10f) + 1f;
	}
	
	public static float ElasticEaseIn(float p)
	{
		return Mathf.Sin(13f * HalfPi * p) * Mathf.Pow(2f, 10f * (p - 1f));
	}
	
	public static float ElasticEaseOut(float p)
	{
		return Mathf.Sin(-13f * HalfPi * (p + 1f)) * Mathf.Pow(2f, -10f * p) + 1f;
	}
	
	public static float ElasticEaseInOut(float p)
	{
		if (p < 0.5f)
		{
			return 0.5f * Mathf.Sin(13f * HalfPi * (2f * p)) * Mathf.Pow(2f, 10f * (2f * p - 1f));
		}

		return 0.5f * (Mathf.Sin(-13f * HalfPi * (2f * p - 1f + 1f)) * Mathf.Pow(2f, -10f * (2f * p - 1f)) + 2f);
	}
	
	public static float BackEaseIn(float p)
	{
		return p * p * p - p * Mathf.Sin(p * Mathf.PI);
	}
	
	public static float BackEaseOut(float p)
	{
		var f = 1f - p;
		return 1f - (f * f * f - f * Mathf.Sin(f * Mathf.PI));
	}
	
	public static float BackEaseInOut(float p)
	{
		if (p < 0.5f)
		{
			var f = 2f * p;
			return 0.5f * (f * f * f - f * Mathf.Sin(f * Mathf.PI));
		}
		
		{
			var f = 1f - (2f * p - 1f);
			return 0.5f * (1f - (f * f * f - f * Mathf.Sin(f * Mathf.PI))) + 0.5f;
		}
	}
	
	public static float BounceEaseIn(float p)
	{
		return 1f - BounceEaseOut(1f - p);
	}
	
	public static float BounceEaseOut(float p)
	{
		if (p < 4f / 11f)
		{
			return 121f * p * p / 16f;
		}
		
		if (p < 8f / 11f)
		{
			return 363f / 40f * p * p - 99f / 10f * p + 17f / 5f;
		}
		
		if (p < 9f / 10f)
		{
			return 4356f / 361f * p * p - 35442f / 1805f * p + 16061f / 1805f;
		}

		return 54f / 5f * p * p - 513f / 25f * p + 268f / 25f;
	}
	
	public static float BounceEaseInOut(float p)
	{
		if (p < 0.5f)
		{
			return 0.5f * BounceEaseIn(p * 2f);
		}

		return 0.5f * BounceEaseOut(p * 2f - 1f) + 0.5f;
	}
}
