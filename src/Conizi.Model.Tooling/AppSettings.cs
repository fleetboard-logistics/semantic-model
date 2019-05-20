namespace Conizi.Model.Generator
{
    public class AppSettings
    {
        public  Generator GeneratorSettings { get; set; }

        public class Generator
        {
            public string JsonSchemaLicense { get; set; }
        }
    }
}
