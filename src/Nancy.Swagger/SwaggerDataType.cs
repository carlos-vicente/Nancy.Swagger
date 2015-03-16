using System.Collections.Generic;

namespace Nancy.Swagger
{
    public class SwaggerDataType
    {
        public string Format { get; set; }

        public IEnumerable<string> Enum { get; set; }

        public long? Minimum { get; set; }

        public long? Maximum { get; set; }
    }
}
