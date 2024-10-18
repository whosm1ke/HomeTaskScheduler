using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;

namespace HomeTaskScheduler.Persistence.Extensions;

public static class JsonConversionExtensions
{
    public static PropertyBuilder<T> HasJsonConversion<T>(this PropertyBuilder<T> propertyBuilder,
        string columnType = null, string columnName = "", JsonSerializerSettings settings = null)
    {
        var converter = new ValueConverter<T, string>(
            v => JsonConvert.SerializeObject(v, settings),
            v => JsonConvert.DeserializeObject<T>(v, settings));

        var comparer = new ValueComparer<T>(
            (l, r) => JsonConvert.SerializeObject(l, settings) == JsonConvert.SerializeObject(r, settings),
            v => v == null ? 0 : JsonConvert.SerializeObject(v, settings).GetHashCode(),
            v => JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(v, settings), settings));

        propertyBuilder.HasConversion(converter);
        if (columnType != null) propertyBuilder.HasColumnType(columnType);

        if (columnName == "")
            propertyBuilder.HasColumnName($"{propertyBuilder.Metadata.Name}");
        else if (columnName != null)
            propertyBuilder.HasColumnName(columnName);

        propertyBuilder.Metadata.SetValueConverter(converter);
        propertyBuilder.Metadata.SetValueComparer(comparer);

        return propertyBuilder;
    }

    public static PropertyBuilder<TEnum?> HasByteEnumConversion<TEnum>(this PropertyBuilder<TEnum?> propertyBuilder)
        where TEnum : struct
    {
        propertyBuilder
            .HasConversion(x => Convert.ToByte(x), x => Enum.Parse<TEnum>(x.ToString()));

        return propertyBuilder;
    }

    public static PropertyBuilder<TEnum> HasByteEnumConversion<TEnum>(this PropertyBuilder<TEnum> propertyBuilder)
        where TEnum : struct //Enum
    {
        propertyBuilder
            .IsRequired()
            .HasValueGenerator((p, e) =>
                throw new NullReferenceException(
                    $@"The column ""{p.Name}"" in ""{e.DisplayName()}"" does not allow nulls."))
            .HasConversion(x => Convert.ToByte(x), x => Enum.Parse<TEnum>(x.ToString()));

        return propertyBuilder;
    }
}