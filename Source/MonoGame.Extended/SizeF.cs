using System;
using Microsoft.Xna.Framework;

namespace MonoGame.Extended
{
    public struct SizeF : IEquatable<SizeF>
    {
        public SizeF(float width, float height)
            : this()
        {
            Width = width;
            Height = height;
        }

        public float Width { get; }
        public float Height { get; }
        public static Size Empty => new Size(0, 0);
        public static Size MaxValue => new Size(int.MaxValue, int.MaxValue);
        public bool IsEmpty => Width.Equals(0) && Height.Equals(0);

        public override int GetHashCode()
        {
            unchecked
            {
                return Width.GetHashCode() + Height.GetHashCode();
            }
        }
        
        public static bool operator ==(SizeF a, SizeF b)
        {
            return a.Width.Equals(b.Width) && a.Height.Equals(b.Height);
        }

        public static bool operator !=(SizeF a, SizeF b)
        {
            return !(a == b);
        }

        public bool Equals(SizeF other)
        {
            return Width.Equals(other.Width) && Height.Equals(other.Height);
        }

        public static implicit operator SizeF(Point size)
        {
            return new SizeF(size.X, size.Y);
        }


        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Size && Equals((Size)obj);
        }

        public override string ToString()
        {
            return $"Width: {Width}, Height: {Height}";
        }
    }
}