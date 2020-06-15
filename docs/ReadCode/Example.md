# Example

``` csharp

public class C1
{
    private bool allowForwardSlash;

    public bool AllowForwardSlash
    {
        get { return allowForwardSlash; }
    }

    public C1(bool allowForwardSlash)
    {
            this.allowForwardSlash = allowForwardSlash;
    }

    protected int Check(string opt)
    {
            char[] c = null;
            if (opt.Length < 2)
            {
                return 0;
            }
            else if (opt.Length > 2)
            {
                c = opt.ToCharArray(0, 3);
                if (c[0] == '-' && c[1] == '-' && IsValid(c[2])) return 2;
            }
            else
            {
                c = opt.ToCharArray(0, 2);
            }
            if ((c[0] == '-' || c[0] == '/' && AllowForwardSlash) && IsValid(c[1])) return 1;
            return 0;
    }

    protected virtual bool IsValid(char c)
    {
            return Char.IsLetterOrDigit(c) || c == '?';
    }
}

```