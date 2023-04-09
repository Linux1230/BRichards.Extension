using System.Numerics;

namespace BRichards.Extension.Numerics;

/// <summary>
/// 
/// </summary>
public struct Vector3d : IComparable<Vector3d>, IEquatable<Vector3d>
{
    /// <summary>
    /// 
    /// </summary>
    public double X { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public double Y { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public double Z { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="f"></param>
    public Vector3d(double f) => X = Y = Z = f;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    public Vector3d(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="v2"></param>
    public Vector3d(double[] v2)
    {
        X = v2[0];
        Y = v2[1];
        Z = v2[2];
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="copy"></param>
    public Vector3d(Vector3d copy)
    {
        X = copy.X;
        Y = copy.Y;
        Z = copy.Z;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="copy"></param>
    public Vector3d(Vector3 copy)
    {
        X = copy.X;
        Y = copy.Y;
        Z = copy.Z;
    }

<<<<<<< Updated upstream:BRichards.Helper/BRichards.Extension.Numerics/Vector3d.cs
=======
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
>>>>>>> Stashed changes:BRichards.Helper/BRichards.Helper.Numerics/Vector3d.cs
    public Vector3 ToVector3() =>
        new((float)X, (float)Y, (float)Z);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="copy"></param>
    public void FromVector3(Vector3 copy)
    {
        X = copy.X;
        Y = copy.Y;
        Z = copy.Z;
    }

    /// <summary>
    /// 
    /// </summary>
    public static readonly Vector3d Zero = new(0.0f, 0.0f, 0.0f);
    /// <summary>
    /// 
    /// </summary>
    public static readonly Vector3d One = new(1.0f, 1.0f, 1.0f);
    /// <summary>
    /// 
    /// </summary>
    public static readonly Vector3d AxisX = new(1.0f, 0.0f, 0.0f);
    /// <summary>
    /// 
    /// </summary>
    public static readonly Vector3d AxisY = new(0.0f, 1.0f, 0.0f);
    /// <summary>
    /// 
    /// </summary>
    public static readonly Vector3d AxisZ = new(0.0f, 0.0f, 1.0f);
    /// <summary>
    /// 
    /// </summary>
    public static readonly Vector3d MaxValue = new(double.MaxValue, double.MaxValue, double.MaxValue);
    /// <summary>
    /// 
    /// </summary>
    public static readonly Vector3d MinValue = new(double.MinValue, double.MinValue, double.MinValue);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public double this[int key]
    {
        get => key switch
        {
            0 => X,
            1 => Y,
            _ => Z
        };
        set
        {
            switch (key)
            {
                case 0:
                    X = value;
                    break;
                case 1:
                    Y = value;
                    break;
                default:
                    Z = value;
                    break;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="o"></param>
    public void Set(Vector3d o)
    {
        X = o.X;
        Y = o.Y;
        Z = o.Z;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="fX"></param>
    /// <param name="fY"></param>
    /// <param name="fZ"></param>
    public void Set(double fX, double fY, double fZ)
    {
        X = fX;
        Y = fY;
        Z = fZ;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="o"></param>
    public void Add(Vector3d o)
    {
        X += o.X;
        Y += o.Y;
        Z += o.Z;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="o"></param>
    public void Subtract(Vector3d o)
    {
        X -= o.X;
        Y -= o.Y;
        Z -= o.Z;
    }

<<<<<<< Updated upstream:BRichards.Helper/BRichards.Extension.Numerics/Vector3d.cs
    public static Vector3d operator -(Vector3d v) =>
        new(-v.X, -v.Y, -v.Z);

    public static Vector3d operator *(double f, Vector3d v) =>
        new(f * v.X, f * v.Y, f * v.Z);

    public static Vector3d operator *(Vector3d v, double f) =>
        new(f * v.X, f * v.Y, f * v.Z);

    public static Vector3d operator /(Vector3d v, double f) =>
        new(v.X / f, v.Y / f, v.Z / f);

    public static Vector3d operator /(double f, Vector3d v) =>
        new(f / v.X, f / v.Y, f / v.Z);

    public static Vector3d operator *(Vector3d a, Vector3d b) =>
        new(a.X * b.X, a.Y * b.Y, a.Z * b.Z);

    public static Vector3d operator /(Vector3d a, Vector3d b) =>
        new(a.X / b.X, a.Y / b.Y, a.Z / b.Z);

    public static Vector3d operator +(Vector3d v0, Vector3d v1) =>
        new(v0.X + v1.X, v0.Y + v1.Y, v0.Z + v1.Z);

    public static Vector3d operator +(Vector3d v0, double f) =>
        new(v0.X + f, v0.Y + f, v0.Z + f);

    public static Vector3d operator -(Vector3d v0, Vector3d v1) =>
        new(v0.X - v1.X, v0.Y - v1.Y, v0.Z - v1.Z);

    public static Vector3d operator -(Vector3d v0, double f) =>
        new(v0.X - f, v0.Y - f, v0.Z - f);

    public static bool operator ==(Vector3d a, Vector3d b) =>
        a.X == b.X && a.Y == b.Y && a.Z == b.Z;

    public static bool operator !=(Vector3d a, Vector3d b) =>
        a.X != b.X || a.Y != b.Y || a.Z != b.Z;

    public override bool Equals(object? obj) =>
        this == (Vector3d?)obj;

=======
    /// <summary>
    /// 
    /// </summary>
    /// <param name="v"></param>
    /// <returns></returns>
    public static Vector3d operator -(Vector3d v) =>
        new(-v.X, -v.Y, -v.Z);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="f"></param>
    /// <param name="v"></param>
    /// <returns></returns>
    public static Vector3d operator *(double f, Vector3d v) =>
        new(f * v.X, f * v.Y, f * v.Z);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="v"></param>
    /// <param name="f"></param>
    /// <returns></returns>
    public static Vector3d operator *(Vector3d v, double f) =>
        new(f * v.X, f * v.Y, f * v.Z);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="v"></param>
    /// <param name="f"></param>
    /// <returns></returns>
    public static Vector3d operator /(Vector3d v, double f) =>
        new(v.X / f, v.Y / f, v.Z / f);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="f"></param>
    /// <param name="v"></param>
    /// <returns></returns>
    public static Vector3d operator /(double f, Vector3d v) =>
        new(f / v.X, f / v.Y, f / v.Z);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Vector3d operator *(Vector3d a, Vector3d b) =>
        new(a.X * b.X, a.Y * b.Y, a.Z * b.Z);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Vector3d operator /(Vector3d a, Vector3d b) =>
        new(a.X / b.X, a.Y / b.Y, a.Z / b.Z);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="v0"></param>
    /// <param name="v1"></param>
    /// <returns></returns>
    public static Vector3d operator +(Vector3d v0, Vector3d v1) =>
        new(v0.X + v1.X, v0.Y + v1.Y, v0.Z + v1.Z);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="v0"></param>
    /// <param name="f"></param>
    /// <returns></returns>
    public static Vector3d operator +(Vector3d v0, double f) =>
        new(v0.X + f, v0.Y + f, v0.Z + f);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="v0"></param>
    /// <param name="v1"></param>
    /// <returns></returns>
    public static Vector3d operator -(Vector3d v0, Vector3d v1) =>
        new(v0.X - v1.X, v0.Y - v1.Y, v0.Z - v1.Z);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="v0"></param>
    /// <param name="f"></param>
    /// <returns></returns>
    public static Vector3d operator -(Vector3d v0, double f) =>
        new(v0.X - f, v0.Y - f, v0.Z - f);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static bool operator ==(Vector3d a, Vector3d b) =>
        a.X == b.X && a.Y == b.Y && a.Z == b.Z;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static bool operator !=(Vector3d a, Vector3d b) =>
        a.X != b.X || a.Y != b.Y || a.Z != b.Z;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj) =>
        this == (Vector3d?)obj;

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
>>>>>>> Stashed changes:BRichards.Helper/BRichards.Helper.Numerics/Vector3d.cs
    public override int GetHashCode() =>
        HashCode.Combine(X, Y, Z);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public int CompareTo(Vector3d other)
    {
        if (X != other.X)
            return X < other.X ? -1 : 1;
        else if (Y != other.Y)
            return Y < other.Y ? -1 : 1;
        else if (Z != other.Z)
            return Z < other.Z ? -1 : 1;
        return 0;
    }

<<<<<<< Updated upstream:BRichards.Helper/BRichards.Extension.Numerics/Vector3d.cs
=======
    /// <summary>
    /// 
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
>>>>>>> Stashed changes:BRichards.Helper/BRichards.Helper.Numerics/Vector3d.cs
    public bool Equals(Vector3d other) =>
        X == other.X && Y == other.Y && Z == other.Z;

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString() =>
        $"{X:F8} {Y:F8} {Z:F8}";

    /// <summary>
    /// 
    /// </summary>
    /// <param name="fmt"></param>
    /// <returns></returns>
    public string ToString(string fmt) =>
        $"{X.ToString(fmt)} {Y.ToString(fmt)} {Z.ToString(fmt)}";
}
