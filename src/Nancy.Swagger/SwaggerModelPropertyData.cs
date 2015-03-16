using System;

namespace Nancy.Swagger
{
    [SwaggerApi]
    public class SwaggerModelPropertyData : SwaggerDataType
    {
        public object DefaultValue { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public bool Required { get; set; }

        public Type Type { get; set; }

        public bool UniqueItems { get; set; }
    }
}