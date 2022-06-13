// Copyright (c) 2012-2022 Wojciech Figat. All rights reserved.

using System;
using System.ComponentModel;
using System.Globalization;

namespace FlaxEngine.TypeConverters
{
    internal class Float4Converter : TypeConverter
    {
        /// <inheritdoc />
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }

        /// <inheritdoc />
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string str)
            {
                string[] v = str.Split(',');
                return new Float4(float.Parse(v[0]), float.Parse(v[1]), float.Parse(v[2]), float.Parse(v[3]));
            }
            return base.ConvertFrom(context, culture, value);
        }

        /// <inheritdoc />
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                var v = (Float4)value;
                return v.X + "," + v.Y + "," + v.Z + "," + v.W;
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}