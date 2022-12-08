﻿namespace BlazorMud.API;

public static class EnvironmentSettings
{
    public static string Host => GetVariable("PG_HOST");
    public static string UserId => GetVariable("PG_USER");
    public static string Password => GetVariable("PG_PASS");
    public static ushort Port => ushort.Parse(GetVariable("PG_PORT"));
    public static string Database => GetVariable("PG_DATABASE");
    
    public static string GetConnectionString()
    {
        return $"Server={Host};Port={Port};Database={Database};User Id={UserId};Password={Password}";
    }
    
    private static string GetVariable(string name)
    {
        var variable = Environment.GetEnvironmentVariable(name);
        if (string.IsNullOrEmpty(variable))
            throw new ArgumentException($"Environment variable \"{name}\" not set");
        return variable;
    }
}