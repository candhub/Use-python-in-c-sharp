namespace CD;

public static class Python
{
    public static string Get_box_svg()
    {
        var engine = IronPython.Hosting.Python.CreateEngine();
        var scope = engine.CreateScope();

        var source = engine.CreateScriptSourceFromFile(@"/Users/ben/Desktop/OCCT/OCCT/test.py");
        source.Execute(scope);

        var make_box = scope.GetVariable<Func<string>>("Make_box");
        return make_box();
    }
}
