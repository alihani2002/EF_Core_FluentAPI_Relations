using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF_Models.dataTypeConvension
{


    public class DateOnlyCustomConverter : ValueConverter<DateOnly, DateTime>
    {
        public DateOnlyCustomConverter()
            : base(dateOnly =>
                    dateOnly.ToDateTime(TimeOnly.MinValue),
                dateTime => DateOnly.FromDateTime(dateTime))
        { 
        }
    }

}
 