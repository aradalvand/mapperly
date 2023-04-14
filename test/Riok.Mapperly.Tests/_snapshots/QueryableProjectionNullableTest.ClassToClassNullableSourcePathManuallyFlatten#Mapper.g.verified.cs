﻿//HintName: Mapper.g.cs
#nullable enable
public partial class Mapper
{
    public partial global::System.Linq.IQueryable<global::B> Map(global::System.Linq.IQueryable<global::A> q)
    {
#nullable disable
        return System.Linq.Queryable.Select(q, x => new global::B() { NestedValue4 = x.Nested != null && x.Nested.Nested2 != null ? x.Nested.Nested2.Value3 : default });
#nullable enable
    }

    private partial global::B Map(global::A source)
    {
        var target = new global::B();
        if (source.Nested?.Nested2 != null)
        {
            target.NestedValue4 = source.Nested.Nested2.Value3;
        }

        return target;
    }
}