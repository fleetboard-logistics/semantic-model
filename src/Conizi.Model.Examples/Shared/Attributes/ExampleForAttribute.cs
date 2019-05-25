using System;

namespace Conizi.Model.Examples.Shared.Attributes
{
    public class ExampleForAttribute : Attribute
    {
        public Type ExampleType { get; set; }
        public bool HasExampleValue { get; set; }
        public object ExampleValue { get; set; }

        public ExampleForAttribute(Type exampleType)
        {
            this.ExampleType = exampleType;
        }


        public ExampleForAttribute(object exampleType)
        {
            this.ExampleType = exampleType.GetType();
            this.HasExampleValue = true;
        }
    }
}
