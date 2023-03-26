using System.ComponentModel;

namespace Lanyard
{
    internal class SerializableExpandableObjectConverter : ExpandableObjectConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType != typeof(string) && base.CanConvertTo(context, destinationType);
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType != typeof(string) && base.CanConvertFrom(context, sourceType);
        }
    }
}