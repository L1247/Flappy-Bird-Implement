using System;
using Random = UnityEngine.Random;

public static class EnumExtensions
{
    public static Enum GetRandomEnumValue(this Type t)
    {
        Array       values            = Enum.GetValues(typeof(HoleDirectionType));
        var         spaceTypeNum      = Random.Range(0, values.Length);
        HoleDirectionType randomHoleDirectionType = (HoleDirectionType)values.GetValue(spaceTypeNum);
        return randomHoleDirectionType;
    }
}