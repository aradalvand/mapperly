//HintName: Mapper.g.cs
// <auto-generated />
#nullable enable
public partial class Mapper
{
    partial global::B Map(global::A source)
    {
        var target = new global::B();
        target.Value = source.Value.ToString();
        return target;
    }
}