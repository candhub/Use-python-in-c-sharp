namespace CD;

public static class Python
{
    private static readonly string path = @"/Users/ben/Desktop/OCCT/OCCT/test.py";

    public static string Get_box_svg()
    {
        var engine = IronPython.Hosting.Python.CreateEngine();
        var scope = engine.CreateScope();

        var source = engine.CreateScriptSourceFromFile(path);
        source.Execute(scope);

        // var make_box = scope.GetVariable<Func<string>>("Make_box");
        var make_box = scope.GetVariable<Func<string>>("Say_hello");
        return make_box();
    }
}
