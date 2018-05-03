using System;
using System.Collections.Generic;
using System.Text;

namespace IDictionary
{
    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return String.Format("({0},{1},{2})", 
                this.X, this.Y, this.Z);
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;

            Point3D other = obj as Point3D;

            if (other == null)
                return false;

            if (!this.X.Equals(other.X))
            {
                return false;
            }

            if (!this.Y.Equals(other.Y))
            {
                return false;
            }

            if (!this.Z.Equals(other.Z))
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            int prime = 83;
            int result = 1;
            unchecked
            {
                result = result * prime + X.GetHashCode();
                result = result * prime + Y.GetHashCode();
                result = result + prime + Z.GetHashCode();
            }
            return result;
        }
       
    }

    public class Point3DEqualityComparer : IEqualityComparer<Point3D>
    {
        public bool Equals(Point3D point1, Point3D point2)
        {
            if (point1 == point2)
                return true;
            if (point1 == null || point2 == null)
                return false;
            if (!point1.X.Equals(point2.X))
                return false;
            if (!point1.Z.Equals(point2.Z))
                return false;
            return true;
        }

        public int GetHashCode(Point3D obj)
        {
            Point3D point = obj as Point3D;
            if (point == null)
                return 0;
            int prime = 83;
            int result = 1;
            unchecked
            {
                result = result * prime + point.X.GetHashCode();
                result = result * prime + point.Y.GetHashCode();
                result = result * prime + point.Z.GetHashCode();
            }
            return result;
        }
    }
    /// <summary>
    /// A structure holding a pair {key, value}
    /// </summary>
    /// <typeparam name="TKey">the type of the keys</typeparam>
    /// <typeparam name="TValue">the type of the values</typeparam>
    public struct KeyValuePair<TKey, TValue>
    {
        /// <summary>
        /// Holds the key of the key-value pair
        /// </summary>
        public TKey Key { get; private set; }
        /// <summary>
        /// Holds the value of the key-value pair
        /// </summary>
        public TValue Value { get; private set; }
        /// <summary>
        /// Constructs a pair by given key + value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public KeyValuePair(TKey key, TValue value):this()
        {
            this.Key = key;
            this.Value = value;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append('[');
            if(this.Key != null)
            {
                builder.Append(this.Key.ToString());
            }
            builder.Append(",");
            if(this.Value != null)
            {
                builder.Append(this.Value.ToString());
            }
            builder.Append(']');
            return builder.ToString();
        }
    }

}
