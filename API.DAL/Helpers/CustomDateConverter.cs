using Newtonsoft.Json.Converters;

namespace API.DAL.Helpers
{
    class CustomDateConverter : IsoDateTimeConverter
    {
        public CustomDateConverter()
        {
            base.DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
