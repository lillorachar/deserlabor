public class Scope
{
    public Dictionary<string, double> Variables { get; set; } = new Dictionary<string, double>();
}

public static class ExpressionParser
{
    public static Expression Parse(string expr, Scope scope)
    {
        // Implement parsing logic here
        // For simplicity, assume we just return an Expression object
        return new Expression(expr, scope);
    }
}

public class Expression
{
    public string Expr { get; }
    public Scope Scope { get; }

    public Expression(string expr, Scope scope)
    {
        Expr = expr;
        Scope = scope;
    }

    // Additional methods to evaluate or manipulate the expression
}
